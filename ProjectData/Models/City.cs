using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class City
    {
        public string CityName { get; }

        public string StateName { get; }

        public City(string city, string state)
        {
            CityName = city;
            StateName = state;
        }
    }
}
