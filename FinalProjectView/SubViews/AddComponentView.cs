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
    public partial class AddComponentView : Form
    {
        public AddComponentView()
        {
            InitializeComponent();
        }

        public string ComponentName
        {
            get
            {
                return uxComponentNameBox.Text;
            }
        }

        public string ModelNumber
        {
            get
            {
                return uxModelNumberBox.Text;
            }
        }

        public string Manufacturer
        {
            get
            {
                return uxManufacturerPicker.Text;
            }
        }

        public void SetManufacturers(List<string> manufacturers)
        {
            uxManufacturerPicker.DataSource = manufacturers;
        }

        public string ComponentCategory
        {
            get
            {
                return uxComponentCategoryPicker.Text;
            }
        }

        public void SetComponentCategory(List<string> categories)
        {
            uxComponentCategoryPicker.DataSource = categories;
        }

        public string MSRP
        {
            get
            {
                return uxMSRPBox.Text;
            }
        }

        public string DisplayLabel
        {
            set
            {
                uxDisplayLabel.Text = value;
            }
        }

        private void uxAddComponentButton_Click(object sender, EventArgs e)
        {
            if(ComponentName == "" || ModelNumber == "" || 
                MSRP == "")
            {
                DisplayLabel = "ERROR: Please ensure all fields are populated";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
