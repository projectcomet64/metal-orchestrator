using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M64MMOrkestrator.KIO
{
    public abstract class Keyframe
    {
        public uint Position { get; set; }

        KeyframeType InterpolationType { get; set; }

        public int Distance(Keyframe target)
        {
            return (int)Math.Abs(target.Position - this.Position);
        }
    }
    public class Keyframe<TKeytype> : Keyframe, IKeyframe<TKeytype>
    {

        public Keyframe<TKeytype> SubordinateOf { get; set; }
        public Keyframe<TKeytype>[] Subordinates { get; set; }
        public virtual TKeytype CurrentValue { get; set; }
        public uint Position { get; set; }
        public KeyframeType InterpolationType { get; set; }

        public Keyframe(TKeytype initialValue)
        {
            CurrentValue = initialValue;
        }

    public static implicit operator TKeytype(Keyframe<TKeytype> x)
        {
            return x.CurrentValue;
        }

    }

    public enum KeyframeType
    {
        Linear,
        Fast,
        Slow,
        Smooth,
        Sharp,
        Hold,
        Bezier,
        Shake,
        Subordinate
    }
}
