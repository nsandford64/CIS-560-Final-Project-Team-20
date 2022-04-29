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

        SqlClientRepository componentRepo = new SqlClientRepository(connectionString);
        SqlAdminRepository adminRepo = new SqlAdminRepository(connectionString);
        
        private ClientView c;
        private AdminGroup a;

        private List<string> manufacturerNames;
        private List<string> storeNames;
        private List<string> stateNames;
        private List<string> cityNames;
        private List<string> componentCategoryNames;

        public ViewController()
        {
            stateNames = adminRepo.GetStateNames();
            manufacturerNames = adminRepo.GetManufacturerNames();
            //storeNames = adminRepo.GetStoreNames();
            cityNames = adminRepo.GetCityNames();
            componentCategoryNames = adminRepo.GetComponentCategories();
        }

        public void SetViews(ClientView client, AdminGroup admin)
        {
            a = admin;
            c = client;
        }

        public void ChangeViewsClient()
        {
            c.Hide();
            a.Show();
        }

        public void ChangeViewsAdmin()
        {
            a.Hide();
            c.Show();
        }

        public List<Component> GetDataWithParameters(List<string> parameters)
        {
            return componentRepo.GetComponents(parameters);
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

        public List<>

        public List<Component> GetData(string name)
        {
            return componentRepo.GetComponentsByName(name);
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
