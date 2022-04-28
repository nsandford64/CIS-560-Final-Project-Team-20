using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetCityNamesDataDelegate : DataReaderDelegate<List<string>>
    {
        public GetCityNamesDataDelegate()
            : base("PartFinder.GetCityNames")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> cityNames = new List<string>();
            while(reader.Read())
            {
                cityNames.Add(reader.GetString("CityName"));
            }
            return cityNames;
        }
    }
}
