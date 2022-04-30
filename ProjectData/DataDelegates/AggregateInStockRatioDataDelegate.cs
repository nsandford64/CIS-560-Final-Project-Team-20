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
    public class AggregateInStockRatioDataDelegate : DataReaderDelegate<List<AggregateInStockRatioModel>>
    {
        public AggregateInStockRatioDataDelegate()
            : base("PartFinder.AggregateInStockRatio")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<AggregateInStockRatioModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<AggregateInStockRatioModel> results = new List<AggregateInStockRatioModel>();
            while (reader.Read())
            {
                results.Add(new AggregateInStockRatioModel(reader.GetString("StoreName"), reader.GetString("StoreAddress"),
                    reader.GetInt32("InStock"), reader.GetInt32("StockRatio")));
            }
            return results;
        }
    }
}
