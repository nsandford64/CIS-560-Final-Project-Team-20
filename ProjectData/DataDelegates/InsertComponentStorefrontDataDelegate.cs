using DataAccess;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    public class InsertComponentStorefrontDataDelegate : DataDelegate
    {
        private readonly string storeAddress;
        private readonly string zipCode;
        private readonly string modelNo;
        private readonly decimal price;
        private readonly int inStock;

        public InsertComponentStorefrontDataDelegate(string address, string zip, string model, decimal price, int stock)
            : base("PartFinder.InsertComponentStorefront")
        {
            storeAddress = address;
            zipCode = zip;
            modelNo = model;
            this.price = price;
            inStock = stock;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StoreAddress", storeAddress);
            command.Parameters.AddWithValue("ZipCode", zipCode);
            command.Parameters.AddWithValue("ModelNumber", modelNo);
            command.Parameters.AddWithValue("Price", price);
            command.Parameters.AddWithValue("InStock", inStock);
        }
    }
}
