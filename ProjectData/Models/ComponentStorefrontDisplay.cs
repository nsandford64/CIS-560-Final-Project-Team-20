using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class ComponentStorefrontDisplay
    {
        public ComponentStorefrontDisplay(string component, string address, int zip, string model, decimal price, bool stock)
        {
            ComponentName = component;
            StoreAddress = address;
            ZipCode = zip;
            ModelNumber = model;
            Price = price;
            InStock = stock;
        }

        public string ComponentName { get; }

        public string StoreAddress { get; }

        public int ZipCode { get; }

        public string ModelNumber { get; }

        public decimal Price { get; }

        public bool InStock { get; }
    }
}
