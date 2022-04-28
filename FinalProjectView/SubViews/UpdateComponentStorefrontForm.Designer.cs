
namespace FinalProjectView.SubViews
{
    partial class UpdateComponentStorefrontForm
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
            this.SuspendLayout();
            // 
            // uxInStockCheckBox
            // 
            this.uxInStockCheckBox.AutoSize = true;
            this.uxInStockCheckBox.Enabled = false;
            this.uxInStockCheckBox.Location = new System.Drawing.Point(79, 386);
            this.uxInStockCheckBox.Name = "uxInStockCheckBox";
            this.uxInStockCheckBox.Size = new System.Drawing.Size(88, 21);
            this.uxInStockCheckBox.TabIndex = 55;
            this.uxInStockCheckBox.Text = "In Stock?";
            this.uxInStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxPriceComboLabel
            // 
            this.uxPriceComboLabel.AutoSize = true;
            this.uxPriceComboLabel.Enabled = false;
            this.uxPriceComboLabel.Location = new System.Drawing.Point(27, 349);
            this.uxPriceComboLabel.Name = "uxPriceComboLabel";
            this.uxPriceComboLabel.Size = new System.Drawing.Size(44, 17);
            this.uxPriceComboLabel.TabIndex = 54;
            this.uxPriceComboLabel.Text = "Price:";
            // 
            // uxPriceComboBox
            // 
            this.uxPriceComboBox.Enabled = false;
            this.uxPriceComboBox.Location = new System.Drawing.Point(79, 344);
            this.uxPriceComboBox.Name = "uxPriceComboBox";
            this.uxPriceComboBox.Size = new System.Drawing.Size(173, 22);
            this.uxPriceComboBox.TabIndex = 53;
            // 
            // UpdateComponentStorefrontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxInStockCheckBox);
            this.Controls.Add(this.uxPriceComboLabel);
            this.Controls.Add(this.uxPriceComboBox);
            this.Name = "UpdateComponentStorefrontForm";
            this.Text = "UpdateComponentStorefrontForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxInStockCheckBox;
        private System.Windows.Forms.Label uxPriceComboLabel;
        private System.Windows.Forms.TextBox uxPriceComboBox;
    }
}