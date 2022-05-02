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
    public partial class AddComponentStorefrontView : Form
    {
        private AdminView adminView;
        public AddComponentStorefrontView(AdminView av)
        {
            adminView = av;
            InitializeComponent();
            uxModelNumberPicker.DataSource = av.GetModelNumbers();
            uxZipCodePicker.DataSource = av.GetZipCodes();
        }

        public string ModelNumber
        {
            get
            {
                return uxModelNumberPicker.Text;
            }
        }

        public string StoreAddress
        {
            get
            {
                return uxStoreAddressPicker.Text;
            }
        }

        public string ZipCode
        {
            get
            {
                return uxZipCodePicker.Text;
            }
        }

        public string Price
        {
            get
            {
                return uxPriceComboBox.Text;
            }
        }

        public string InStock
        {
            get
            {
                if (uxInStockCheckBox.Checked)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
        }

        public string DisplayLabel
        {
            set
            {
                uxDisplayLabel.Text = value;
            }
        }

        private void uxComponentStorefrontButton_Click(object sender, EventArgs e)
        {
            if (StoreAddress == "" || ZipCode == "" || ModelNumber == "" || Price == "")
            {
                DisplayLabel = "ERROR: Please ensure all fields are populated";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void uxZipCodePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxStoreAddressPicker.DataSource = adminView.GetAddressesByZipCode(Convert.ToInt32(uxZipCodePicker.Text));
        }
    }
}
