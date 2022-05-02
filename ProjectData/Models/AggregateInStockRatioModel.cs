﻿using System;
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

        public int StockRatio;

        public AggregateInStockRatioModel(string name, string address, int zip, int stock, int ratio)
        {
            StoreName = name;
            StoreAddress = address;
            ZipCode = zip;
            InStock = stock;
            StockRatio = ratio;
        }
    }
}
