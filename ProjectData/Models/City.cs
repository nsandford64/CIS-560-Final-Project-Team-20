using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class City
    {
        public int CityID { get; }
        public string CityName { get; }

        public string StateName { get; }

        public City(int ID, string city, string state)
        {
            CityID = ID;
            CityName = city;
            StateName = state;
        }
    }
}
