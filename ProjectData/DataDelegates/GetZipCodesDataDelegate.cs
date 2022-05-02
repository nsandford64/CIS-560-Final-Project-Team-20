using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetZipCodesDataDelegate : DataReaderDelegate<List<string>>
    {
        public GetZipCodesDataDelegate()
            : base("PartFinder.GetZipCodes")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> results = new List<string>();
            while(reader.Read())
            {
                results.Add(reader.GetInt32("ZipCode").ToString());
            }
            return results;
        }
    }
}
