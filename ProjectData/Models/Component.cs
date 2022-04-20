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

        public int ManufacturerID { get; }

        public ComponentCategory ComponentCategoryID { get; }

        public int MSRP { get; }

        public Component(int CID, string CN, string MN, int MID, ComponentCategory CCID, int M)
        {
            ComponentID = CID;
            ComponentName = CN;
            ModelNumber = MN;
            ManufacturerID = MID;
            ComponentCategoryID = CCID;
            MSRP = M;
        }
    }
}
