using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    public class GetManufacturerNamesDataDelegate : DataReaderDelegate<List<string>>
    {
        public GetManufacturerNamesDataDelegate()
            : base("PartFinder.GetManufacturerNames")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> manufacturerNames = new List<string>();
            while (reader.Read())
            {
                manufacturerNames.Add(reader.GetString("ManufacturerName"));
            }
            return manufacturerNames;
        }
    }
}
