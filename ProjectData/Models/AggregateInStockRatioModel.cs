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

        public int InStock;

        public int OutOfStock;

        public decimal StockRatio;

        public AggregateInStockRatioModel(string name, string address, int zip, int stock, int outStock, decimal ratio)
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
