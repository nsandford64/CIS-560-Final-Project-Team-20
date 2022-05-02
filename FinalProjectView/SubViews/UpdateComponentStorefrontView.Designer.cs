
namespace FinalProjectView.SubViews
{
    partial class UpdateComponentStorefrontView
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
            this.uxComponentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxUpdateButton = new System.Windows.Forms.Button();
            this.uxDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxInStockCheckBox
            // 
            this.uxInStockCheckBox.AutoSize = true;
            this.uxInStockCheckBox.Location = new System.Drawing.Point(123, 215);
            this.uxInStockCheckBox.Name = "uxInStockCheckBox";
            this.uxInStockCheckBox.Size = new System.Drawing.Size(88, 21);
            this.uxInStockCheckBox.TabIndex = 55;
            this.uxInStockCheckBox.Text = "In Stock?";
            this.uxInStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxPriceComboLabel
            // 
            this.uxPriceComboLabel.AutoSize = true;
            this.uxPriceComboLabel.Location = new System.Drawing.Point(71, 178);
            this.uxPriceComboLabel.Name = "uxPriceComboLabel";
            this.uxPriceComboLabel.Size = new System.Drawing.Size(44, 17);
            this.uxPriceComboLabel.TabIndex = 54;
            this.uxPriceComboLabel.Text = "Price:";
            // 
            // uxPriceComboBox
            // 
            this.uxPriceComboBox.Location = new System.Drawing.Point(123, 173);
            this.uxPriceComboBox.Name = "uxPriceComboBox";
            this.uxPriceComboBox.Size = new System.Drawing.Size(173, 22);
            this.uxPriceComboBox.TabIndex = 53;
            // 
            // uxComponentList
            // 
            this.uxComponentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.uxComponentList.HideSelection = false;
            this.uxComponentList.Location = new System.Drawing.Point(332, 28);
            this.uxComponentList.MultiSelect = false;
            this.uxComponentList.Name = "uxComponentList";
            this.uxComponentList.Size = new System.Drawing.Size(508, 379);
            this.uxComponentList.TabIndex = 56;
            this.uxComponentList.UseCompatibleStateImageBehavior = false;
            this.uxComponentList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Component Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Model Number";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "In Stock";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Store Address";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "City";
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.Location = new System.Drawing.Point(103, 342);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(127, 65);
            this.uxUpdateButton.TabIndex = 63;
            this.uxUpdateButton.Text = "Update Component Status";
            this.uxUpdateButton.UseVisualStyleBackColor = true;
            this.uxUpdateButton.Click += new System.EventHandler(this.uxUpdateButton_Click);
            // 
            // uxDisplayLabel
            // 
            this.uxDisplayLabel.AutoSize = true;
            this.uxDisplayLabel.Location = new System.Drawing.Point(71, 286);
            this.uxDisplayLabel.Name = "uxDisplayLabel";
            this.uxDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDisplayLabel.TabIndex = 64;
            // 
            // UpdateComponentStorefrontView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.uxDisplayLabel);
            this.Controls.Add(this.uxUpdateButton);
            this.Controls.Add(this.uxComponentList);
            this.Controls.Add(this.uxInStockCheckBox);
            this.Controls.Add(this.uxPriceComboLabel);
            this.Controls.Add(this.uxPriceComboBox);
            this.Name = "UpdateComponentStorefrontView";
            this.Text = "Update Component Storefront";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxInStockCheckBox;
        private System.Windows.Forms.Label uxPriceComboLabel;
        private System.Windows.Forms.TextBox uxPriceComboBox;
        private System.Windows.Forms.ListView uxComponentList;
        private System.Windows.Forms.Button uxUpdateButton;
        private System.Windows.Forms.Label uxDisplayLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}