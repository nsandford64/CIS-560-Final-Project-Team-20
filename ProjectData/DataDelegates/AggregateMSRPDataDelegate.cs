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
    public class AggregateMSRPDataDelegate : DataReaderDelegate<List<AggregateMSRPModel>>
    {
        public AggregateMSRPDataDelegate()
            : base("PartFinder.AggregateCompareMSRP")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<AggregateMSRPModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<AggregateMSRPModel> results = new List<AggregateMSRPModel>();
            while (reader.Read())
            {
                results.Add(new AggregateMSRPModel(reader.GetString("ComponentCategoryName"), reader.GetInt32("ComponentCount"),
                    reader.GetInt32("ManufacturerCount")));
            }
            return results;
        }
    }
}
