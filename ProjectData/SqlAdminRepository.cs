using DataAccess;
using ProjectData.DataDelegates;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public class SqlAdminRepository : IAdminRepository
    {
        private readonly SqlCommandExecutor executor;
        
        public SqlAdminRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Component InsertComponent(List<string> data)
        {
            var d = new InsertComponentDataDelegate(data[0], data[1], data[2], data[3], Convert.ToDecimal(data[4]));
            return executor.ExecuteNonQuery(d);
        }

        public Manufacturer InsertManufacturer(List<string> data)
        {
            var d = new InsertManufacturerDataDelegate(data[0]);
            return executor.ExecuteNonQuery(d);
        }

        public Storefront InsertStorefront(List<string> data)
        {
            var d = new InsertStorefrontDataDelegate(data[0], data[1], data[2], data[3], data[4]);
            return executor.ExecuteNonQuery(d);
        }
    }
}
