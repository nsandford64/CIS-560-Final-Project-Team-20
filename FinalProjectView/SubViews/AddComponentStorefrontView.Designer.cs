
namespace FinalProjectView.SubViews
{
    partial class AddComponentStorefrontView
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
            this.uxInStockCheckBox = new System.Windows.Forms.CheckBox();
            this.uxPriceComboLabel = new System.Windows.Forms.Label();
            this.uxPriceComboBox = new System.Windows.Forms.TextBox();
            this.uxZipCodeComboLabel = new System.Windows.Forms.Label();
            this.uxStoreAddressComboLabel = new System.Windows.Forms.Label();
            this.uxModelNumberComboLabel = new System.Windows.Forms.Label();
            this.uxComponentStorefrontButton = new System.Windows.Forms.Button();
            this.uxDisplayLabel = new System.Windows.Forms.Label();
            this.uxZipCodePicker = new System.Windows.Forms.ComboBox();
            this.uxStoreAddressPicker = new System.Windows.Forms.ComboBox();
            this.uxModelNumberPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxInStockCheckBox
            // 
            this.uxInStockCheckBox.AutoSize = true;
            this.uxInStockCheckBox.Location = new System.Drawing.Point(155, 222);
            this.uxInStockCheckBox.Name = "uxInStockCheckBox";
            this.uxInStockCheckBox.Size = new System.Drawing.Size(88, 21);
            this.uxInStockCheckBox.TabIndex = 52;
            this.uxInStockCheckBox.Text = "In Stock?";
            this.uxInStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxPriceComboLabel
            // 
            this.uxPriceComboLabel.AutoSize = true;
            this.uxPriceComboLabel.Location = new System.Drawing.Point(103, 185);
            this.uxPriceComboLabel.Name = "uxPriceComboLabel";
            this.uxPriceComboLabel.Size = new System.Drawing.Size(44, 17);
            this.uxPriceComboLabel.TabIndex = 51;
            this.uxPriceComboLabel.Text = "Price:";
            // 
            // uxPriceComboBox
            // 
            this.uxPriceComboBox.Location = new System.Drawing.Point(155, 180);
            this.uxPriceComboBox.Name = "uxPriceComboBox";
            this.uxPriceComboBox.Size = new System.Drawing.Size(173, 22);
            this.uxPriceComboBox.TabIndex = 50;
            // 
            // uxZipCodeComboLabel
            // 
            this.uxZipCodeComboLabel.AutoSize = true;
            this.uxZipCodeComboLabel.Location = new System.Drawing.Point(78, 93);
            this.uxZipCodeComboLabel.Name = "uxZipCodeComboLabel";
            this.uxZipCodeComboLabel.Size = new System.Drawing.Size(69, 17);
            this.uxZipCodeComboLabel.TabIndex = 49;
            this.uxZipCodeComboLabel.Text = "Zip Code:";
            // 
            // uxStoreAddressComboLabel
            // 
            this.uxStoreAddressComboLabel.AutoSize = true;
            this.uxStoreAddressComboLabel.Location = new System.Drawing.Point(45, 140);
            this.uxStoreAddressComboLabel.Name = "uxStoreAddressComboLabel";
            this.uxStoreAddressComboLabel.Size = new System.Drawing.Size(102, 17);
            this.uxStoreAddressComboLabel.TabIndex = 47;
            this.uxStoreAddressComboLabel.Text = "Store Address:";
            // 
            // uxModelNumberComboLabel
            // 
            this.uxModelNumberComboLabel.AutoSize = true;
            this.uxModelNumberComboLabel.Location = new System.Drawing.Point(45, 46);
            this.uxModelNumberComboLabel.Name = "uxModelNumberComboLabel";
            this.uxModelNumberComboLabel.Size = new System.Drawing.Size(104, 17);
            this.uxModelNumberComboLabel.TabIndex = 45;
            this.uxModelNumberComboLabel.Text = "Model Number:";
            // 
            // uxComponentStorefrontButton
            // 
            this.uxComponentStorefrontButton.Location = new System.Drawing.Point(135, 286);
            this.uxComponentStorefrontButton.Name = "uxComponentStorefrontButton";
            this.uxComponentStorefrontButton.Size = new System.Drawing.Size(134, 57);
            this.uxComponentStorefrontButton.TabIndex = 43;
            this.uxComponentStorefrontButton.Text = "Update Storefront Component";
            this.uxComponentStorefrontButton.UseVisualStyleBackColor = true;
            this.uxComponentStorefrontButton.Click += new System.EventHandler(this.uxComponentStorefrontButton_Click);
            // 
            // uxDisplayLabel
            // 
            this.uxDisplayLabel.AutoSize = true;
            this.uxDisplayLabel.Location = new System.Drawing.Point(78, 246);
            this.uxDisplayLabel.Name = "uxDisplayLabel";
            this.uxDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDisplayLabel.TabIndex = 53;
            // 
            // uxZipCodePicker
            // 
            this.uxZipCodePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxZipCodePicker.FormattingEnabled = true;
            this.uxZipCodePicker.Location = new System.Drawing.Point(154, 93);
            this.uxZipCodePicker.Name = "uxZipCodePicker";
            this.uxZipCodePicker.Size = new System.Drawing.Size(174, 24);
            this.uxZipCodePicker.TabIndex = 54;
            // 
            // uxStoreAddressPicker
            // 
            this.uxStoreAddressPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxStoreAddressPicker.FormattingEnabled = true;
            this.uxStoreAddressPicker.Location = new System.Drawing.Point(153, 137);
            this.uxStoreAddressPicker.Name = "uxStoreAddressPicker";
            this.uxStoreAddressPicker.Size = new System.Drawing.Size(174, 24);
            this.uxStoreAddressPicker.TabIndex = 55;
            // 
            // uxModelNumberPicker
            // 
            this.uxModelNumberPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxModelNumberPicker.FormattingEnabled = true;
            this.uxModelNumberPicker.Location = new System.Drawing.Point(153, 46);
            this.uxModelNumberPicker.Name = "uxModelNumberPicker";
            this.uxModelNumberPicker.Size = new System.Drawing.Size(174, 24);
            this.uxModelNumberPicker.TabIndex = 56;
            // 
            // AddComponentStorefrontView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 355);
            this.Controls.Add(this.uxModelNumberPicker);
            this.Controls.Add(this.uxStoreAddressPicker);
            this.Controls.Add(this.uxZipCodePicker);
            this.Controls.Add(this.uxDisplayLabel);
            this.Controls.Add(this.uxInStockCheckBox);
            this.Controls.Add(this.uxPriceComboLabel);
            this.Controls.Add(this.uxPriceComboBox);
            this.Controls.Add(this.uxZipCodeComboLabel);
            this.Controls.Add(this.uxStoreAddressComboLabel);
            this.Controls.Add(this.uxModelNumberComboLabel);
            this.Controls.Add(this.uxComponentStorefrontButton);
            this.Name = "AddComponentStorefrontView";
            this.Text = "AddComponentStorefrontView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxInStockCheckBox;
        private System.Windows.Forms.Label uxPriceComboLabel;
        private System.Windows.Forms.TextBox uxPriceComboBox;
        private System.Windows.Forms.Label uxZipCodeComboLabel;
        private System.Windows.Forms.Label uxStoreAddressComboLabel;
        private System.Windows.Forms.Label uxModelNumberComboLabel;
        private System.Windows.Forms.Button uxComponentStorefrontButton;
        private System.Windows.Forms.Label uxDisplayLabel;
        private System.Windows.Forms.ComboBox uxZipCodePicker;
        private System.Windows.Forms.ComboBox uxStoreAddressPicker;
        private System.Windows.Forms.ComboBox uxModelNumberPicker;
    }
}