using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class ComponentStorefront
    {
        public string StoreName { get; }

        public string ComponentName { get; }

        public decimal Price { get; }

        public bool InStock { get; }

        public ComponentStorefront(string name, string component, decimal price, bool inStock)
        {
            StoreName = name;
            ComponentName = component;
            Price = price;
            InStock = inStock;
        }
    }
}
