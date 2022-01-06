using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace M64MMOrkestrator.KIO
{
    public class Timeline
    {
        public Dictionary<string, KeyframeRack> KeyframeRacks { get; } = new Dictionary<string, KeyframeRack>();

        private uint _trackHead;

        public bool Synchronize { get; set; } = true;

        public bool Playing { get; set; }

        public bool Loop { get; set; }

        public int Length { get; set; }

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

        public List<string> SelectedRacks { get; set; } = new List<string>();
        public string ActiveRack { get; set; }

        public List<Keyframe> SelectedKeyframes { get; set; } = new List<Keyframe>();

        public uint TrackheadPosition
        {
            get => _trackHead;
            set
            {
                _trackHead = value;
                foreach (KeyframeRack kRack in KeyframeRacks.Values)
                {
                    if (Synchronize) kRack.CurrentFrame = value;
                    else kRack.ReferenceFrame = value;
                }
            }
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
