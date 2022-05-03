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
        private ViewController controller;
        private List<string> ComponentCategories = new List<string>() { "" };
        private List<string> StateNameList = new List<string>() { "" };
        private bool set = false;

        public ClientView(ViewController controller)
        {
            this.controller = controller;
            StateNameList.AddRange(controller.GetStateNames());
            ComponentCategories.AddRange(controller.GetComponentCategoryNames());
            InitializeComponent();
        }

        private void uxAdminButton_Click(object sender, EventArgs e)
        {
            controller.ChangeViewsClient();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            uxResultsBox.Columns.Clear();
            uxResultsBox.Columns.Add("Component Name");
            uxResultsBox.Columns.Add("Model Number");
            uxResultsBox.Columns.Add("Manufacturer");
            uxResultsBox.Columns.Add("ComponentCategory");
            uxResultsBox.Columns.Add("Price");
            uxResultsBox.Columns.Add("In Stock");
            uxResultsBox.Columns.Add("Store");
            uxResultsBox.Columns.Add("Address");
            uxResultsBox.Columns.Add("Zip Code");
            uxResultsBox.Columns.Add("City");
            uxResultsBox.Columns.Add("State");
            uxResultsBox.Items.Clear();

            List<ComponentDisplay> results = controller.GetDataWithParameters(CollectData());
            foreach (ComponentDisplay com in results)
            {
                uxResultsBox.Items.Add(new ListViewItem(new string[] {com.ComponentName, com.ModelNumber,
                com.Manufacturer, com.Category.ToString(), "" + com.Price, "" + com.InStock,
                com.Storefront, com.Address, "" + com.ZipCode, com.City, com.State}));
            }
            uxResultsBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private List<string> CollectData()
        {
            List<string> search = new List<string>();
            search.Add(uxStatePicker.Text);
            
            search.Add(uxAddressBox.Text);

            search.Add(uxZipCodeBox.Text);
 
            search.Add(uxStorefrontBox.Text);

            search.Add(uxComponentCategoryPicker.Text);

            search.Add(uxComponentNameBox.Text);

            search.Add(uxManufacturerBox.Text);

            search.Add(uxMinPriceBox.Text);

            search.Add(uxMaxPriceBox.Text);
        
            return search;
        }

        private void uxStatePicker_VisibleChanged(object sender, EventArgs e)
        {
            if (!set)
            {
                uxStatePicker.DataSource = StateNameList;
                uxComponentCategoryPicker.DataSource = ComponentCategories;
                set = false;
            }
        }

        private void uxAggregateStockValueButton_Click(object sender, EventArgs e)
        {
            decimal input;
            if(uxAggregatePriceBox.Text == "" || !(decimal.TryParse(uxAggregatePriceBox.Text, out input)))
            {

            }
            else
            {
                var results = controller.AggregateStockData(input);
                uxResultsBox.Columns.Clear();
                uxResultsBox.Items.Clear();
                uxResultsBox.Columns.Add("Store");
                uxResultsBox.Columns.Add("Address");
                uxResultsBox.Columns.Add("ZipCode");
                uxResultsBox.Columns.Add("Total Value");
                uxResultsBox.Columns.Add("Number In Stock");
                uxResultsBox.Columns.Add("Average Price");    

                foreach(AggregateStockModel model in results)
                {
                    uxResultsBox.Items.Add(new ListViewItem(new string[] { model.StoreName, model.StoreAddress,
                    "" + model.ZipCode, "" + model.TotalValue, "" + model.NumberInStock, "" + model.AveragePrice}));
                }

                uxResultsBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void uxAggregateCompareMSRPButton_Click(object sender, EventArgs e)
        {
            var results = controller.AggregateCompareMSRPData();
            uxResultsBox.Columns.Clear();
            uxResultsBox.Items.Clear();
            uxResultsBox.Columns.Add("Component Category");
            uxResultsBox.Columns.Add("Manufacturer Count");
            uxResultsBox.Columns.Add("Component Count");
            
            foreach(AggregateMSRPModel model in results)
            {
                uxResultsBox.Items.Add(new ListViewItem(new string[] { model.ComponentCategoryName, "" + model.ManufacturerCount,
                "" + model.ComponentCount}));
            }
            uxResultsBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void uxAggregateStoreRatioButton_Click(object sender, EventArgs e)
        {
            var results = controller.AggregateStockRatioData();
            uxResultsBox.Columns.Clear();
            uxResultsBox.Items.Clear();
            uxResultsBox.Columns.Add("Store");
            uxResultsBox.Columns.Add("Address");
            uxResultsBox.Columns.Add("ZipCode");
            uxResultsBox.Columns.Add("Number In Stock");
            uxResultsBox.Columns.Add("Number Out Of Stock");
            uxResultsBox.Columns.Add("Stock Ratio");
            
            foreach(AggregateInStockRatioModel model in results)
            {
                uxResultsBox.Items.Add(new ListViewItem(new string[] { model.StoreName, model.StoreAddress,
                "" + model.ZipCode, "" + model.InStock, "" + model.OutOfStock, "" + model.StockRatio}));
            }

            uxResultsBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void uxAggregateStoreComponentsButton_Click(object sender, EventArgs e)
        {
            var results = controller.AggregateStoreComponentData();
            uxResultsBox.Columns.Clear();
            uxResultsBox.Items.Clear();
            uxResultsBox.Columns.Add("Component Category");
            uxResultsBox.Columns.Add("State");
            uxResultsBox.Columns.Add("City");
            uxResultsBox.Columns.Add("Store Count");
            uxResultsBox.Columns.Add("Component Count");
            foreach(AggregateStoreComponentsByStateModel model in results)
            {
                uxResultsBox.Items.Add(new ListViewItem(new string[] { model.ComponentCategoryName, model.StateName, model.CityName,
                "" + model.StoreCount, "" + model.ComponentCount}));
            }

            uxResultsBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
