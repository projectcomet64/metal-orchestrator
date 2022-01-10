using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M64MMOrkestrator.KIO;

namespace M64MMOrkestrator.Classes
{
    public class UncommittedRackChange : IDisposable
    {
        // TODO: finish this
        private Keyframe[] _affectedKeyframes;

        public Keyframe[] Keyframes => _affectedKeyframes;

        public KeyframeType? NewInterpolation { get; set; }

        private int _delta;

        /// <summary>
        /// By how much would the affected keyframes move? Limited to the very beginning of the Timeline relative to the first keyframe.
        /// </summary>
        public int Delta
        {
            get => _delta;
            set
            {
                if (value + EarliestFrame < 0)
                {
                    _delta = -EarliestFrame;
                }
                else
                {
                    _delta = value;
                }
            }
        }

        public UncommittedRackChange(Keyframe[] toChange)
        {
            _affectedKeyframes = toChange;
        }

        public bool CanMoveBackwards => (Delta + EarliestFrame) >= 0;

        public int EarliestFrame => (int)_affectedKeyframes.Select(x => x.Position).Min();

        public void Dispose()
        {
            _affectedKeyframes = new Keyframe[]{};
        }
    }
}
