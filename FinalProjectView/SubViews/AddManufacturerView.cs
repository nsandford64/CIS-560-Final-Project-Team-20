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
    public partial class AddManufacturerView : Form
    {
        public AddManufacturerView()
        {
            InitializeComponent();
        }

        public string Manufacturer
        {
            get
            {
                return uxManufacturerNameBox.Text;
            }
        }
        public string DisplayLabel
        {
            set
            {
                uxDisplayLabel.Text = value;
            }
        }

        private void uxAddManufacturerButton_Click(object sender, EventArgs e)
        {
            if (Manufacturer == "")
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
