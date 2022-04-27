using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectView
{
    public partial class AdminView : Form
    {
        private ViewController c;

        List<Control> activeControls = new List<Control>();

        private AdminState state = AdminState.NotAdding;

        public AdminView(ViewController controller)
        {
            c = controller;
            InitializeComponent();
        }

        public void ChangeAdminState(AdminState s)
        {
            DisableControls();
            if(s == AdminState.Component && state != s)
            {
                uxComponentNameBox.Enabled = true;
                activeControls.Add(uxComponentNameBox);

                uxComponentNameLabel.Enabled = true;
                activeControls.Add(uxComponentNameLabel);

                uxModelNumberBox.Enabled = true;
                activeControls.Add(uxModelNumberBox);

                uxModelNumberLabel.Enabled = true;
                activeControls.Add(uxModelNumberLabel);

                uxManufacturerBox.Enabled = true;
                activeControls.Add(uxManufacturerBox);

                uxManufacturerLabel.Enabled = true;
                activeControls.Add(uxManufacturerLabel);

                uxComponentCategoryBox.Enabled = true;
                activeControls.Add(uxComponentCategoryBox);

                uxComponentCategoryLabel.Enabled = true;
                activeControls.Add(uxComponentCategoryLabel);

                uxMSRPBox.Enabled = true;
                activeControls.Add(uxMSRPBox);

                uxMSRPLabel.Enabled = true;
                activeControls.Add(uxMSRPLabel);

                state = s;
            }
            if(s == AdminState.Manufacturer && state != s)
            {
                uxManufacturerNameBox.Enabled = true;
                activeControls.Add(uxManufacturerNameBox);

                uxManufacturerNameLabel.Enabled = true;
                activeControls.Add(uxManufacturerNameLabel);

                state = s;
            }
            if(s == AdminState.Cities && state != s)
            {
                uxStateNameBox.Enabled = true;
                activeControls.Add(uxStateNameBox);

                uxStateNameLabel.Enabled = true;
                activeControls.Add(uxStateNameLabel);

                uxCityNameBox.Enabled = true;
                activeControls.Add(uxCityNameBox);

                uxCityNameLabel.Enabled = true;
                activeControls.Add(uxCityNameLabel);

                state = s;
            }
            if(s == AdminState.Storefront && s != state)
            {
                uxStoreNameBox.Enabled = true;
                activeControls.Add(uxStoreNameBox);

                uxStoreNameLabel.Enabled = true;
                activeControls.Add(uxStoreNameLabel);

                uxStoreAddressLabel.Enabled = true;
                activeControls.Add(uxStoreAddressLabel);

                uxStoreAddressBox.Enabled = true;
                activeControls.Add(uxStoreAddressBox);

                uxZipCodeBox.Enabled = true;
                activeControls.Add(uxZipCodeBox);

                uxZipCodeLabel.Enabled = true;
                activeControls.Add(uxZipCodeLabel);

                uxStoreCityBox.Enabled = true;
                activeControls.Add(uxStoreCityBox);

                uxStoreCityLabel.Enabled = true;
                activeControls.Add(uxStoreCityLabel);

                uxStoreStateNameLabel.Enabled = true;
                activeControls.Add(uxStoreStateNameLabel);

                uxStoreStateBox.Enabled = true;
                activeControls.Add(uxStoreStateBox);

                state = s;
            }
            if (s == AdminState.ComponentStorefront && state != s)
            {
                uxModelNumberComboLabel.Enabled = true;
                activeControls.Add(uxModelNumberComboLabel);

                uxModelNumberComboBox.Enabled = true;
                activeControls.Add(uxModelNumberComboBox);

                uxStoreAddressComboBox.Enabled = true;
                activeControls.Add(uxStoreAddressComboBox);

                uxStoreAddressComboLabel.Enabled = true;
                activeControls.Add(uxStoreAddressComboLabel);

                uxZipCodeComboLabel.Enabled = true;
                activeControls.Add(uxZipCodeComboLabel);

                uxZipCodeComboBox.Enabled = true;
                activeControls.Add(uxZipCodeComboBox);

                uxZipCodeComboLabel.Enabled = true;
                activeControls.Add(uxZipCodeComboLabel);

                uxPriceComboLabel.Enabled = true;
                activeControls.Add(uxPriceComboLabel);

                uxPriceComboBox.Enabled = true;
                activeControls.Add(uxPriceComboBox);

                uxInStockCheckBox.Enabled = true;
                activeControls.Add(uxInStockCheckBox);

                state = s;
            }
        }

        private void DisableControls()
        {
            foreach(Control c in activeControls)
            {
                c.Enabled = false;
            }
            activeControls.Clear();
        }

        private void uxClientButton_Click(object sender, EventArgs e)
        {
            c.ChangeViewsAdmin();
        }

        private void AdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uxAddComponentButton_Click(object sender, EventArgs e)
        {
            ChangeAdminState(AdminState.Component);
        }

        private void uxAddManufacturerButton_Click(object sender, EventArgs e)
        {
            ChangeAdminState(AdminState.Manufacturer);
        }

        private void uxAddCityButton_Click(object sender, EventArgs e)
        {
            ChangeAdminState(AdminState.Cities);
        }

        private void uxStorefrontButton_Click(object sender, EventArgs e)
        {
            ChangeAdminState(AdminState.Storefront);
        }

        private void uxSubmitButton_Click(object sender, EventArgs e)
        {
            List<string> input = new List<string>();
            if (state == AdminState.Component)
            {
                if (uxComponentNameBox.Text == "" || uxModelNumberBox.Text == "" ||
                    uxManufacturerBox.Text == "" || uxComponentCategoryBox.Text == "" ||
                    uxMSRPBox.Text == "")
                {
                    uxErrorLabel.Text = "ERROR IN COMPONENTS!";
                }
                else
                {
                    input.Add(uxComponentNameBox.Text);
                    input.Add(uxModelNumberBox.Text);
                    input.Add(uxManufacturerBox.Text);
                    input.Add(uxComponentCategoryBox.Text);
                    input.Add(uxMSRPBox.Text);
                    c.InsertData(input, AdminState.Component);
                }
            }
            if (state == AdminState.Cities)
            {
                if(uxCityNameBox.Text == "" || uxStateNameBox.Text == "")
                {
                    uxErrorLabel.Text = "ERROR IN CITIES!";
                }
                else
                {
                    input.Add(uxCityNameBox.Text);
                    input.Add(uxStateNameBox.Text);
                    c.InsertData(input, AdminState.Cities);
                } 
            }
            if (state == AdminState.Manufacturer)
            {
                if(uxManufacturerNameBox.Text == "")
                {
                    uxErrorLabel.Text = "ERROR IN MANUFACTURERS!";
                }
                else
                {
                    input.Add(uxManufacturerNameBox.Text);
                    c.InsertData(input, AdminState.Manufacturer);
                }
            }
            if (state == AdminState.Storefront)
            {
                if(uxStoreNameBox.Text == "" || uxStoreAddressBox.Text == "" ||
                    uxZipCodeBox.Text == "" || uxStoreCityBox.Text == "" || uxStoreStateBox.Text == "")
                {
                    uxErrorLabel.Text = "ERROR IN STOREFRONT!";
                }
                else
                {
                    input.Add(uxStoreNameBox.Text);
                    input.Add(uxStoreAddressBox.Text);
                    input.Add(uxZipCodeBox.Text);
                    input.Add(uxStoreCityBox.Text);
                    input.Add(uxStoreStateBox.Text);
                    c.InsertData(input, AdminState.Storefront);
                }
            }
            if (state == AdminState.ComponentStorefront)
            {
                if(uxStoreAddressComboBox.Text == "" || uxZipCodeComboBox.Text == "" ||
                    uxModelNumberComboBox.Text == "" || uxPriceComboBox.Text == "")
                {
                    uxErrorLabel.Text = "ERROR IN COMPONENT STOREFRONT!";
                }
                else
                {
                    input.Add(uxStoreAddressComboBox.Text);
                    input.Add(uxZipCodeComboBox.Text);
                    input.Add(uxModelNumberComboBox.Text);
                    input.Add(uxPriceComboBox.Text);
                    input.Add(Convert.ToString(Convert.ToInt32(uxInStockCheckBox.Checked)));
                    c.InsertData(input, AdminState.ComponentStorefront);
                }
            }
        }

        private void uxComponentStorefrontButton_Click(object sender, EventArgs e)
        {
            ChangeAdminState(AdminState.ComponentStorefront);
        }
    }
}
