using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetAddressesByZipCodeDataDelegate : DataReaderDelegate<List<string>>
    {
        private readonly int zipCode;
        public GetAddressesByZipCodeDataDelegate(int zip)
            : base("PartFinder.GetAddressesByZipCode")
        {
            zipCode = zip;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("ZipCode", zipCode);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> results = new List<string>();
            while (reader.Read())
            {
                results.Add(reader.GetString("StoreAddress"));
            }
            return results;
        }
    }
}
