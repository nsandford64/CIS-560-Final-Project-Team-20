using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class Manufacturer
    {
        public int ManufacturerID { get; }

        public string ManufacturerName { get; }

        public Manufacturer(int ManufacturerID, string ManufacturerName)
        {
            this.ManufacturerID = ManufacturerID;
            this.ManufacturerName = ManufacturerName;
        }
    }
}
