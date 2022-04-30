using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectData.Models;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class AggregateStockDataDelegate : DataReaderDelegate<List<AggregateStockModel>>
    {
        private readonly decimal value;

        public AggregateStockDataDelegate(decimal value)
            : base("PartFinder.AggregateStockValues")
        {
            this.value = value;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Value", value);
        }

        public override List<AggregateStockModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<AggregateStockModel> results = new List<AggregateStockModel>();

            while (reader.Read())
            {
                results.Add(new AggregateStockModel(reader.GetString("StoreName"), reader.GetString("StoreAddress"),
                    reader.GetInt32("ZipCode"), reader.GetValue<decimal>("TotalValue"), reader.GetInt32("NumberInStock"),
                    reader.GetValue<decimal>("AveragePrice")));
            }
            return results;
        }
    }
}
