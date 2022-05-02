using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectData.Models;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetEditableComponentsDataDelegate : DataReaderDelegate<List<ComponentStorefrontDisplay>>
    {
        public GetEditableComponentsDataDelegate()
            : base("PartFinder.GetEditableComponents")
        {

        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<ComponentStorefrontDisplay> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<ComponentStorefrontDisplay> results = new List<ComponentStorefrontDisplay>();
            while (reader.Read())
            {
                results.Add(new ComponentStorefrontDisplay(reader.GetString("ComponentName"), reader.GetString("StoreAddress"),
                    reader.GetInt32("ZipCode"), reader.GetString("ModelNumber"), reader.GetValue<decimal>("Price"),
                    reader.GetValue<bool>("InStock")));
            }
            return results;
        }
    }
}
