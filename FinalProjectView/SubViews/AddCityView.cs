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
    public partial class AddCityView : Form
    {
        public AddCityView()
        {
            InitializeComponent();
        }

        public string CityName
        {
            get
            {
                return uxCityNameBox.Text;
            }
        }

        public string StateName
        {
            get
            {
                return uxCityStatePicker.Text;
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
            uxCityStatePicker.DataSource = states;
        }

        private void uxAddCityButton_Click(object sender, EventArgs e)
        {
            if(CityName == "")
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
