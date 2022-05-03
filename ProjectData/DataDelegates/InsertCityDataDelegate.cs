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
    public class InsertCityDataDelegate : DataDelegate
    {
        private readonly string cityName;
        private readonly string stateName;

        public InsertCityDataDelegate(string city, string state)
            : base("PartFinder.InsertCity")
        {
            cityName = city;
            stateName = state;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            
            command.Parameters.AddWithValue("CityName", cityName);
            command.Parameters.AddWithValue("StateName", stateName);
        }
    }
}
