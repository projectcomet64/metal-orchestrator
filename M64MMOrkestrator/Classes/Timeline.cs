using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace M64MMOrkestrator.KIO
{
    public class Timeline
    {
        public Dictionary<string, KeyframeRack> krList = new Dictionary<string, KeyframeRack>();

        private uint _trackHead;

        public bool Synchronize { get; set; } = true;

        public Region LoopRegion { get; set; }

        public List<Region> Regions { get; set; }

        public List<Marker> Markers { get; set; }

        public List<string> SelectedRacks { get; set; } = new List<string>();
        public string ActiveRack { get; set; }

        public uint TrackheadPosition
        {
            get => _trackHead;
            set
            {
                _trackHead = value;
                foreach (KeyframeRack kRack in krList.Values)
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
                krList[rack].AddCurrentStateAtPosition(TrackheadPosition);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception while trying to update rack with ID {rack}: {ex.Message}");
            }
        }

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
