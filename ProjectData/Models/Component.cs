using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class Component
    {
        public int ComponentID { get; }

        public string ComponentName { get; }

        public string ModelNumber { get; }

        public string Manufacturer { get; }

        public ComponentCategory ComponentCategory { get; }

        public decimal MSRP { get; }

        public Component(int CID, string CN, string MN, string MID, ComponentCategory CCID, decimal M)
        {
            ComponentID = CID;
            ComponentName = CN;
            ModelNumber = MN;
            Manufacturer = MID;
            ComponentCategory = CCID;
            MSRP = M;
        }
    }
}
