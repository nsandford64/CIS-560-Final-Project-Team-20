using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class UpdateComponentStorefrontDataDelegate : DataDelegate
    {
        private readonly string address;
        private readonly int zipcode;
        private readonly string model;
        private readonly int stock;
        private readonly decimal price;

        public UpdateComponentStorefrontDataDelegate(string address, int zipcode, string model, int stock, decimal price)
            : base("PartFinder.UpdateComponentStorefront")
        {
            this.address = address;
            this.zipcode = zipcode;
            this.model = model;
            this.stock = stock;
            this.price = price;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StoreAddress", address);
            command.Parameters.AddWithValue("ZipCode", zipcode);
            command.Parameters.AddWithValue("ModelNumber", model);
            command.Parameters.AddWithValue("Price", price);
            command.Parameters.AddWithValue("InStock", stock);
        }
    }
}
