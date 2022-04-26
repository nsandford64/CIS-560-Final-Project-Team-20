using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class Storefront
    {
        public Storefront(int ID, string name, string address, string zipCode, string cityName)
        {
            StoreID = ID;
            StoreName = name;
            StoreAddress = address;
            ZipCode = zipCode;
            CityName = cityName;
        }

        public int StoreID { get; }

        public string StoreName { get; }

        public string StoreAddress { get; }

        public string ZipCode { get; }

        public string CityName { get; }
    }
}
