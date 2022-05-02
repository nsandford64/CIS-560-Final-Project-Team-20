
namespace FinalProjectView.SubViews
{
    partial class AddStorefrontView
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
            this.uxStoreCityNamePicker = new System.Windows.Forms.ComboBox();
            this.uxStoreStatePicker = new System.Windows.Forms.ComboBox();
            this.uxStoreStateNameLabel = new System.Windows.Forms.Label();
            this.uxStoreCityLabel = new System.Windows.Forms.Label();
            this.uxZipCodeLabel = new System.Windows.Forms.Label();
            this.uxZipCodeBox = new System.Windows.Forms.TextBox();
            this.uxStoreAddressLabel = new System.Windows.Forms.Label();
            this.uxStoreAddressBox = new System.Windows.Forms.TextBox();
            this.uxStoreNameLabel = new System.Windows.Forms.Label();
            this.uxStoreNameBox = new System.Windows.Forms.TextBox();
            this.uxStorefrontButton = new System.Windows.Forms.Button();
            this.uxDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxStoreCityNamePicker
            // 
            this.uxStoreCityNamePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxStoreCityNamePicker.FormattingEnabled = true;
            this.uxStoreCityNamePicker.Location = new System.Drawing.Point(143, 198);
            this.uxStoreCityNamePicker.Name = "uxStoreCityNamePicker";
            this.uxStoreCityNamePicker.Size = new System.Drawing.Size(192, 24);
            this.uxStoreCityNamePicker.TabIndex = 59;
            // 
            // uxStoreStatePicker
            // 
            this.uxStoreStatePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxStoreStatePicker.FormattingEnabled = true;
            this.uxStoreStatePicker.Location = new System.Drawing.Point(143, 154);
            this.uxStoreStatePicker.Name = "uxStoreStatePicker";
            this.uxStoreStatePicker.Size = new System.Drawing.Size(192, 24);
            this.uxStoreStatePicker.TabIndex = 58;
            this.uxStoreStatePicker.SelectedIndexChanged += new System.EventHandler(this.uxStoreStatePicker_SelectedIndexChanged);
            // 
            // uxStoreStateNameLabel
            // 
            this.uxStoreStateNameLabel.AutoSize = true;
            this.uxStoreStateNameLabel.Location = new System.Drawing.Point(45, 161);
            this.uxStoreStateNameLabel.Name = "uxStoreStateNameLabel";
            this.uxStoreStateNameLabel.Size = new System.Drawing.Size(86, 17);
            this.uxStoreStateNameLabel.TabIndex = 57;
            this.uxStoreStateNameLabel.Text = "State Name:";
            // 
            // uxStoreCityLabel
            // 
            this.uxStoreCityLabel.AutoSize = true;
            this.uxStoreCityLabel.Location = new System.Drawing.Point(56, 201);
            this.uxStoreCityLabel.Name = "uxStoreCityLabel";
            this.uxStoreCityLabel.Size = new System.Drawing.Size(76, 17);
            this.uxStoreCityLabel.TabIndex = 56;
            this.uxStoreCityLabel.Text = "City Name:";
            // 
            // uxZipCodeLabel
            // 
            this.uxZipCodeLabel.AutoSize = true;
            this.uxZipCodeLabel.Location = new System.Drawing.Point(63, 118);
            this.uxZipCodeLabel.Name = "uxZipCodeLabel";
            this.uxZipCodeLabel.Size = new System.Drawing.Size(69, 17);
            this.uxZipCodeLabel.TabIndex = 55;
            this.uxZipCodeLabel.Text = "Zip Code:";
            // 
            // uxZipCodeBox
            // 
            this.uxZipCodeBox.Location = new System.Drawing.Point(143, 113);
            this.uxZipCodeBox.Name = "uxZipCodeBox";
            this.uxZipCodeBox.Size = new System.Drawing.Size(192, 22);
            this.uxZipCodeBox.TabIndex = 54;
            // 
            // uxStoreAddressLabel
            // 
            this.uxStoreAddressLabel.AutoSize = true;
            this.uxStoreAddressLabel.Location = new System.Drawing.Point(30, 75);
            this.uxStoreAddressLabel.Name = "uxStoreAddressLabel";
            this.uxStoreAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.uxStoreAddressLabel.TabIndex = 53;
            this.uxStoreAddressLabel.Text = "Store Address:";
            // 
            // uxStoreAddressBox
            // 
            this.uxStoreAddressBox.Location = new System.Drawing.Point(143, 70);
            this.uxStoreAddressBox.Name = "uxStoreAddressBox";
            this.uxStoreAddressBox.Size = new System.Drawing.Size(192, 22);
            this.uxStoreAddressBox.TabIndex = 52;
            // 
            // uxStoreNameLabel
            // 
            this.uxStoreNameLabel.AutoSize = true;
            this.uxStoreNameLabel.Location = new System.Drawing.Point(45, 27);
            this.uxStoreNameLabel.Name = "uxStoreNameLabel";
            this.uxStoreNameLabel.Size = new System.Drawing.Size(87, 17);
            this.uxStoreNameLabel.TabIndex = 51;
            this.uxStoreNameLabel.Text = "Store Name:";
            // 
            // uxStoreNameBox
            // 
            this.uxStoreNameBox.Location = new System.Drawing.Point(143, 22);
            this.uxStoreNameBox.Name = "uxStoreNameBox";
            this.uxStoreNameBox.Size = new System.Drawing.Size(192, 22);
            this.uxStoreNameBox.TabIndex = 50;
            // 
            // uxStorefrontButton
            // 
            this.uxStorefrontButton.Location = new System.Drawing.Point(143, 292);
            this.uxStorefrontButton.Name = "uxStorefrontButton";
            this.uxStorefrontButton.Size = new System.Drawing.Size(134, 39);
            this.uxStorefrontButton.TabIndex = 49;
            this.uxStorefrontButton.Text = "Add Storefront";
            this.uxStorefrontButton.UseVisualStyleBackColor = true;
            this.uxStorefrontButton.Click += new System.EventHandler(this.uxStorefrontButton_Click);
            // 
            // uxDisplayLabel
            // 
            this.uxDisplayLabel.AutoSize = true;
            this.uxDisplayLabel.Location = new System.Drawing.Point(76, 253);
            this.uxDisplayLabel.Name = "uxDisplayLabel";
            this.uxDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDisplayLabel.TabIndex = 60;
            // 
            // AddStorefrontView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 355);
            this.Controls.Add(this.uxDisplayLabel);
            this.Controls.Add(this.uxStoreCityNamePicker);
            this.Controls.Add(this.uxStoreStatePicker);
            this.Controls.Add(this.uxStoreStateNameLabel);
            this.Controls.Add(this.uxStoreCityLabel);
            this.Controls.Add(this.uxZipCodeLabel);
            this.Controls.Add(this.uxZipCodeBox);
            this.Controls.Add(this.uxStoreAddressLabel);
            this.Controls.Add(this.uxStoreAddressBox);
            this.Controls.Add(this.uxStoreNameLabel);
            this.Controls.Add(this.uxStoreNameBox);
            this.Controls.Add(this.uxStorefrontButton);
            this.Name = "AddStorefrontView";
            this.Text = "AddStorefrontView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxStoreCityNamePicker;
        private System.Windows.Forms.ComboBox uxStoreStatePicker;
        private System.Windows.Forms.Label uxStoreStateNameLabel;
        private System.Windows.Forms.Label uxStoreCityLabel;
        private System.Windows.Forms.Label uxZipCodeLabel;
        private System.Windows.Forms.TextBox uxZipCodeBox;
        private System.Windows.Forms.Label uxStoreAddressLabel;
        private System.Windows.Forms.TextBox uxStoreAddressBox;
        private System.Windows.Forms.Label uxStoreNameLabel;
        private System.Windows.Forms.TextBox uxStoreNameBox;
        private System.Windows.Forms.Button uxStorefrontButton;
        private System.Windows.Forms.Label uxDisplayLabel;
    }
}