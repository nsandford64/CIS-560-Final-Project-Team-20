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
    public class GetDataDataDelegate : DataReaderDelegate<List<ComponentDisplay>>
    {
        private readonly List<string> parameters;

        public GetDataDataDelegate(List<string> parameters)
           : base("PartFinder.GetData")
        {
            this.parameters = parameters;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if(parameters[0] == "")
            {
                command.Parameters.AddWithValue("STATE", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("STATE", parameters[0]);
            }

            if (parameters[1] == "")
            {
                command.Parameters.AddWithValue("ADDRESS", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("ADDRESS", parameters[1]);
            }

            if (parameters[2] == "")
            {
                command.Parameters.AddWithValue("ZIPCODE", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("ZIPCODE", Convert.ToInt32(parameters[2]));
            }

            if (parameters[3] == "")
            {
                command.Parameters.AddWithValue("STOREFRONT", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("STOREFRONT", parameters[3]);
            }

            if (parameters[4] == "")
            {
                command.Parameters.AddWithValue("COMPONENT_CATEGORY", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("COMPONENT_CATEGORY", parameters[4]);
            }

            if (parameters[5] == "")
            {
                command.Parameters.AddWithValue("COMPONENT_NAME", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("COMPONENT_NAME", parameters[5]);
            }

            if (parameters[6] == "")
            {
                command.Parameters.AddWithValue("COMPONENT_MANUFACTURER", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("COMPONENT_MANUFACTURER", parameters[6]);
            }

            if (parameters[7] == "")
            {
                command.Parameters.AddWithValue("MIN_PRICE", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("MIN_PRICE", Convert.ToDecimal(parameters[7]));
            }

            if (parameters[8] == "")
            {
                command.Parameters.AddWithValue("MAX_PRICE", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("MAX_PRICE", Convert.ToDecimal(parameters[8]));
            }
        }

        public override List<ComponentDisplay> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<ComponentDisplay> results = new List<ComponentDisplay>();
            while (reader.Read())
            {
                results.Add(new ComponentDisplay(
                   reader.GetString("ComponentName"),
                   reader.GetString("ModelNumber"),
                   reader.GetString("ManufacturerName"),
                   (ComponentCategory)reader.GetInt32("ComponentCategoryID"),
                   reader.GetValue<decimal>("Price"),
                   reader.GetValue<bool>("InStock"),
                   reader.GetString("StoreName"),
                   reader.GetString("StoreAddress"),
                   reader.GetInt32("ZipCode"),
                   reader.GetString("Cityname"),
                   reader.GetString("StateName")
                   ));
            }
            return results;
        }
    }
}
