using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MMOrkestrator.Classes;

namespace M64MMOrkestrator.KIO
{
    public class Timeline
    {
        // TODO: Make this one private and expose a readonlydictionary instead
        public Dictionary<string, KeyframeRack> KeyframeRacks { get; } = new Dictionary<string, KeyframeRack>();

        public Dictionary<string, UncommittedRackChange> UncommittedRackChanges { get; } =
            new Dictionary<string, UncommittedRackChange>();

        private int _trackHead;

        public bool Synchronize { get; set; } = true;

        public bool Playing { get; set; }

        public bool Loop { get; set; }

        public int Length { get; set; }

        public string TimecodeString(int frames = 30)
        {
            int frm, second, minute, hour;
            frm = TrackheadPosition % frames;
            second = (int)Math.Floor((double)TrackheadPosition / frames);
            minute = (int)Math.Floor((double)second / 60);
            hour = (int)Math.Floor((double)minute / 60);
            return $"{hour:D2}:{minute:D2}:{second:D2}.{frm:D2}";

        }

        public Region LoopRegion { get; set; }

        public List<Region> Regions { get; set; }

        public List<Marker> Markers { get; set; }


        // TODO FUTURE: Add methods to remove and add racks instead of providing direct access to the Dictionary that holds the racks
        public enum KeyframeRackChange
        {
            ADD,
            DELETE,
            TOGGLE // Enable/disable
        }

        public delegate void KeyframeRackChanged (string id, KeyframeRackChange change);

        public event KeyframeRackChanged OnKeyframeRackChanged;

        public delegate void TrackheadChanged(int position);

        public event TrackheadChanged OnTrackheadChanged;

        public List<string> SelectedRacks { get; set; } = new List<string>();
        public string ActiveRack { get; set; }

        public List<Keyframe> SelectedKeyframes { get; set; } = new List<Keyframe>();

        public int TrackheadPosition
        {
            get => _trackHead;
            set
            {
                _trackHead = value;
                OnTrackheadChanged?.Invoke(value);
                foreach (KeyframeRack kRack in KeyframeRacks.Values)
                {
                    if (Synchronize) kRack.CurrentFrame = value;
                    else kRack.ReferenceFrame = value;
                }
            }
        }

        /// <summary>
        /// "Staging" refers to marking keyframes as uncommitted and allowing delta changes to the specific rack, uncommitted.
        /// </summary>
        public void StageSelectedKeyframes()
        {
            foreach (KeyValuePair<string, UncommittedRackChange> uChange in UncommittedRackChanges)
            {
                if (uChange.Value != null) return; // staging area must be clean otherwise no
            }

            foreach (KeyValuePair<string, KeyframeRack> kRack in KeyframeRacks)
            {
                Keyframe[] selected = kRack.Value.OrderedGenericList.Where(x => SelectedKeyframes.Contains(x)).ToArray();
                if (selected.Length == 0) continue;
                UncommittedRackChange changes = new UncommittedRackChange(selected);
                UncommittedRackChanges[kRack.Key] = changes;
            }
        }

        public void MoveAllDeltas(bool forward)
        {
            bool canMove = UncommittedRackChanges.Where(x => x.Value != null).All(x => x.Value?.CanMoveBackwards == true);
            if (!canMove) return;
            foreach (KeyValuePair<string, UncommittedRackChange> uChange in UncommittedRackChanges)
            {
                if (UncommittedRackChanges[uChange.Key] == null) continue;

                UncommittedRackChanges[uChange.Key].Delta += (forward ? 1 : -1);
            }
        }

        public void CommitAllChanges()
        {
            KeyValuePair<string, UncommittedRackChange>[] ucArray = UncommittedRackChanges.Cast<KeyValuePair<string, UncommittedRackChange>>().ToArray();
            for (int i = 0; i < ucArray.Length; i++)
            {
                if (UncommittedRackChanges[ucArray[i].Key] == null) continue;

                KeyframeRacks[ucArray[i].Key].Commit(ucArray[i].Value);
                UncommittedRackChanges[ucArray[i].Key] = null;
            }
        }

        public void AddRack(string id, KeyframeRack rack)
        {
            KeyframeRacks.Add(id, rack);
            UncommittedRackChanges.Add(id, null);
        }

        public void AddValueToRack(string rack)
        {
            try
            {
                KeyframeRacks[rack].AddCurrentStateAtPosition(TrackheadPosition);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception while trying to update rack with ID {rack}: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets an array of all generic keyframes found at the current position
        /// </summary>
        /// <returns></returns>
        public Keyframe[] GetKeyframesAtTrackhead()
        {
            List<Keyframe> kfList = new List<Keyframe>();

            if (SelectedRacks.Count == 0)
            {
                if (ActiveRack == null) return new Keyframe[]{};
                else
                {
                    Keyframe foundKeyframe = KeyframeRacks[ActiveRack].GetKeyframeAtPosition((int)TrackheadPosition);
                    if (foundKeyframe != null) kfList.Add(foundKeyframe);
                }
            }
            else
            {
                foreach (string rack in SelectedRacks)
                {
                    Keyframe foundKeyframe = KeyframeRacks[rack].GetKeyframeAtPosition((int)TrackheadPosition);
                    if (foundKeyframe != null) kfList.Add(foundKeyframe);
                }
            }

            return kfList.ToArray();
        }

        /// <summary>
        /// Tells all the underlying Keyframe Racks to add a new keyframe at the trackhead
        /// </summary>
        public void AddAllCurrentValuesToRacks()
        {
            if (SelectedRacks.Count == 0)
            {
                if (ActiveRack == null) return;
                else
                {
                    try
                    {
                        AddValueToRack(ActiveRack);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Exception while trying to update rack with ID {ActiveRack}: {ex.Message}");
                    }
                }
            }
            else
            {
                foreach (string rack in SelectedRacks)
                {
                    try
                    {
                        AddValueToRack(rack);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Exception while trying to update rack with ID {rack}: {ex.Message}");
                    }
                }
            }
        }
    }
}
