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
    public class SqlManufacturerRepository : IManufacturerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlManufacturerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Manufacturer InsertManufacturer(List<string> data)
        {
            var d = new InsertManufacturerDataDelegate(data[0]);
            return executor.ExecuteNonQuery(d);
        }
    }
}
