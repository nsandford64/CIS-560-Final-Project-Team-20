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
    class GetComponentsDataDelegate : DataReaderDelegate<List<Component>>
    {
        private readonly string componentName;

        public GetComponentsDataDelegate(string componentName)
           : base("Component.GetComponents")
        {
            this.componentName = componentName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ComponentName", componentName);
        }

        public override List<Component> Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            List<Component> results = new List<Component>();
            while (reader.Read())
            {
                results.Add(new Component(
                   reader.GetInt32("ComponentID"),
                   componentName,
                   reader.GetString("ModelNumber"),
                   reader.GetInt32("ManufacturerID"),
                   (ComponentCategory)reader.GetInt32("ComponentCategoryID"),
                   reader.GetInt32("MSRP")));
            }
            return results;
        }
    }
}
