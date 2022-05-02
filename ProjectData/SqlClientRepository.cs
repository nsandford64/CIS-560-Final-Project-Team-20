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
    public class SqlClientRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlClientRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<ComponentDisplay> GetComponents(List<string> parameters)
        {
            var d = new GetDataDataDelegate(parameters);
            return executor.ExecuteReader(d);
        }

        public List<AggregateStockModel> AggregateStockValues(decimal value)
        {
            var d = new AggregateStockDataDelegate(value);
            return executor.ExecuteReader(d);
        }

        public List<AggregateMSRPModel> AggregateCompareMSRP()
        {
            var d = new AggregateMSRPDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<AggregateStoreComponentsByStateModel> AggregateStoreComponents()
        {
            var d = new AggregateStoreComponentsByStateDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<AggregateInStockRatioModel> AggregateInStockRatio()
        {
            var d = new AggregateInStockRatioDataDelegate();
            return executor.ExecuteReader(d);
        }
    }
}
