using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class ComponentStorefront
    {
        public string Address { get; }

        public string ZipCode { get; }

        public decimal Price { get; }

        public bool InStock { get; }

        public ComponentStorefront(string address, string zipCode, decimal price, bool inStock)
        {
            Address = address;
            ZipCode = zipCode;
            Price = price;
            InStock = inStock;
        }
    }
}
