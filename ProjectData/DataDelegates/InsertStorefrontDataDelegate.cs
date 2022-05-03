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
    public class InsertStorefrontDataDelegate : DataDelegate
    {
        private readonly string name;
        private readonly string address;
        private readonly string zipCode;
        private readonly string cityName;
        private readonly string stateName;

        public InsertStorefrontDataDelegate(string name, string address, string zipCode, string cityName, string stateName)
            : base("PartFinder.InsertStorefront")
        {
            this.name = name;
            this.address = address;
            this.zipCode = zipCode;
            this.cityName = cityName;
            this.stateName = stateName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Address", address);
            command.Parameters.AddWithValue("ZipCode", zipCode);
            command.Parameters.AddWithValue("CityName", cityName);
            command.Parameters.AddWithValue("StateName", stateName);
        }
    }
}
