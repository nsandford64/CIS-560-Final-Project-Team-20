
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
            this.uxStoreLabel = new System.Windows.Forms.Label();
            this.uxComponentCategoryPicker = new System.Windows.Forms.ComboBox();
            this.uxComponentNameBox = new System.Windows.Forms.TextBox();
            this.uxModelNumberBox = new System.Windows.Forms.TextBox();
            this.uxComponentCategoryLabel = new System.Windows.Forms.Label();
            this.uxComponentNameLabel = new System.Windows.Forms.Label();
            this.uxModelNumberLabel = new System.Windows.Forms.Label();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxResultsBox = new System.Windows.Forms.ListView();
            this.uxManufacturerLabel = new System.Windows.Forms.Label();
            this.uxManufacturerBox = new System.Windows.Forms.TextBox();
            this.uxLocationPropertyCheckBox = new System.Windows.Forms.CheckBox();
            this.uxComponentPropertyCheckBox = new System.Windows.Forms.CheckBox();
            this.uxZipCodeBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxMinPriceLabel = new System.Windows.Forms.Label();
            this.uxMaxPriceLabel = new System.Windows.Forms.Label();
            this.uxMinPriceBox = new System.Windows.Forms.TextBox();
            this.uxMaxPriceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxAdminButton
            // 
            this.uxAdminButton.Location = new System.Drawing.Point(1138, 12);
            this.uxAdminButton.Name = "uxAdminButton";
            this.uxAdminButton.Size = new System.Drawing.Size(112, 51);
            this.uxAdminButton.TabIndex = 0;
            this.uxAdminButton.Text = "Switch to Admin View";
            this.uxAdminButton.UseVisualStyleBackColor = true;
            this.uxAdminButton.Click += new System.EventHandler(this.uxAdminButton_Click);
            // 
            // uxStatePicker
            // 
            this.uxStatePicker.Enabled = false;
            this.uxStatePicker.FormattingEnabled = true;
            this.uxStatePicker.Location = new System.Drawing.Point(92, 120);
            this.uxStatePicker.Name = "uxStatePicker";
            this.uxStatePicker.Size = new System.Drawing.Size(106, 24);
            this.uxStatePicker.TabIndex = 1;
            this.uxStatePicker.VisibleChanged += new System.EventHandler(this.uxStatePicker_VisibleChanged);
            // 
            // uxStateLabel
            // 
            this.uxStateLabel.AutoSize = true;
            this.uxStateLabel.Enabled = false;
            this.uxStateLabel.Location = new System.Drawing.Point(42, 123);
            this.uxStateLabel.Name = "uxStateLabel";
            this.uxStateLabel.Size = new System.Drawing.Size(45, 17);
            this.uxStateLabel.TabIndex = 2;
            this.uxStateLabel.Text = "State:";
            // 
            // uxAddressBox
            // 
            this.uxAddressBox.Enabled = false;
            this.uxAddressBox.Location = new System.Drawing.Point(92, 163);
            this.uxAddressBox.Name = "uxAddressBox";
            this.uxAddressBox.Size = new System.Drawing.Size(230, 22);
            this.uxAddressBox.TabIndex = 4;
            // 
            // uxAddressLabel
            // 
            this.uxAddressLabel.AutoSize = true;
            this.uxAddressLabel.Enabled = false;
            this.uxAddressLabel.Location = new System.Drawing.Point(23, 166);
            this.uxAddressLabel.Name = "uxAddressLabel";
            this.uxAddressLabel.Size = new System.Drawing.Size(64, 17);
            this.uxAddressLabel.TabIndex = 5;
            this.uxAddressLabel.Text = "Address:";
            // 
            // uxStorefrontBox
            // 
            this.uxStorefrontBox.Enabled = false;
            this.uxStorefrontBox.Location = new System.Drawing.Point(92, 255);
            this.uxStorefrontBox.Name = "uxStorefrontBox";
            this.uxStorefrontBox.Size = new System.Drawing.Size(230, 22);
            this.uxStorefrontBox.TabIndex = 6;
            this.uxStorefrontBox.TextChanged += new System.EventHandler(this.uxStorefrontBox_TextChanged);
            // 
            // uxStoreLabel
            // 
            this.uxStoreLabel.AutoSize = true;
            this.uxStoreLabel.Enabled = false;
            this.uxStoreLabel.Location = new System.Drawing.Point(10, 258);
            this.uxStoreLabel.Name = "uxStoreLabel";
            this.uxStoreLabel.Size = new System.Drawing.Size(75, 17);
            this.uxStoreLabel.TabIndex = 7;
            this.uxStoreLabel.Text = "Storefront:";
            // 
            // uxComponentCategoryPicker
            // 
            this.uxComponentCategoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComponentCategoryPicker.Enabled = false;
            this.uxComponentCategoryPicker.FormattingEnabled = true;
            this.uxComponentCategoryPicker.Location = new System.Drawing.Point(92, 342);
            this.uxComponentCategoryPicker.Name = "uxComponentCategoryPicker";
            this.uxComponentCategoryPicker.Size = new System.Drawing.Size(106, 24);
            this.uxComponentCategoryPicker.TabIndex = 8;
            // 
            // uxComponentNameBox
            // 
            this.uxComponentNameBox.Enabled = false;
            this.uxComponentNameBox.Location = new System.Drawing.Point(112, 394);
            this.uxComponentNameBox.Name = "uxComponentNameBox";
            this.uxComponentNameBox.Size = new System.Drawing.Size(230, 22);
            this.uxComponentNameBox.TabIndex = 9;
            // 
            // uxModelNumberBox
            // 
            this.uxModelNumberBox.Enabled = false;
            this.uxModelNumberBox.Location = new System.Drawing.Point(112, 439);
            this.uxModelNumberBox.Name = "uxModelNumberBox";
            this.uxModelNumberBox.Size = new System.Drawing.Size(230, 22);
            this.uxModelNumberBox.TabIndex = 10;
            // 
            // uxComponentCategoryLabel
            // 
            this.uxComponentCategoryLabel.AutoSize = true;
            this.uxComponentCategoryLabel.Enabled = false;
            this.uxComponentCategoryLabel.Location = new System.Drawing.Point(18, 345);
            this.uxComponentCategoryLabel.Name = "uxComponentCategoryLabel";
            this.uxComponentCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.uxComponentCategoryLabel.TabIndex = 11;
            this.uxComponentCategoryLabel.Text = "Category:";
            // 
            // uxComponentNameLabel
            // 
            this.uxComponentNameLabel.AutoSize = true;
            this.uxComponentNameLabel.Enabled = false;
            this.uxComponentNameLabel.Location = new System.Drawing.Point(57, 397);
            this.uxComponentNameLabel.Name = "uxComponentNameLabel";
            this.uxComponentNameLabel.Size = new System.Drawing.Size(49, 17);
            this.uxComponentNameLabel.TabIndex = 12;
            this.uxComponentNameLabel.Text = "Name:";
            // 
            // uxModelNumberLabel
            // 
            this.uxModelNumberLabel.AutoSize = true;
            this.uxModelNumberLabel.Enabled = false;
            this.uxModelNumberLabel.Location = new System.Drawing.Point(30, 442);
            this.uxModelNumberLabel.Name = "uxModelNumberLabel";
            this.uxModelNumberLabel.Size = new System.Drawing.Size(76, 17);
            this.uxModelNumberLabel.TabIndex = 13;
            this.uxModelNumberLabel.Text = "Model No.:";
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(92, 655);
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
            this.uxResultsBox.Location = new System.Drawing.Point(433, 26);
            this.uxResultsBox.Name = "uxResultsBox";
            this.uxResultsBox.Size = new System.Drawing.Size(699, 489);
            this.uxResultsBox.TabIndex = 15;
            this.uxResultsBox.UseCompatibleStateImageBehavior = false;
            this.uxResultsBox.View = System.Windows.Forms.View.Details;
            // 
            // uxManufacturerLabel
            // 
            this.uxManufacturerLabel.AutoSize = true;
            this.uxManufacturerLabel.Enabled = false;
            this.uxManufacturerLabel.Location = new System.Drawing.Point(10, 488);
            this.uxManufacturerLabel.Name = "uxManufacturerLabel";
            this.uxManufacturerLabel.Size = new System.Drawing.Size(96, 17);
            this.uxManufacturerLabel.TabIndex = 17;
            this.uxManufacturerLabel.Text = "Manufacturer:";
            // 
            // uxManufacturerBox
            // 
            this.uxManufacturerBox.Enabled = false;
            this.uxManufacturerBox.Location = new System.Drawing.Point(112, 483);
            this.uxManufacturerBox.Name = "uxManufacturerBox";
            this.uxManufacturerBox.Size = new System.Drawing.Size(230, 22);
            this.uxManufacturerBox.TabIndex = 16;
            // 
            // uxLocationPropertyCheckBox
            // 
            this.uxLocationPropertyCheckBox.AutoSize = true;
            this.uxLocationPropertyCheckBox.Location = new System.Drawing.Point(13, 13);
            this.uxLocationPropertyCheckBox.Name = "uxLocationPropertyCheckBox";
            this.uxLocationPropertyCheckBox.Size = new System.Drawing.Size(133, 21);
            this.uxLocationPropertyCheckBox.TabIndex = 18;
            this.uxLocationPropertyCheckBox.Text = "Filter by location";
            this.uxLocationPropertyCheckBox.UseVisualStyleBackColor = true;
            this.uxLocationPropertyCheckBox.CheckedChanged += new System.EventHandler(this.uxLocationPropertyCheckBox_CheckedChanged);
            // 
            // uxComponentPropertyCheckBox
            // 
            this.uxComponentPropertyCheckBox.AutoSize = true;
            this.uxComponentPropertyCheckBox.Location = new System.Drawing.Point(13, 57);
            this.uxComponentPropertyCheckBox.Name = "uxComponentPropertyCheckBox";
            this.uxComponentPropertyCheckBox.Size = new System.Drawing.Size(161, 21);
            this.uxComponentPropertyCheckBox.TabIndex = 19;
            this.uxComponentPropertyCheckBox.Text = "Filter by components";
            this.uxComponentPropertyCheckBox.UseVisualStyleBackColor = true;
            this.uxComponentPropertyCheckBox.CheckedChanged += new System.EventHandler(this.uxComponentPropertyCheckBox_CheckedChanged);
            // 
            // uxZipCodeBox
            // 
            this.uxZipCodeBox.AutoSize = true;
            this.uxZipCodeBox.Enabled = false;
            this.uxZipCodeBox.Location = new System.Drawing.Point(17, 212);
            this.uxZipCodeBox.Name = "uxZipCodeBox";
            this.uxZipCodeBox.Size = new System.Drawing.Size(69, 17);
            this.uxZipCodeBox.TabIndex = 21;
            this.uxZipCodeBox.Text = "Zip Code:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(92, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 20;
            // 
            // uxMinPriceLabel
            // 
            this.uxMinPriceLabel.AutoSize = true;
            this.uxMinPriceLabel.Enabled = false;
            this.uxMinPriceLabel.Location = new System.Drawing.Point(26, 562);
            this.uxMinPriceLabel.Name = "uxMinPriceLabel";
            this.uxMinPriceLabel.Size = new System.Drawing.Size(70, 17);
            this.uxMinPriceLabel.TabIndex = 22;
            this.uxMinPriceLabel.Text = "Min Price:";
            // 
            // uxMaxPriceLabel
            // 
            this.uxMaxPriceLabel.AutoSize = true;
            this.uxMaxPriceLabel.Enabled = false;
            this.uxMaxPriceLabel.Location = new System.Drawing.Point(282, 562);
            this.uxMaxPriceLabel.Name = "uxMaxPriceLabel";
            this.uxMaxPriceLabel.Size = new System.Drawing.Size(73, 17);
            this.uxMaxPriceLabel.TabIndex = 23;
            this.uxMaxPriceLabel.Text = "Max Price:";
            // 
            // uxMinPriceBox
            // 
            this.uxMinPriceBox.Enabled = false;
            this.uxMinPriceBox.Location = new System.Drawing.Point(112, 562);
            this.uxMinPriceBox.Name = "uxMinPriceBox";
            this.uxMinPriceBox.Size = new System.Drawing.Size(100, 22);
            this.uxMinPriceBox.TabIndex = 24;
            // 
            // uxMaxPriceBox
            // 
            this.uxMaxPriceBox.Enabled = false;
            this.uxMaxPriceBox.Location = new System.Drawing.Point(361, 559);
            this.uxMaxPriceBox.Name = "uxMaxPriceBox";
            this.uxMaxPriceBox.Size = new System.Drawing.Size(100, 22);
            this.uxMaxPriceBox.TabIndex = 25;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 735);
            this.Controls.Add(this.uxMaxPriceBox);
            this.Controls.Add(this.uxMinPriceBox);
            this.Controls.Add(this.uxMaxPriceLabel);
            this.Controls.Add(this.uxMinPriceLabel);
            this.Controls.Add(this.uxZipCodeBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxComponentPropertyCheckBox);
            this.Controls.Add(this.uxLocationPropertyCheckBox);
            this.Controls.Add(this.uxManufacturerLabel);
            this.Controls.Add(this.uxManufacturerBox);
            this.Controls.Add(this.uxResultsBox);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxModelNumberLabel);
            this.Controls.Add(this.uxComponentNameLabel);
            this.Controls.Add(this.uxComponentCategoryLabel);
            this.Controls.Add(this.uxModelNumberBox);
            this.Controls.Add(this.uxComponentNameBox);
            this.Controls.Add(this.uxComponentCategoryPicker);
            this.Controls.Add(this.uxStoreLabel);
            this.Controls.Add(this.uxStorefrontBox);
            this.Controls.Add(this.uxAddressLabel);
            this.Controls.Add(this.uxAddressBox);
            this.Controls.Add(this.uxStateLabel);
            this.Controls.Add(this.uxStatePicker);
            this.Controls.Add(this.uxAdminButton);
            this.Name = "ClientView";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label uxStoreLabel;
        private System.Windows.Forms.ComboBox uxComponentCategoryPicker;
        private System.Windows.Forms.TextBox uxComponentNameBox;
        private System.Windows.Forms.TextBox uxModelNumberBox;
        private System.Windows.Forms.Label uxComponentCategoryLabel;
        private System.Windows.Forms.Label uxComponentNameLabel;
        private System.Windows.Forms.Label uxModelNumberLabel;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ListView uxResultsBox;
        private System.Windows.Forms.Label uxManufacturerLabel;
        private System.Windows.Forms.TextBox uxManufacturerBox;
        private System.Windows.Forms.CheckBox uxLocationPropertyCheckBox;
        private System.Windows.Forms.CheckBox uxComponentPropertyCheckBox;
        private System.Windows.Forms.Label uxZipCodeBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label uxMinPriceLabel;
        private System.Windows.Forms.Label uxMaxPriceLabel;
        private System.Windows.Forms.TextBox uxMinPriceBox;
        private System.Windows.Forms.TextBox uxMaxPriceBox;
    }
}

