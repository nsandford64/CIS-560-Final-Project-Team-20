﻿using DataAccess;
using ProjectData.DataDelegates;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public class SqlAdminRepository
    {
        private readonly SqlCommandExecutor executor;
        
        public SqlAdminRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<string> GetManufacturerNames()
        {
            var d = new GetManufacturerNamesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<string> GetStateNames()
        {
            var d = new GetStateNamesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<string> GetModelNumbers()
        {
            var d = new GetModelNumbersDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<string> GetAddressesByZipCode(int zip)
        {
            var d = new GetAddressesByZipCodeDataDelegate(zip);
            return executor.ExecuteReader(d);
        }

        public List<string> GetCityNames()
        {
            var d = new GetCityNamesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<string> GetCityNamesByState(string state)
        {
            var d = new GetCitiesByStateDataDelegate(state);
            return executor.ExecuteReader(d);
        }

        public List<string> GetComponentCategories()
        {
            var d = new GetComponentCategoriesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public void InsertComponent(List<string> data)
        {
            var d = new InsertComponentDataDelegate(data[0], data[1], data[2], data[3], Convert.ToDecimal(data[4]));
            executor.ExecuteNonQuery(d);
        }

        public List<string> GetZipCodes()
        {
            var d = new GetZipCodesDataDelegate();
            return executor.ExecuteReader(d);
        }

        public void InsertComponentStorefront(List<string> data)
        {
            var d = new InsertComponentStorefrontDataDelegate(data[0], data[1], data[2], Convert.ToDecimal(data[3]), Convert.ToInt32(data[4]));
            executor.ExecuteNonQuery(d);
        }

        public void InsertManufacturer(List<string> data)
        {
            var d = new InsertManufacturerDataDelegate(data[0]);
            executor.ExecuteNonQuery(d);
        }

        public void InsertStorefront(List<string> data)
        {
            var d = new InsertStorefrontDataDelegate(data[0], data[1], data[2], data[3], data[4]);
            executor.ExecuteNonQuery(d);
        }

        public void InsertCity(List<string> data)
        {
            var d = new InsertCityDataDelegate(data[0], data[1]);
            executor.ExecuteNonQuery(d);
        }

        public void UpdateComponentStorefront(List<string> data)
        {
            var d = new UpdateComponentStorefrontDataDelegate(data[0], Convert.ToInt32(data[1]), data[2], 
                Convert.ToInt32(data[3]), Convert.ToDecimal(data[4]));
            executor.ExecuteNonQuery(d);
        }

        public List<ComponentStorefrontDisplay> GetEditableComponents()
        {
            var d = new GetEditableComponentsDataDelegate();
            return executor.ExecuteReader(d);
        }
    }
}
