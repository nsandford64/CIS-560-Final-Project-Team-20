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
    class GetComponentsDataDelegate : DataReaderDelegate<List<ComponentDisplay>>
    {
        private readonly string componentName;

        public GetComponentsDataDelegate(string componentName)
           : base("PartFinder.GetComponents")
        {
            this.componentName = componentName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", componentName);
        }

        public override List<ComponentDisplay> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<ComponentDisplay> results = new List<ComponentDisplay>();
            /*
            while (reader.Read())
            {
                results.Add(new Component(
                   reader.GetInt32("ComponentID"),
                   reader.GetString("ComponentName"),
                   reader.GetString("ModelNumber"),
                   reader.GetInt32("ManufacturerID").ToString(),
                   (ComponentCategory)reader.GetInt32("ComponentCategoryID"),
                   reader.GetInt32("MSRP")));
            }*/
            return results;
            
        }
    }
}
