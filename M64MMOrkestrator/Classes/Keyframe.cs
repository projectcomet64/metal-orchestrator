using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MMOrkestrator.Properties;

namespace M64MMOrkestrator.KIO
{
    public abstract class Keyframe
    {
        public uint Position { get; set; }

        public KeyframeType InterpolationType { get; set; }

        public int Distance(Keyframe target)
        {
            return (int)Math.Abs(target.Position - this.Position);
        }

        public static readonly Dictionary<KeyframeType, Bitmap> KeyframeInterp = new Dictionary<KeyframeType, Bitmap>()
        {
            {KeyframeType.Linear, Resources.fLinear},
            {KeyframeType.Fast, Resources.fFast},
            {KeyframeType.Slow, Resources.fSlow},
            {KeyframeType.Smooth, Resources.fSmooth},
            {KeyframeType.Sharp, Resources.fSharp},
            {KeyframeType.Hold, Resources.fHold},
            {KeyframeType.Bezier, Resources.fBezier},
            {KeyframeType.Subordinate, Resources.fSub},
            {KeyframeType.Shake, Resources.fShake}
        };

    }
    public class Keyframe<TKeytype> : Keyframe, IKeyframe<TKeytype>
    {

        public Keyframe<TKeytype> SubordinateOf { get; set; }
        public Keyframe<TKeytype>[] Subordinates { get; set; }
        public virtual TKeytype CurrentValue { get; set; }
        

        public Keyframe(TKeytype initialValue)
        {
            CurrentValue = initialValue;
        }

        public static implicit operator TKeytype(Keyframe<TKeytype> x)
        {
            return x.CurrentValue;
        }

        public override string ToString()
        {
            return $"KF ${CurrentValue} @ ${Position}F | ${InterpolationType}";
        }
    }

    public enum KeyframeType
    {
        [Description("Linear")]
        Linear,
        [Description("Fast")]
        Fast,
        [Description("Slow")]
        Slow,
        [Description("Smooth")]
        Smooth,
        [Description("Sharp")]
        Sharp,
        [Description("Hold")]
        Hold,
        [Description("Bezier")]
        Bezier,
        [Description("Random Shake")]
        Shake,
        [Description("Dependent")]
        Subordinate
    }
}
