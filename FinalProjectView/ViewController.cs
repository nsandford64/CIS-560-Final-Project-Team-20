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

        SqlComponentRepository componentRepo = new SqlComponentRepository(connectionString);
        SqlManufacturerRepository manufacturerRepo = new SqlManufacturerRepository(connectionString);
        
        private ClientView c;
        private AdminView a;

        public ViewController()
        {

        }

        public void SetViews(ClientView client, AdminView admin)
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

        public List<Component> GetData(string name)
        {
            return componentRepo.GetComponentsByName(name);
        }

        public void InsertData(List<string> data, AdminState state)
        {
            if (state == AdminState.Component)
            {
                componentRepo.InsertComponent(data);
            }
            if (state == AdminState.Manufacturer)
            {
                manufacturerRepo.InsertManufacturer(data);
            }
        }

    }
}
