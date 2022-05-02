using ProjectData.Models;
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
    public partial class UpdateComponentStorefrontView : Form
    {
        private AdminView adminView;
        private List<ComponentStorefrontDisplay> componentList;

        public UpdateComponentStorefrontView(AdminView av)
        {
            adminView = av;
            InitializeComponent();
            uxComponentList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            PopulateComponentBox();
        }

        public string ModelNumber
        {
            get
            {
                return componentList[uxComponentList.SelectedIndices[0]].ModelNumber;
            }
        }

        public string StoreAddress
        {
            get
            {
                return componentList[uxComponentList.SelectedIndices[0]].StoreAddress;
            }
        }

        public string ZipCode
        {
            get
            {
                return componentList[uxComponentList.SelectedIndices[0]].ZipCode.ToString();
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

        private void PopulateComponentBox()
        {
            componentList = adminView.EditableComponentsList();
            foreach(ComponentStorefrontDisplay display in componentList)
            {
                uxComponentList.Items.Add(new ListViewItem(new string[] { display.ComponentName, display.ModelNumber,
                display.Price.ToString(), display.InStock.ToString(), display.StoreAddress, display.ZipCode.ToString()}));
            }
        }

        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            if (uxComponentList.SelectedIndices.Count == 0)
            {
                DisplayLabel = "ERROR: Please select a component";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
