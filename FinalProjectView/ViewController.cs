﻿using ProjectData;
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

        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=nsandford64;Integrated Security=SSPI;";

        SqlComponentRepository repo = new SqlComponentRepository(connectionString);
        
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
            return repo.GetComponentsByName(name);
        }

        public void InsertData(List<string> data, AdminState state)
        {
            if(state == AdminState.Component)
            {
                repo.InsertComponent(data[0], data[1], data[2], data[3], Convert.ToInt32(data[4]));
            }
        }

    }
}
