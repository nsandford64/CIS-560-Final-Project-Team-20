using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectView.SubViews
{
    public partial class AddStorefrontView : Form
    {
        private AdminView adminView;
        public AddStorefrontView(AdminView av)
        {
            this.adminView = av;
            InitializeComponent();
        }

        public string StoreName
        {
            get
            {
                return uxStoreNameBox.Text;
            }
        }

        public string StoreAddress
        {
            get
            {
                return uxStoreAddressBox.Text;
            }
        }

        public string ZipCode
        {
            get
            {
                return uxZipCodeBox.Text;
            }
        }

        public string CityName
        {
            get
            {
                return uxStoreCityNamePicker.Text;
            }
        }

        public void SetCities(List<string> cities)
        {
            uxStoreCityNamePicker.DataSource = cities;
        }

        public string StateName
        {
            get
            {
                return uxStoreStatePicker.Text;
            }
        }

        public string DisplayLabel
        {
            set
            {
                uxDisplayLabel.Text = value;
            }
        }

        public void SetStates(List<string> states)
        {
            uxStoreStatePicker.DataSource = states;
        }

        private void uxStorefrontButton_Click(object sender, EventArgs e)
        {
            if (StoreName == "" || StoreAddress == "" || ZipCode == "")
            {
                DisplayLabel = "ERROR: Please ensure all fields are populated";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void uxStoreStatePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxStoreCityNamePicker.DataSource = adminView.GetPossibleCities(uxStoreStatePicker.Text);
        }
    }
}
