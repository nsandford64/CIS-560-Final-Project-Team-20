using System;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectData.DataDelegates
{
    public class GetComponentCategoriesDataDelegate : DataReaderDelegate<List<string>>
    {
        public GetComponentCategoriesDataDelegate() 
            : base("PartFinder.GetComponentCategoryNames")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> componentCategoryNames = new List<string>();
            while(reader.Read())
            {
                componentCategoryNames.Add(reader.GetString("ComponentCategoryName"));
            }
            return componentCategoryNames;
        }
    }
}
