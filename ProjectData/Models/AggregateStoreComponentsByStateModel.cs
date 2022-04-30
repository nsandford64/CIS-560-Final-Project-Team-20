using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class AggregateStoreComponentsByStateModel
    {
        public string ComponentCategoryName;

        public string StateName;

        public string CityName;

        public int StoreCount;

        public int ComponentCount;

        public AggregateStoreComponentsByStateModel(string category, string state, string city, int store, int component)
        {
            ComponentCategoryName = category;
            StateName = state;
            CityName = city;
            StoreCount = store;
            ComponentCount = component;
        }
    }
}
