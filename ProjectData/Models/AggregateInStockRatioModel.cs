using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class AggregateInStockRatioModel
    {
        public string StoreName;

        public string StoreAddress;

        public int ZipCode;

        public decimal InStock;

        public decimal OutOfStock;

        public decimal StockRatio;

        public AggregateInStockRatioModel(string name, string address, int zip, decimal stock, decimal outStock, decimal ratio)
        {
            StoreName = name;
            StoreAddress = address;
            ZipCode = zip;
            InStock = stock;
            OutOfStock = outStock;
            StockRatio = ratio;
        }
    }
}
