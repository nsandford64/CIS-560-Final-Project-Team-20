
namespace FinalProjectView
{
    partial class ClientView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxAdminButton = new System.Windows.Forms.Button();
            this.uxStatePicker = new System.Windows.Forms.ComboBox();
            this.uxStateLabel = new System.Windows.Forms.Label();
            this.uxAddressBox = new System.Windows.Forms.TextBox();
            this.uxAddressLabel = new System.Windows.Forms.Label();
            this.uxStorefrontBox = new System.Windows.Forms.TextBox();
            this.uxStorefrontLabel = new System.Windows.Forms.Label();
            this.uxComponentCategoryPicker = new System.Windows.Forms.ComboBox();
            this.uxComponentNameBox = new System.Windows.Forms.TextBox();
            this.uxComponentCategoryLabel = new System.Windows.Forms.Label();
            this.uxComponentNameLabel = new System.Windows.Forms.Label();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxResultsBox = new System.Windows.Forms.ListView();
            this.uxManufacturerLabel = new System.Windows.Forms.Label();
            this.uxManufacturerBox = new System.Windows.Forms.TextBox();
            this.uxZipCodeLabel = new System.Windows.Forms.Label();
            this.uxZipCodeBox = new System.Windows.Forms.TextBox();
            this.uxMinPriceLabel = new System.Windows.Forms.Label();
            this.uxMaxPriceLabel = new System.Windows.Forms.Label();
            this.uxMinPriceBox = new System.Windows.Forms.TextBox();
            this.uxMaxPriceBox = new System.Windows.Forms.TextBox();
            this.uxAggregateStockValueButton = new System.Windows.Forms.Button();
            this.uxAggregatePriceBox = new System.Windows.Forms.TextBox();
            this.uxAggregateCompareMSRPButton = new System.Windows.Forms.Button();
            this.uxAggregateStoreRatioButton = new System.Windows.Forms.Button();
            this.uxAggregateStoreComponentsButton = new System.Windows.Forms.Button();
            this.uxAggregateMinLabel = new System.Windows.Forms.Label();
            this.uxLocationFiltersLabel = new System.Windows.Forms.Label();
            this.uxComponentFiltersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAdminButton
            // 
            this.uxAdminButton.Location = new System.Drawing.Point(1658, 13);
            this.uxAdminButton.Name = "uxAdminButton";
            this.uxAdminButton.Size = new System.Drawing.Size(112, 51);
            this.uxAdminButton.TabIndex = 0;
            this.uxAdminButton.Text = "Switch to Admin View";
            this.uxAdminButton.UseVisualStyleBackColor = true;
            this.uxAdminButton.Click += new System.EventHandler(this.uxAdminButton_Click);
            // 
            // uxStatePicker
            // 
            this.uxStatePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxStatePicker.FormattingEnabled = true;
            this.uxStatePicker.Location = new System.Drawing.Point(128, 53);
            this.uxStatePicker.Name = "uxStatePicker";
            this.uxStatePicker.Size = new System.Drawing.Size(82, 24);
            this.uxStatePicker.TabIndex = 1;
            this.uxStatePicker.VisibleChanged += new System.EventHandler(this.uxStatePicker_VisibleChanged);
            // 
            // uxStateLabel
            // 
            this.uxStateLabel.AutoSize = true;
            this.uxStateLabel.Location = new System.Drawing.Point(78, 56);
            this.uxStateLabel.Name = "uxStateLabel";
            this.uxStateLabel.Size = new System.Drawing.Size(45, 17);
            this.uxStateLabel.TabIndex = 2;
            this.uxStateLabel.Text = "State:";
            // 
            // uxAddressBox
            // 
            this.uxAddressBox.Location = new System.Drawing.Point(128, 94);
            this.uxAddressBox.Name = "uxAddressBox";
            this.uxAddressBox.Size = new System.Drawing.Size(230, 22);
            this.uxAddressBox.TabIndex = 4;
            // 
            // uxAddressLabel
            // 
            this.uxAddressLabel.AutoSize = true;
            this.uxAddressLabel.Location = new System.Drawing.Point(59, 97);
            this.uxAddressLabel.Name = "uxAddressLabel";
            this.uxAddressLabel.Size = new System.Drawing.Size(64, 17);
            this.uxAddressLabel.TabIndex = 5;
            this.uxAddressLabel.Text = "Address:";
            // 
            // uxStorefrontBox
            // 
            this.uxStorefrontBox.Location = new System.Drawing.Point(128, 186);
            this.uxStorefrontBox.Name = "uxStorefrontBox";
            this.uxStorefrontBox.Size = new System.Drawing.Size(230, 22);
            this.uxStorefrontBox.TabIndex = 6;
            // 
            // uxStorefrontLabel
            // 
            this.uxStorefrontLabel.AutoSize = true;
            this.uxStorefrontLabel.Location = new System.Drawing.Point(46, 189);
            this.uxStorefrontLabel.Name = "uxStorefrontLabel";
            this.uxStorefrontLabel.Size = new System.Drawing.Size(75, 17);
            this.uxStorefrontLabel.TabIndex = 7;
            this.uxStorefrontLabel.Text = "Storefront:";
            // 
            // uxComponentCategoryPicker
            // 
            this.uxComponentCategoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComponentCategoryPicker.FormattingEnabled = true;
            this.uxComponentCategoryPicker.Location = new System.Drawing.Point(129, 255);
            this.uxComponentCategoryPicker.Name = "uxComponentCategoryPicker";
            this.uxComponentCategoryPicker.Size = new System.Drawing.Size(106, 24);
            this.uxComponentCategoryPicker.TabIndex = 8;
            // 
            // uxComponentNameBox
            // 
            this.uxComponentNameBox.Location = new System.Drawing.Point(130, 295);
            this.uxComponentNameBox.Name = "uxComponentNameBox";
            this.uxComponentNameBox.Size = new System.Drawing.Size(230, 22);
            this.uxComponentNameBox.TabIndex = 9;
            // 
            // uxComponentCategoryLabel
            // 
            this.uxComponentCategoryLabel.AutoSize = true;
            this.uxComponentCategoryLabel.Location = new System.Drawing.Point(55, 258);
            this.uxComponentCategoryLabel.Name = "uxComponentCategoryLabel";
            this.uxComponentCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.uxComponentCategoryLabel.TabIndex = 11;
            this.uxComponentCategoryLabel.Text = "Category:";
            // 
            // uxComponentNameLabel
            // 
            this.uxComponentNameLabel.AutoSize = true;
            this.uxComponentNameLabel.Location = new System.Drawing.Point(-1, 298);
            this.uxComponentNameLabel.Name = "uxComponentNameLabel";
            this.uxComponentNameLabel.Size = new System.Drawing.Size(125, 17);
            this.uxComponentNameLabel.TabIndex = 12;
            this.uxComponentNameLabel.Text = "Component Name:";
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(12, 446);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(112, 51);
            this.uxSearchButton.TabIndex = 14;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxResultsBox
            // 
            this.uxResultsBox.FullRowSelect = true;
            this.uxResultsBox.HideSelection = false;
            this.uxResultsBox.Location = new System.Drawing.Point(519, 26);
            this.uxResultsBox.Name = "uxResultsBox";
            this.uxResultsBox.Size = new System.Drawing.Size(1133, 775);
            this.uxResultsBox.TabIndex = 15;
            this.uxResultsBox.UseCompatibleStateImageBehavior = false;
            this.uxResultsBox.View = System.Windows.Forms.View.Details;
            // 
            // uxManufacturerLabel
            // 
            this.uxManufacturerLabel.AutoSize = true;
            this.uxManufacturerLabel.Location = new System.Drawing.Point(28, 344);
            this.uxManufacturerLabel.Name = "uxManufacturerLabel";
            this.uxManufacturerLabel.Size = new System.Drawing.Size(96, 17);
            this.uxManufacturerLabel.TabIndex = 17;
            this.uxManufacturerLabel.Text = "Manufacturer:";
            // 
            // uxManufacturerBox
            // 
            this.uxManufacturerBox.Location = new System.Drawing.Point(130, 339);
            this.uxManufacturerBox.Name = "uxManufacturerBox";
            this.uxManufacturerBox.Size = new System.Drawing.Size(230, 22);
            this.uxManufacturerBox.TabIndex = 16;
            // 
            // uxZipCodeLabel
            // 
            this.uxZipCodeLabel.AutoSize = true;
            this.uxZipCodeLabel.Location = new System.Drawing.Point(53, 143);
            this.uxZipCodeLabel.Name = "uxZipCodeLabel";
            this.uxZipCodeLabel.Size = new System.Drawing.Size(69, 17);
            this.uxZipCodeLabel.TabIndex = 21;
            this.uxZipCodeLabel.Text = "Zip Code:";
            // 
            // uxZipCodeBox
            // 
            this.uxZipCodeBox.Location = new System.Drawing.Point(128, 140);
            this.uxZipCodeBox.Name = "uxZipCodeBox";
            this.uxZipCodeBox.Size = new System.Drawing.Size(230, 22);
            this.uxZipCodeBox.TabIndex = 20;
            // 
            // uxMinPriceLabel
            // 
            this.uxMinPriceLabel.AutoSize = true;
            this.uxMinPriceLabel.Location = new System.Drawing.Point(24, 397);
            this.uxMinPriceLabel.Name = "uxMinPriceLabel";
            this.uxMinPriceLabel.Size = new System.Drawing.Size(70, 17);
            this.uxMinPriceLabel.TabIndex = 22;
            this.uxMinPriceLabel.Text = "Min Price:";
            // 
            // uxMaxPriceLabel
            // 
            this.uxMaxPriceLabel.AutoSize = true;
            this.uxMaxPriceLabel.Location = new System.Drawing.Point(235, 397);
            this.uxMaxPriceLabel.Name = "uxMaxPriceLabel";
            this.uxMaxPriceLabel.Size = new System.Drawing.Size(73, 17);
            this.uxMaxPriceLabel.TabIndex = 23;
            this.uxMaxPriceLabel.Text = "Max Price:";
            // 
            // uxMinPriceBox
            // 
            this.uxMinPriceBox.Location = new System.Drawing.Point(110, 397);
            this.uxMinPriceBox.Name = "uxMinPriceBox";
            this.uxMinPriceBox.Size = new System.Drawing.Size(100, 22);
            this.uxMinPriceBox.TabIndex = 24;
            // 
            // uxMaxPriceBox
            // 
            this.uxMaxPriceBox.Location = new System.Drawing.Point(314, 394);
            this.uxMaxPriceBox.Name = "uxMaxPriceBox";
            this.uxMaxPriceBox.Size = new System.Drawing.Size(100, 22);
            this.uxMaxPriceBox.TabIndex = 25;
            // 
            // uxAggregateStockValueButton
            // 
            this.uxAggregateStockValueButton.Location = new System.Drawing.Point(69, 529);
            this.uxAggregateStockValueButton.Name = "uxAggregateStockValueButton";
            this.uxAggregateStockValueButton.Size = new System.Drawing.Size(129, 96);
            this.uxAggregateStockValueButton.TabIndex = 26;
            this.uxAggregateStockValueButton.Text = "Aggregate Store Stock Value By Minimum Value";
            this.uxAggregateStockValueButton.UseVisualStyleBackColor = true;
            this.uxAggregateStockValueButton.Click += new System.EventHandler(this.uxAggregateStockValueButton_Click);
            // 
            // uxAggregatePriceBox
            // 
            this.uxAggregatePriceBox.Location = new System.Drawing.Point(98, 631);
            this.uxAggregatePriceBox.Name = "uxAggregatePriceBox";
            this.uxAggregatePriceBox.Size = new System.Drawing.Size(100, 22);
            this.uxAggregatePriceBox.TabIndex = 27;
            // 
            // uxAggregateCompareMSRPButton
            // 
            this.uxAggregateCompareMSRPButton.Location = new System.Drawing.Point(255, 529);
            this.uxAggregateCompareMSRPButton.Name = "uxAggregateCompareMSRPButton";
            this.uxAggregateCompareMSRPButton.Size = new System.Drawing.Size(129, 96);
            this.uxAggregateCompareMSRPButton.TabIndex = 28;
            this.uxAggregateCompareMSRPButton.Text = "Get Number of Components Listed Below MSRP";
            this.uxAggregateCompareMSRPButton.UseVisualStyleBackColor = true;
            this.uxAggregateCompareMSRPButton.Click += new System.EventHandler(this.uxAggregateCompareMSRPButton_Click);
            // 
            // uxAggregateStoreRatioButton
            // 
            this.uxAggregateStoreRatioButton.Location = new System.Drawing.Point(69, 687);
            this.uxAggregateStoreRatioButton.Name = "uxAggregateStoreRatioButton";
            this.uxAggregateStoreRatioButton.Size = new System.Drawing.Size(129, 96);
            this.uxAggregateStoreRatioButton.TabIndex = 29;
            this.uxAggregateStoreRatioButton.Text = "Get In Stock Ratios of All Stores";
            this.uxAggregateStoreRatioButton.UseVisualStyleBackColor = true;
            this.uxAggregateStoreRatioButton.Click += new System.EventHandler(this.uxAggregateStoreRatioButton_Click);
            // 
            // uxAggregateStoreComponentsButton
            // 
            this.uxAggregateStoreComponentsButton.Location = new System.Drawing.Point(255, 687);
            this.uxAggregateStoreComponentsButton.Name = "uxAggregateStoreComponentsButton";
            this.uxAggregateStoreComponentsButton.Size = new System.Drawing.Size(129, 96);
            this.uxAggregateStoreComponentsButton.TabIndex = 30;
            this.uxAggregateStoreComponentsButton.Text = "Get Number of Stores and Components in Each State";
            this.uxAggregateStoreComponentsButton.UseVisualStyleBackColor = true;
            this.uxAggregateStoreComponentsButton.Click += new System.EventHandler(this.uxAggregateStoreComponentsButton_Click);
            // 
            // uxAggregateMinLabel
            // 
            this.uxAggregateMinLabel.AutoSize = true;
            this.uxAggregateMinLabel.Location = new System.Drawing.Point(23, 634);
            this.uxAggregateMinLabel.Name = "uxAggregateMinLabel";
            this.uxAggregateMinLabel.Size = new System.Drawing.Size(74, 17);
            this.uxAggregateMinLabel.TabIndex = 31;
            this.uxAggregateMinLabel.Text = "Min Value:";
            // 
            // uxLocationFiltersLabel
            // 
            this.uxLocationFiltersLabel.AutoSize = true;
            this.uxLocationFiltersLabel.Location = new System.Drawing.Point(126, 13);
            this.uxLocationFiltersLabel.Name = "uxLocationFiltersLabel";
            this.uxLocationFiltersLabel.Size = new System.Drawing.Size(108, 17);
            this.uxLocationFiltersLabel.TabIndex = 32;
            this.uxLocationFiltersLabel.Text = "Location Filters:";
            // 
            // uxComponentFiltersLabel
            // 
            this.uxComponentFiltersLabel.AutoSize = true;
            this.uxComponentFiltersLabel.Location = new System.Drawing.Point(127, 225);
            this.uxComponentFiltersLabel.Name = "uxComponentFiltersLabel";
            this.uxComponentFiltersLabel.Size = new System.Drawing.Size(126, 17);
            this.uxComponentFiltersLabel.TabIndex = 33;
            this.uxComponentFiltersLabel.Text = "Component Filters:";
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 853);
            this.Controls.Add(this.uxComponentFiltersLabel);
            this.Controls.Add(this.uxLocationFiltersLabel);
            this.Controls.Add(this.uxAggregateMinLabel);
            this.Controls.Add(this.uxAggregateStoreComponentsButton);
            this.Controls.Add(this.uxAggregateStoreRatioButton);
            this.Controls.Add(this.uxAggregateCompareMSRPButton);
            this.Controls.Add(this.uxAggregatePriceBox);
            this.Controls.Add(this.uxAggregateStockValueButton);
            this.Controls.Add(this.uxMaxPriceBox);
            this.Controls.Add(this.uxMinPriceBox);
            this.Controls.Add(this.uxMaxPriceLabel);
            this.Controls.Add(this.uxMinPriceLabel);
            this.Controls.Add(this.uxZipCodeLabel);
            this.Controls.Add(this.uxZipCodeBox);
            this.Controls.Add(this.uxManufacturerLabel);
            this.Controls.Add(this.uxManufacturerBox);
            this.Controls.Add(this.uxResultsBox);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxComponentNameLabel);
            this.Controls.Add(this.uxComponentCategoryLabel);
            this.Controls.Add(this.uxComponentNameBox);
            this.Controls.Add(this.uxComponentCategoryPicker);
            this.Controls.Add(this.uxStorefrontLabel);
            this.Controls.Add(this.uxStorefrontBox);
            this.Controls.Add(this.uxAddressLabel);
            this.Controls.Add(this.uxAddressBox);
            this.Controls.Add(this.uxStateLabel);
            this.Controls.Add(this.uxStatePicker);
            this.Controls.Add(this.uxAdminButton);
            this.MaximumSize = new System.Drawing.Size(1800, 900);
            this.MinimumSize = new System.Drawing.Size(1800, 900);
            this.Name = "ClientView";
            this.Text = "PC Part Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAdminButton;
        private System.Windows.Forms.ComboBox uxStatePicker;
        private System.Windows.Forms.Label uxStateLabel;
        private System.Windows.Forms.TextBox uxAddressBox;
        private System.Windows.Forms.Label uxAddressLabel;
        private System.Windows.Forms.TextBox uxStorefrontBox;
        private System.Windows.Forms.Label uxStorefrontLabel;
        private System.Windows.Forms.ComboBox uxComponentCategoryPicker;
        private System.Windows.Forms.TextBox uxComponentNameBox;
        private System.Windows.Forms.Label uxComponentCategoryLabel;
        private System.Windows.Forms.Label uxComponentNameLabel;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ListView uxResultsBox;
        private System.Windows.Forms.Label uxManufacturerLabel;
        private System.Windows.Forms.TextBox uxManufacturerBox;
        private System.Windows.Forms.Label uxZipCodeLabel;
        private System.Windows.Forms.TextBox uxZipCodeBox;
        private System.Windows.Forms.Label uxMinPriceLabel;
        private System.Windows.Forms.Label uxMaxPriceLabel;
        private System.Windows.Forms.TextBox uxMinPriceBox;
        private System.Windows.Forms.TextBox uxMaxPriceBox;
        private System.Windows.Forms.Button uxAggregateStockValueButton;
        private System.Windows.Forms.TextBox uxAggregatePriceBox;
        private System.Windows.Forms.Button uxAggregateCompareMSRPButton;
        private System.Windows.Forms.Button uxAggregateStoreRatioButton;
        private System.Windows.Forms.Button uxAggregateStoreComponentsButton;
        private System.Windows.Forms.Label uxAggregateMinLabel;
        private System.Windows.Forms.Label uxLocationFiltersLabel;
        private System.Windows.Forms.Label uxComponentFiltersLabel;
    }
}

