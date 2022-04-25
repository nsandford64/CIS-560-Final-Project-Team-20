using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectView
{
    public partial class ClientView : Form
    {
        private ViewController c;
        private string[] ComponentCategories = new string[] { "---", "CPU", "Motherboard", "GPU", "RAM", "Power Supply", "Case", "Storage", "PC Cooling" };
        private string[] StateAbbrevList = new string[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL",
                                                          "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT",
                                                          "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI",
                                                          "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
        private bool set = false;

        public ClientView(ViewController controller)
        {
            c = controller;
            InitializeComponent();
        }

        private void uxAdminButton_Click(object sender, EventArgs e)
        {
            c.ChangeViewsClient();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            uxResultsBox.Columns.Add("ComponentID");
            uxResultsBox.Columns.Add("Component Name");
            uxResultsBox.Columns.Add("Model Number");
            uxResultsBox.Columns.Add("ManufacturerID");
            uxResultsBox.Columns.Add("ComponentCategoryID");
            uxResultsBox.Columns.Add("MSRP");
            uxResultsBox.Items.Clear();
            foreach(Component com in c.GetData(uxComponentNameBox.Text))
            {
                uxResultsBox.Items.Add(new ListViewItem(new string[] {"" + com.ComponentID, com.ComponentName,
                    com.ModelNumber, "" + com.Manufacturer, "" + com.ComponentCategory, "" + com.MSRP }));
            }

        }

        private void uxStatePicker_VisibleChanged(object sender, EventArgs e)
        {
            if (!set)
            {
                uxStatePicker.DataSource = StateAbbrevList;
                uxComponentCategoryPicker.DataSource = ComponentCategories;
                set = false;
            }
        }

        private void uxStorefrontBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxComponentPropertyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxComponentPropertyCheckBox.Checked)
            {
                uxComponentCategoryLabel.Enabled = true;
                uxComponentCategoryPicker.Enabled = true;

                uxComponentNameBox.Enabled = true;
                uxComponentNameLabel.Enabled = true;

                uxManufacturerBox.Enabled = true;
                uxManufacturerLabel.Enabled = true;
            }
            if (!uxComponentPropertyCheckBox.Checked)
            {
                uxComponentCategoryLabel.Enabled = false;
                uxComponentCategoryPicker.Enabled = false;

                uxComponentNameBox.Enabled = false;
                uxComponentNameLabel.Enabled = false;

                uxManufacturerBox.Enabled = false;
                uxManufacturerLabel.Enabled = false;
            }
        }

        private void uxLocationPropertyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxLocationPropertyCheckBox.Checked)
            {
                uxStatePicker.Enabled = true;
                uxStateLabel.Enabled = true;

                uxAddressBox.Enabled = true;
                uxAddressLabel.Enabled = true;

                uxZipCodeBox.Enabled = true;
                uxZipCodeLabel.Enabled = true;

                uxStorefrontBox.Enabled = true;
                uxStorefrontLabel.Enabled = true;
            }
            if (!uxLocationPropertyCheckBox.Checked)
            {
                uxStatePicker.Enabled = false;
                uxStateLabel.Enabled = false;

                uxAddressBox.Enabled = false;
                uxAddressLabel.Enabled = false;

                uxZipCodeBox.Enabled = false;
                uxZipCodeLabel.Enabled = false;

                uxStorefrontBox.Enabled = false;
                uxStorefrontLabel.Enabled = false;
            }
        }
    }
}
