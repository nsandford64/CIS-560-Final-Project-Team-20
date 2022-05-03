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
    public class InsertManufacturerDataDelegate : DataDelegate
    {
        private readonly string name;

        public InsertManufacturerDataDelegate(string name)
            : base("PartFinder.InsertManufacturer")
        {
            this.name = name;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }
    }
}
