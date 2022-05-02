using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class ComponentDisplay
    {
        public string State { get; }

        public string City { get; }

        public string Address { get; }

        public int ZipCode { get; }

        public string Storefront { get; }

        public ComponentCategory Category { get; }

        public string ComponentName { get; }

        public string ModelNumber { get; }

        public string Manufacturer { get; }

        public decimal Price { get; }

        public object InStock { get; }



        public ComponentDisplay(string name, string model, string manufacturer, ComponentCategory category, decimal price, object stock, string store, string address, int zip, string city, string state)
        {
            ComponentName = name;
            ModelNumber = model;
            Manufacturer = manufacturer;
            Category = category;
            Price = price;
            InStock = stock;
            Address = address;
            ZipCode = zip;
            Storefront = store;
            City = city;
            State = state;
        }
    }
}
