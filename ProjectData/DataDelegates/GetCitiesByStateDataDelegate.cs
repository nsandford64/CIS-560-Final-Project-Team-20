using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetCitiesByStateDataDelegate : DataReaderDelegate<List<string>>
    {
        private readonly string state;
        public GetCitiesByStateDataDelegate(string state)
            : base("PartFinder.GetCitiesByState")
        {
            this.state = state;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StateName", state);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> results = new List<string>();
            while (reader.Read())
            {
                results.Add(reader.GetString("CityName"));
            }
            return results;
        }
    }
}
