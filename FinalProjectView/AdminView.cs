using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectView.SubViews;
using ProjectData.Models;

namespace FinalProjectView
{
    public partial class AdminView : Form
    {
        private ViewController controller;

        public AdminView(ViewController c)
        {
            this.controller = c;
            InitializeComponent();
        }

        private void uxAddComponentButton_Click(object sender, EventArgs e)
        {
            using(AddComponentView view = new AddComponentView()) 
            {
                view.SetManufacturers(controller.GetManufacturerNames());
                view.SetComponentCategory(controller.GetComponentCategoryNames());
                if(view.ShowDialog() == DialogResult.OK)
                { 
                    List<string> input = new List<string>();
                    input.Add(view.ComponentName);
                    input.Add(view.ModelNumber);
                    input.Add(view.Manufacturer);
                    input.Add(view.ComponentCategory);
                    input.Add(view.MSRP);
                    controller.InsertData(input, AdminState.Component);
                }
            }
        }

        private void uxAddManufacturerButton_Click(object sender, EventArgs e)
        {
            using (AddManufacturerView view = new AddManufacturerView())
            {
                if (view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.Manufacturer);
                    controller.InsertData(input, AdminState.Manufacturer);
                    controller.UpdateManufacturerNames();
                }
            }
        }

        private void uxAddCityButton_Click(object sender, EventArgs e)
        {
            using (AddCityView view = new AddCityView())
            {
                view.SetStates(controller.GetStateNames());
                if(view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.CityName);
                    input.Add(view.StateName);
                    controller.InsertData(input, AdminState.Cities);
                    controller.UpdateCityNames();
                }
            }
        }

        private void uxAddStorefrontButton_Click(object sender, EventArgs e)
        {
            using (AddStorefrontView view = new AddStorefrontView(this))
            {
                view.SetStates(controller.GetStateNames());
                view.SetCities(controller.GetCityNames());
                if (view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.StoreName);
                    input.Add(view.StoreAddress);
                    input.Add(view.ZipCode);
                    input.Add(view.CityName);
                    input.Add(view.StateName);
                    controller.InsertData(input, AdminState.Storefront);
                }
            }
        }

        public List<string> GetPossibleCities(string state)
        {
            return controller.GetCitiesByState(state);
        }

        private void uxAddComponentStorefrontButton_Click(object sender, EventArgs e)
        {
            using (AddComponentStorefrontView view = new AddComponentStorefrontView())
            {
                if (view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.ModelNumber);
                    input.Add(view.StoreAddress);
                    input.Add(view.ZipCode);
                    input.Add(view.Price);
                    input.Add(view.InStock);
                    controller.InsertData(input, AdminState.Storefront);
                }
            }
        }

        private void uxUpdateComponentStorefrontButton_Click(object sender, EventArgs e)
        {
            using (UpdateComponentStorefrontView view = new UpdateComponentStorefrontView(this))
            {
                if (view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.StoreAddress);
                    input.Add(view.ZipCode);
                    input.Add(view.ModelNumber);
                    input.Add(view.InStock);
                    input.Add(view.Price);
                    controller.UpdateComponentStorefront(input);
                }
            }
        }

        public List<ComponentStorefrontDisplay> EditableComponentsList()
        {
            return controller.GetEditableComponents();
        }

        private void AdminGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uxClientButton_Click(object sender, EventArgs e)
        {
            controller.ChangeViewsAdmin();
        }


    }
}
