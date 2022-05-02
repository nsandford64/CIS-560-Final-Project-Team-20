using ProjectData;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectView
{
    public class ViewController
    {

        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=partfinder;Integrated Security=SSPI;";

        private SqlClientRepository clientRepo = new SqlClientRepository(connectionString);
        private SqlAdminRepository adminRepo = new SqlAdminRepository(connectionString);
        
        private ClientView client;
        private AdminView admin;

        private List<string> manufacturerNames;
        private List<string> stateNames;
        private List<string> cityNames;
        private List<string> componentCategoryNames;

        public ViewController()
        {
            stateNames = adminRepo.GetStateNames();
            manufacturerNames = adminRepo.GetManufacturerNames();
            cityNames = adminRepo.GetCityNames();
            componentCategoryNames = adminRepo.GetComponentCategories();
        }

        public void SetViews(ClientView client, AdminView admin)
        {
            this.admin = admin;
            this.client = client;
        }

        public void ChangeViewsClient()
        {
            client.Hide();
            admin.Show();
        }

        public void ChangeViewsAdmin()
        {
            admin.Hide();
            client.Show();
        }

        public List<ComponentDisplay> GetDataWithParameters(List<string> parameters)
        {
            return clientRepo.GetComponents(parameters);
        }

        public List<string> GetManufacturerNames()
        {
            return manufacturerNames;
        }

        public List<string> GetComponentCategoryNames()
        {
            return componentCategoryNames;
        }

        public List<string> GetStateNames()
        {
            return stateNames;
        }

        public List<string> GetCityNames()
        {
            return cityNames;
        }

        public List<string> GetCitiesByState(string state)
        {
            return adminRepo.GetCityNamesByState(state);
        }

        public void UpdateManufacturerNames()
        {
            manufacturerNames = adminRepo.GetManufacturerNames();
        }

        public void UpdateCityNames()
        {
            cityNames = adminRepo.GetCityNames();
        }

        public List<AggregateStockModel> AggregateStockData(decimal value)
        {
            return clientRepo.AggregateStockValues(value);
        }

        public List<AggregateMSRPModel> AggregateCompareMSRPData()
        {
            return clientRepo.AggregateCompareMSRP();
        }

        public List<AggregateInStockRatioModel> AggregateStockRatioData()
        {
            return clientRepo.AggregateInStockRatio();
        }

        public List<AggregateStoreComponentsByStateModel> AggregateStoreComponentData()
        {
            return clientRepo.AggregateStoreComponents();
        }

        public void UpdateComponentStorefront(List<string> data)
        {
            adminRepo.UpdateComponentStorefront(data);
        }

        public List<ComponentStorefrontDisplay> GetEditableComponents()
        {
            return adminRepo.GetEditableComponents();
        }

        public void InsertData(List<string> data, AdminState state)
        {
            if (state == AdminState.Component)
            {
                adminRepo.InsertComponent(data);
            }
            if (state == AdminState.Manufacturer)
            {
                adminRepo.InsertManufacturer(data);
            }
            if (state == AdminState.Storefront)
            {
                adminRepo.InsertStorefront(data);
            }
            if (state == AdminState.ComponentStorefront)
            {
                adminRepo.InsertComponentStorefront(data);
            }
            if (state == AdminState.Cities)
            {
                adminRepo.InsertCity(data);
            }
        }

    }
}
