using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetModelNumbersDataDelegate : DataReaderDelegate<List<string>>
    {
        public GetModelNumbersDataDelegate()
            : base("PartFinder.GetModelNumbers")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> results = new List<string>();
            while (reader.Read())
            {
                results.Add(reader.GetString("ModelNumber"));
            }
            return results;
        }
    }
}
