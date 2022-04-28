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

namespace FinalProjectView
{
    public partial class AdminGroup : Form
    {
        private ViewController c;

        public AdminGroup(ViewController c)
        {
            this.c = c;
            InitializeComponent();
        }

        private void uxAddComponentButton_Click(object sender, EventArgs e)
        {
            using(AddComponentView view = new AddComponentView()) 
            {
                view.SetManufacturers(c.GetManufacturerNames());
                view.SetComponentCategory(c.GetComponentCategoryNames());
                if(view.ShowDialog() == DialogResult.OK)
                { 
                    List<string> input = new List<string>();
                    input.Add(view.ComponentName);
                    input.Add(view.ModelNumber);
                    input.Add(view.Manufacturer);
                    input.Add(view.ComponentCategory);
                    input.Add(view.MSRP);
                    c.InsertData(input, AdminState.Component);
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
                    c.InsertData(input, AdminState.Manufacturer);
                    c.UpdateManufacturerNames();
                }
            }
        }

        private void uxAddCityButton_Click(object sender, EventArgs e)
        {
            using (AddCityView view = new AddCityView())
            {
                view.SetStates(c.GetStateNames());
                if(view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.CityName);
                    input.Add(view.StateName);
                    c.InsertData(input, AdminState.Cities);
                    c.UpdateCityNames();
                }
            }
        }

        private void uxAddStorefrontButton_Click(object sender, EventArgs e)
        {
            using (AddStorefrontView view = new AddStorefrontView())
            {
                view.SetStates(c.GetStateNames());
                view.SetCities(c.GetCityNames());
                if (view.ShowDialog() == DialogResult.OK)
                {
                    List<string> input = new List<string>();
                    input.Add(view.StoreName);
                    input.Add(view.StoreAddress);
                    input.Add(view.ZipCode);
                    input.Add(view.CityName);
                    input.Add(view.StateName);
                    c.InsertData(input, AdminState.Storefront);
                }
            }
        }

        private void uxAddComponentStorefrontButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uxClientButton_Click(object sender, EventArgs e)
        {
            c.ChangeViewsAdmin();
        }
    }
}
