using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    public class InsertComponentDataDelegate
    {
        private readonly string name;
        private readonly string modelNo;
        private readonly string manufacturer;
        private readonly string category;
        private readonly int MSRP;

        public InsertComponentDataDelegate(string name, string modelNo, string manufacturer, string category, int MSRP)
            //base : ("PartFinder.InsertComponent")
        {
            this.name = name;
            this.modelNo = modelNo;
            this.manufacturer = manufacturer;
            this.category = category;
            this.MSRP = MSRP;
        }
    }
}
