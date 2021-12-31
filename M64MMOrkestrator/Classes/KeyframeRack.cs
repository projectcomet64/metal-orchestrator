using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MMOrkestrator.Extensions;

namespace M64MMOrkestrator.KIO
{

    public abstract class KeyframeRack
    {

        public string Name { get; set; }


        internal uint _currentFrame;

        public uint CurrentFrame
        {
            get => _currentFrame;
            set
            {
                _currentFrame = value;
                ReferenceFrame = value;
                OnCurrentFrameChanged.Invoke();
            }
        }

        /// <summary>
        /// Used when Timeline Sync is not enabled
        /// </summary>
        public uint ReferenceFrame
        {
            get => _currentFrame;
            set
            {
                _currentFrame = value;
            }
        }

        /// <summary>
        /// Adds the current value from the Getter Delegate at the desired position
        /// </summary>
        /// <param name="framepos"></param>
        public abstract void AddCurrentStateAtPosition(uint framepos);

        public delegate void CurrentFrameChanged();
        /// <summary>
        /// Triggers whenever the frame is changed. (if overlying Timeline has "Sync" mode on, this triggers everytime)
        /// </summary>
        public event CurrentFrameChanged OnCurrentFrameChanged;

    }

    /// <summary>
    /// Base class for Keyframe Racks, which will be the containers of all kinds of keyframes. This class cannot be instantiated.
    /// </summary>
    /// <typeparam name="TKeyframe">The underlying type for the Keyframes.</typeparam>
    public abstract class KeyframeRack<TKeyframe> : KeyframeRack, IList<Keyframe<TKeyframe>> where TKeyframe : new()
    {
        protected List<Keyframe<TKeyframe>> elements;


        protected Keyframe<TKeyframe> basicKeyframe;

        public Keyframe<TKeyframe>[] OrderedKeyframes => elements.OrderBy(k => k.CurrentValue).ToArray();

        public Keyframe<TKeyframe> closestBehindKeyframe;
        public Keyframe<TKeyframe> closestFrontKeyframe;


        protected delegate TKeyframe ValueGetterDelegate();
        protected ValueGetterDelegate valueGetter;

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
            valueGetter = new ValueGetterDelegate(valgetter);
        }

        public KeyframeRack(Func<TKeyframe> valgetter) : this()
        {
            valueGetter = new ValueGetterDelegate(valgetter);
            AddCurrentStateAtPosition(0);
        }

        public uint FarthestKeyframePosition()
        {
            return this.Select(x => x.Position).Max();
        }

        /// <summary>
        /// Reanalyzes the keyframes in front and behind the current trackhead.
        /// </summary>
        public void ReassessClosestFrames()
        {
            Keyframe<TKeyframe>[] oKeyframes = OrderedKeyframes;
            closestBehindKeyframe = oKeyframes.Where(k => k.Position <= ReferenceFrame && k.SubordinateOf == null)
                .OrderByDescending(k => k.CurrentValue).FirstOrDefault();
            closestFrontKeyframe = oKeyframes.Where(k => k.Position > ReferenceFrame && k.SubordinateOf == null)
                .OrderBy(k => k.CurrentValue).FirstOrDefault();
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
            if (closestFrontKeyframe == null) return closestBehindKeyframe.CurrentValue;

            switch (closestBehindKeyframe.InterpolationType)
            {
                case KeyframeType.Bezier:
                {
                    return NBezier(closestBehindKeyframe.Subordinates,
                        TrackHeadDistanceToKeyframe(closestBehindKeyframe) /
                        closestBehindKeyframe.Distance(closestFrontKeyframe));
                        break;
                }
                case KeyframeType.Linear:
                default:
                {
                    return Lerp(closestBehindKeyframe, closestFrontKeyframe,
                        TrackHeadDistanceToKeyframe(closestBehindKeyframe) /
                        closestBehindKeyframe.Distance(closestFrontKeyframe));
                    break;
                    }
                case KeyframeType.Hold:
                {
                    return closestBehindKeyframe.CurrentValue;
                        break;
                }
                case KeyframeType.Shake:
                {
                    return NShake(closestBehindKeyframe.Subordinates);
                    break;
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

        bool IsPositionBetweenTwoKeyframes(uint position, Keyframe<TKeyframe> start, Keyframe<TKeyframe> end) =>
            (position < end.Position && position > start.Position);

        public override void AddCurrentStateAtPosition(uint framepos)
        {
            TKeyframe currentVal = valueGetter();
            ReassessClosestFrames();
            if (!IsPositionBetweenTwoKeyframes(CurrentFrame, closestBehindKeyframe, closestFrontKeyframe))
            {
                Keyframe<TKeyframe> found = this.First(x => x.Position == CurrentFrame);
                found.CurrentValue = currentVal;
                return;
            }
            Keyframe<TKeyframe> _keyframe = new Keyframe<TKeyframe>(currentVal)
            {
                Position = CurrentFrame
            };
            Add(_keyframe);
        }


        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count => elements.Count();

        public void Add(Keyframe<TKeyframe> item)
        {
            elements.Add(item);
            if (IsPositionBetweenTwoKeyframes(item.Position, closestBehindKeyframe, closestFrontKeyframe))
            {
                ReassessClosestFrames();
            }
        }

        public void Clear()
        {
            elements.Clear();
            AddCurrentStateAtPosition(0);
        }

        public bool Remove(Keyframe<TKeyframe> item)
        {
            if (elements.Count == 0) return false;
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

    
    
}
