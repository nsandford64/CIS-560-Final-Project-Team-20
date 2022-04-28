using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    public class GetStateNamesDataDelegate : DataReaderDelegate<List<string>>
    {
        public GetStateNamesDataDelegate()
            : base("PartFinder.GetStateNames")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> stateNames = new List<string>();
            while(reader.Read())
            {
                stateNames.Add(reader.GetString("StateName"));
            }
            return stateNames;
        }
    }
}
