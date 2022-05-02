
namespace FinalProjectView.SubViews
{
    partial class AddManufacturerView
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
            this.uxManufacturerNameLabel = new System.Windows.Forms.Label();
            this.uxManufacturerNameBox = new System.Windows.Forms.TextBox();
            this.uxAddManufacturerButton = new System.Windows.Forms.Button();
            this.uxDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxManufacturerNameLabel
            // 
            this.uxManufacturerNameLabel.AutoSize = true;
            this.uxManufacturerNameLabel.Location = new System.Drawing.Point(70, 36);
            this.uxManufacturerNameLabel.Name = "uxManufacturerNameLabel";
            this.uxManufacturerNameLabel.Size = new System.Drawing.Size(137, 17);
            this.uxManufacturerNameLabel.TabIndex = 19;
            this.uxManufacturerNameLabel.Text = "Manufacturer Name:";
            // 
            // uxManufacturerNameBox
            // 
            this.uxManufacturerNameBox.Location = new System.Drawing.Point(213, 36);
            this.uxManufacturerNameBox.Name = "uxManufacturerNameBox";
            this.uxManufacturerNameBox.Size = new System.Drawing.Size(100, 22);
            this.uxManufacturerNameBox.TabIndex = 18;
            // 
            // uxAddManufacturerButton
            // 
            this.uxAddManufacturerButton.Location = new System.Drawing.Point(127, 134);
            this.uxAddManufacturerButton.Name = "uxAddManufacturerButton";
            this.uxAddManufacturerButton.Size = new System.Drawing.Size(134, 39);
            this.uxAddManufacturerButton.TabIndex = 17;
            this.uxAddManufacturerButton.Text = "Add Manufacturer";
            this.uxAddManufacturerButton.UseVisualStyleBackColor = true;
            this.uxAddManufacturerButton.Click += new System.EventHandler(this.uxAddManufacturerButton_Click);
            // 
            // uxDisplayLabel
            // 
            this.uxDisplayLabel.AutoSize = true;
            this.uxDisplayLabel.Location = new System.Drawing.Point(43, 95);
            this.uxDisplayLabel.Name = "uxDisplayLabel";
            this.uxDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDisplayLabel.TabIndex = 20;
            // 
            // AddManufacturerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 205);
            this.Controls.Add(this.uxDisplayLabel);
            this.Controls.Add(this.uxManufacturerNameLabel);
            this.Controls.Add(this.uxManufacturerNameBox);
            this.Controls.Add(this.uxAddManufacturerButton);
            this.Name = "AddManufacturerView";
            this.Text = "Add Manufacturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxManufacturerNameLabel;
        private System.Windows.Forms.TextBox uxManufacturerNameBox;
        private System.Windows.Forms.Button uxAddManufacturerButton;
        private System.Windows.Forms.Label uxDisplayLabel;
    }
}