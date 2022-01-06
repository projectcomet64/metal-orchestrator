using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MMOrkestrator.Classes;
using M64MMOrkestrator.Extensions;

namespace M64MMOrkestrator.KIO
{

    public abstract class KeyframeRack
    {

        public string Name { get; set; }

        public virtual List<Keyframe> OrderedGenericList { get; set; }

        /// <summary>
        /// Returns the keyframe found at the specified frame. Null if there's none.
        /// </summary>
        /// <param name="frame">Frame to get the keyframe from</param>
        /// <returns></returns>
        public abstract Keyframe GetKeyframeAtPosition(int frame);

        public abstract void Commit(UncommittedRackChange changes);


        internal int _currentFrame;

        public int CurrentFrame
        {
            get => _currentFrame;
            set
            {
                if (value < 0) value = 0;
                _currentFrame = value;
                ReferenceFrame = value;
                OnCurrentFrameChanged.Invoke();
            }
        }

        /// <summary>
        /// Used when Timeline Sync is not enabled
        /// </summary>
        public int ReferenceFrame
        {
            get => _currentFrame;
            set => _currentFrame = value;
        }

        /// <summary>
        /// Adds the current value from the Getter Delegate at the desired position
        /// </summary>
        /// <param name="framepos"></param>
        public abstract void AddCurrentStateAtPosition(int framepos);

        public delegate void CurrentFrameChanged();
        /// <summary>
        /// Triggers whenever the frame is changed. (if overlying Timeline has "Sync" mode on, this triggers everytime)
        /// </summary>
        public event CurrentFrameChanged OnCurrentFrameChanged;

        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// Base class for Keyframe Racks, which will be the containers of all kinds of keyframes. This class cannot be instantiated.
    /// </summary>
    /// <typeparam name="TKeyframe">The underlying type for the Keyframes.</typeparam>
    public abstract class KeyframeRack<TKeyframe> : KeyframeRack, IList<Keyframe<TKeyframe>> where TKeyframe : new()
    {
        protected List<Keyframe<TKeyframe>> elements;


        protected Keyframe<TKeyframe> basicKeyframe;

        public List<Keyframe<TKeyframe>> OrderedKeyframes => elements.OrderBy(k => k.Position).ToList();

        public override List<Keyframe> OrderedGenericList { get => OrderedKeyframes.Cast<Keyframe>().ToList(); }

        public Keyframe<TKeyframe> closestBehindKeyframe;
        public Keyframe<TKeyframe> closestFrontKeyframe;


        protected Func<TKeyframe> valueGetter;

        protected KeyframeRack()
        {
            elements = new List<Keyframe<TKeyframe>>();
        }

        /// <summary>
        /// Initializes a KeyframeRack with a value getter and an initial keyframe.
        /// </summary>
        /// <param name="initialKeyframe"></param>
        /// <param name="valgetter"></param>
        public KeyframeRack(Keyframe<TKeyframe> initialKeyframe, Func<TKeyframe> valgetter) : this()
        {
            elements.Add(initialKeyframe);
            basicKeyframe = initialKeyframe;
            valueGetter = valgetter;
        }

        public KeyframeRack(Func<TKeyframe> valgetter) : this()
        {
            valueGetter = valgetter;
            AddCurrentStateAtPosition(0);
        }

        public int FarthestKeyframePosition()
        {
            return this.Select(x => x.Position).Max();
        }

        /// <summary>
        /// Returns the keyframe found at the specified frame. Null if there's none.
        /// </summary>
        /// <param name="frame">Frame to get the keyframe from</param>
        /// <returns></returns>
        public override Keyframe GetKeyframeAtPosition(int frame)
        {
            if (frame < 0) return null;

            return elements.FirstOrDefault(x => x.Position == frame);
        }

        /// <summary>
        /// Reanalyzes the keyframes in front and behind the current trackhead.
        /// </summary>
        public void ReassessClosestFrames()
        {
            List<Keyframe<TKeyframe>> oKeyframes = OrderedKeyframes;
            closestBehindKeyframe = oKeyframes.Where(k => k.Position <= ReferenceFrame && k.SubordinateOf == null)
                .OrderByDescending(k => k.Position).FirstOrDefault();
            closestFrontKeyframe = oKeyframes.Where(k => k.Position > ReferenceFrame && k.SubordinateOf == null)
                .OrderBy(k => k.Position).FirstOrDefault();
        }

        /// <summary>
        /// Returns the distance of the trackhead to the specified keyframe. Throws exception if Keyframe is not present in the KeyframeRack.
        /// </summary>
        /// <param name="kf">The Keyframe to get the distance from</param>
        /// <returns></returns>
        public int TrackHeadDistanceToKeyframe(Keyframe kf)
        {
            return (int)Math.Abs(ReferenceFrame - kf.Position);
        }

        /// <summary>
        /// Calculates the interpolation in the current track head position.
        /// </summary>
        /// <param name="reassess"></param>
        /// <returns></returns>
        public virtual TKeyframe CalculateInterpolation(bool reassess = true)
        {
            if (reassess) ReassessClosestFrames();
            if (closestBehindKeyframe == null) return closestFrontKeyframe.CurrentValue;
            if (closestFrontKeyframe == null) return closestBehindKeyframe.CurrentValue;

            switch (closestBehindKeyframe.InterpolationType)
            {
                case KeyframeType.Bezier:
                    {
                        return NBezier(closestBehindKeyframe.Subordinates,
                            (float)TrackHeadDistanceToKeyframe(closestBehindKeyframe) /
                            closestBehindKeyframe.Distance(closestFrontKeyframe));
                    }
                case KeyframeType.Linear:
                default:
                    {
                        return Lerp(closestBehindKeyframe, closestFrontKeyframe,
                            (float)TrackHeadDistanceToKeyframe(closestBehindKeyframe) /
                            closestBehindKeyframe.Distance(closestFrontKeyframe));
                    }
                case KeyframeType.Hold:
                    {
                        return closestBehindKeyframe.CurrentValue;
                    }
                case KeyframeType.Shake:
                    {
                        return NShake(closestBehindKeyframe.Subordinates);
                    }

            }

        }

        /// <summary>
        /// Performs a Linear Interpolation between two Keyframes.
        /// </summary>
        /// <param name="start">Starting keyframe</param>
        /// <param name="end">Ending keyframe</param>
        /// <param name="position">Position of the linear interpolation (clamped between 0 and 1)</param>
        /// <returns></returns>
        public abstract TKeyframe Lerp(Keyframe<TKeyframe> start, Keyframe<TKeyframe> end, float position);

        /// <summary>
        /// Performs an N-Bezier interpolation on an array of Keyframes.<para>The first element in the array is the starting point,
        /// the last element in the array is the ending point. Anything in-between is a "control point".</para>
        /// </summary>
        /// <param name="points"><para>Keyframes that compose the Bezier curve.</para></param>
        /// <param name="position"></param>
        /// <returns>Position in the curve (clamped between 0 and 1)</returns>
        public abstract TKeyframe NBezier(Keyframe<TKeyframe>[] points, float position);

        /// <summary>
        /// <para>Performs "shaking" on several "target" keyframes starting from the first keyframe in the array.</para>
        /// <para>Every frame, chooses a keyframe at random and chooses a random linear interpolation progress.</para>
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public abstract TKeyframe NShake(Keyframe<TKeyframe>[] points);

        bool IsPositionBetweenTwoKeyframes(int position, Keyframe<TKeyframe> start, Keyframe<TKeyframe> end)
        {
            if (start == null || end == null) return false;
            return (position < end.Position && position > start.Position);
        }


        public override void AddCurrentStateAtPosition(int framepos)
        {
            TKeyframe currentVal = valueGetter();
            ReassessClosestFrames();
            if (closestBehindKeyframe != null && !IsPositionBetweenTwoKeyframes(CurrentFrame, closestBehindKeyframe, closestFrontKeyframe) && closestBehindKeyframe.Position == CurrentFrame)
            {
                closestBehindKeyframe.CurrentValue = currentVal;
                return;
            }
            Keyframe<TKeyframe> _keyframe = new Keyframe<TKeyframe>(currentVal)
            {
                Position = CurrentFrame
            };
            Add(_keyframe);
        }

        public override void Commit(UncommittedRackChange changes)
        {
            int[] frameNumbers = changes.Keyframes.Select(x => (x.Position + changes.Delta)).ToArray();
            List<Keyframe> conflicts = new List<Keyframe>();
            conflicts.AddRange(elements.Where(x => frameNumbers.Contains(x.Position)));
            foreach (Keyframe conflKeyframe in conflicts)
            {
                elements.Remove((Keyframe<TKeyframe>)conflKeyframe);
            }
            foreach (Keyframe kf in changes.Keyframes)
            {
                kf.Position += changes.Delta;
            }
        }


        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count => elements.Count();

        public void Add(Keyframe<TKeyframe> item)
        {
            elements.Add(item);
            ReassessClosestFrames();
        }

        public void Clear()
        {
            elements.Clear();
            AddCurrentStateAtPosition(0);
        }

        public bool Remove(Keyframe<TKeyframe> item)
        {
            if (elements.Count < 2) return false;
            bool worked = elements.Remove(item);
            if (!worked) return false;

            if (closestBehindKeyframe == null || closestFrontKeyframe == null)
            {
                ReassessClosestFrames();
            }

            return true;
        }

        public bool Contains(Keyframe<TKeyframe> item)
        {
            return elements.Contains(item);
        }

        public IEnumerator<Keyframe<TKeyframe>> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public int IndexOf(Keyframe<TKeyframe> item)
        {
            return elements.IndexOf(item);
        }

        public void Insert(int index, Keyframe<TKeyframe> item)
        {
            elements.Insert(index, item);

        }

        public void RemoveAt(int index)
        {
            if (elements.Count < 2) return;
            elements.RemoveAt(index);
            if (closestBehindKeyframe == null || closestFrontKeyframe == null)
            {
                ReassessClosestFrames();
            }
        }

        public void CopyTo(Keyframe<TKeyframe>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public Keyframe<TKeyframe> this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }
    }


    public class Vector3KeyframeRack : KeyframeRack<Vector3>
    {

        public Vector3KeyframeRack(Keyframe<Vector3> initialKeyframe, Func<Vector3> valgetter) : base(initialKeyframe, valgetter) { }

        public Vector3KeyframeRack(Func<Vector3> valgetter) : base(valgetter) { }

        public override Vector3 Lerp(Keyframe<Vector3> start, Keyframe<Vector3> end, float position)
        {
            return Vector3.Lerp(start.CurrentValue, end.CurrentValue, position);
        }

        public override Vector3 NBezier(Keyframe<Vector3>[] points, float position)
        {
            return MathExtensions.BezierInterpolate(points.Select(x => x.CurrentValue).ToArray(), position);
        }

        public override Vector3 NShake(Keyframe<Vector3>[] points)
        {
            // TODO: Implement shaking
            return points[0].CurrentValue;
        }
    }

    public class XYAngleKeyframeRack : KeyframeRack<XYAngle>
    {

        public XYAngleKeyframeRack(Keyframe<XYAngle> initialKeyframe, Func<XYAngle> valgetter) : base(initialKeyframe, valgetter) { }

        public XYAngleKeyframeRack(Func<XYAngle> valgetter) : base(valgetter) { }

        public override XYAngle Lerp(Keyframe<XYAngle> start, Keyframe<XYAngle> end, float position)
        {
            return XYAngle.Lerp(start.CurrentValue, end.CurrentValue, position);
        }

        public override XYAngle NBezier(Keyframe<XYAngle>[] points, float position)
        {
            return MathExtensions.BezierInterpolate(points.Select(x => x.CurrentValue).ToArray(), position);
        }

        public override XYAngle NShake(Keyframe<XYAngle>[] points)
        {
            // TODO: Implement shaking
            return points[0].CurrentValue;
        }
    }



}
