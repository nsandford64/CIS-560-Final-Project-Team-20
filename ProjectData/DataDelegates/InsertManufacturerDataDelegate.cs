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
    public class InsertManufacturerDataDelegate : NonQueryDataDelegate<Manufacturer>
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
            var p = command.Parameters.Add("ManufacturerID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }


        public override Manufacturer Translate(SqlCommand command)
        {
            return new Manufacturer((int)command.Parameters["ManufacturerID"].Value, name);
        }
    }
}
