using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class AggregateStockModel
    {
        public string StoreName;

        public string StoreAddress;

        public int ZipCode;

        public decimal TotalValue;

        public int NumberInStock;

        public decimal AveragePrice;

        public AggregateStockModel(string name, string address, int zip, decimal total, int num, decimal avg)
        {
            StoreName = name;
            StoreAddress = address;
            ZipCode = zip;
            TotalValue = total;
            NumberInStock = num;
            AveragePrice = avg;
        }
    }
}
