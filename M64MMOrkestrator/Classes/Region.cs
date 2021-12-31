using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M64MMOrkestrator.KIO
{
    public struct Region
    {
        public string Name { get; set; }
        public uint FrameStart { get; set; }
        public uint FrameEnd { get; set; }
    }
}
