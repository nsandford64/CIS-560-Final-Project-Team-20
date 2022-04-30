using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class AggregateMSRPModel
    {
        public string ComponentCategoryName;

        public int ManufacturerCount;

        public int ComponentCount;

        public AggregateMSRPModel(string name, int manufacturer, int component)
        {
            ComponentCategoryName = name;
            ManufacturerCount = manufacturer;
            ComponentCount = component;
        }
    }
}
