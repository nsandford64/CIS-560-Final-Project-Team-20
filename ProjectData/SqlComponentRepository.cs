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
    public class SqlComponentRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlComponentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<Component> GetComponentsByName(string componentName)
        {
            var d = new GetComponentsDataDelegate(componentName);
            return executor.ExecuteReader(d);
        }

        public List<Component> GetComponentsByModelNo(string modelNo)
        {
            var d = new GetComponentsDataDelegate(modelNo);
            return executor.ExecuteReader(d);
        }
        public List<Component> GetComponentsByModelNoAndName(string modelNo, string componentName)
        {
            var d = new GetComponentsDataDelegate(modelNo);
            return executor.ExecuteReader(d);
        }
    }
}
