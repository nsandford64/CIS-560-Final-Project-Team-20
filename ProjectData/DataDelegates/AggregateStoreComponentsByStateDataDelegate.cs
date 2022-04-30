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
    public class AggregateStoreComponentsByStateDataDelegate : DataReaderDelegate<List<AggregateStoreComponentsByStateModel>>
    {
        public AggregateStoreComponentsByStateDataDelegate()
            : base("PartFinder.AggregateStoreComponentsByState")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<AggregateStoreComponentsByStateModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<AggregateStoreComponentsByStateModel> results = new List<AggregateStoreComponentsByStateModel>();
            while (reader.Read())
            {
                results.Add(new AggregateStoreComponentsByStateModel(reader.GetString("ComponentCategoryName"),
                    reader.GetString("StateName"), reader.GetString("CityName"), reader.GetInt32("StoreCount"), 
                    reader.GetInt32("ComponentCount")));
            }
            return results;
        }
    }
}
