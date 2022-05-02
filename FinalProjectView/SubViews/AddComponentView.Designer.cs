
namespace FinalProjectView.SubViews
{
    partial class AddComponentView
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
            this.uxManufacturerPicker = new System.Windows.Forms.ComboBox();
            this.uxMSRPLabel = new System.Windows.Forms.Label();
            this.uxMSRPBox = new System.Windows.Forms.TextBox();
            this.uxComponentCategoryLabel = new System.Windows.Forms.Label();
            this.uxManufacturerLabel = new System.Windows.Forms.Label();
            this.uxModelNumberLabel = new System.Windows.Forms.Label();
            this.uxModelNumberBox = new System.Windows.Forms.TextBox();
            this.uxComponentNameLabel = new System.Windows.Forms.Label();
            this.uxComponentNameBox = new System.Windows.Forms.TextBox();
            this.uxAddComponentButton = new System.Windows.Forms.Button();
            this.uxComponentCategoryPicker = new System.Windows.Forms.ComboBox();
            this.uxDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxManufacturerPicker
            // 
            this.uxManufacturerPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxManufacturerPicker.FormattingEnabled = true;
            this.uxManufacturerPicker.Location = new System.Drawing.Point(158, 101);
            this.uxManufacturerPicker.Name = "uxManufacturerPicker";
            this.uxManufacturerPicker.Size = new System.Drawing.Size(159, 24);
            this.uxManufacturerPicker.TabIndex = 56;
            // 
            // uxMSRPLabel
            // 
            this.uxMSRPLabel.AutoSize = true;
            this.uxMSRPLabel.Location = new System.Drawing.Point(101, 201);
            this.uxMSRPLabel.Name = "uxMSRPLabel";
            this.uxMSRPLabel.Size = new System.Drawing.Size(51, 17);
            this.uxMSRPLabel.TabIndex = 55;
            this.uxMSRPLabel.Text = "MSRP:";
            // 
            // uxMSRPBox
            // 
            this.uxMSRPBox.Location = new System.Drawing.Point(158, 198);
            this.uxMSRPBox.Name = "uxMSRPBox";
            this.uxMSRPBox.Size = new System.Drawing.Size(159, 22);
            this.uxMSRPBox.TabIndex = 54;
            // 
            // uxComponentCategoryLabel
            // 
            this.uxComponentCategoryLabel.AutoSize = true;
            this.uxComponentCategoryLabel.Location = new System.Drawing.Point(7, 155);
            this.uxComponentCategoryLabel.Name = "uxComponentCategoryLabel";
            this.uxComponentCategoryLabel.Size = new System.Drawing.Size(145, 17);
            this.uxComponentCategoryLabel.TabIndex = 53;
            this.uxComponentCategoryLabel.Text = "Component Category:";
            // 
            // uxManufacturerLabel
            // 
            this.uxManufacturerLabel.AutoSize = true;
            this.uxManufacturerLabel.Location = new System.Drawing.Point(56, 108);
            this.uxManufacturerLabel.Name = "uxManufacturerLabel";
            this.uxManufacturerLabel.Size = new System.Drawing.Size(96, 17);
            this.uxManufacturerLabel.TabIndex = 51;
            this.uxManufacturerLabel.Text = "Manufacturer:";
            // 
            // uxModelNumberLabel
            // 
            this.uxModelNumberLabel.AutoSize = true;
            this.uxModelNumberLabel.Location = new System.Drawing.Point(48, 65);
            this.uxModelNumberLabel.Name = "uxModelNumberLabel";
            this.uxModelNumberLabel.Size = new System.Drawing.Size(104, 17);
            this.uxModelNumberLabel.TabIndex = 50;
            this.uxModelNumberLabel.Text = "Model Number:";
            // 
            // uxModelNumberBox
            // 
            this.uxModelNumberBox.Location = new System.Drawing.Point(158, 60);
            this.uxModelNumberBox.Name = "uxModelNumberBox";
            this.uxModelNumberBox.Size = new System.Drawing.Size(159, 22);
            this.uxModelNumberBox.TabIndex = 49;
            // 
            // uxComponentNameLabel
            // 
            this.uxComponentNameLabel.AutoSize = true;
            this.uxComponentNameLabel.Location = new System.Drawing.Point(27, 17);
            this.uxComponentNameLabel.Name = "uxComponentNameLabel";
            this.uxComponentNameLabel.Size = new System.Drawing.Size(125, 17);
            this.uxComponentNameLabel.TabIndex = 48;
            this.uxComponentNameLabel.Text = "Component Name:";
            // 
            // uxComponentNameBox
            // 
            this.uxComponentNameBox.Location = new System.Drawing.Point(158, 12);
            this.uxComponentNameBox.Name = "uxComponentNameBox";
            this.uxComponentNameBox.Size = new System.Drawing.Size(159, 22);
            this.uxComponentNameBox.TabIndex = 47;
            // 
            // uxAddComponentButton
            // 
            this.uxAddComponentButton.Location = new System.Drawing.Point(132, 286);
            this.uxAddComponentButton.Name = "uxAddComponentButton";
            this.uxAddComponentButton.Size = new System.Drawing.Size(134, 39);
            this.uxAddComponentButton.TabIndex = 46;
            this.uxAddComponentButton.Text = "Add Component";
            this.uxAddComponentButton.UseVisualStyleBackColor = true;
            this.uxAddComponentButton.Click += new System.EventHandler(this.uxAddComponentButton_Click);
            // 
            // uxComponentCategoryPicker
            // 
            this.uxComponentCategoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComponentCategoryPicker.FormattingEnabled = true;
            this.uxComponentCategoryPicker.Location = new System.Drawing.Point(158, 155);
            this.uxComponentCategoryPicker.Name = "uxComponentCategoryPicker";
            this.uxComponentCategoryPicker.Size = new System.Drawing.Size(159, 24);
            this.uxComponentCategoryPicker.TabIndex = 57;
            // 
            // uxDisplayLabel
            // 
            this.uxDisplayLabel.AutoSize = true;
            this.uxDisplayLabel.Location = new System.Drawing.Point(48, 240);
            this.uxDisplayLabel.Name = "uxDisplayLabel";
            this.uxDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDisplayLabel.TabIndex = 58;
            // 
            // AddComponentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 355);
            this.Controls.Add(this.uxDisplayLabel);
            this.Controls.Add(this.uxComponentCategoryPicker);
            this.Controls.Add(this.uxManufacturerPicker);
            this.Controls.Add(this.uxMSRPLabel);
            this.Controls.Add(this.uxMSRPBox);
            this.Controls.Add(this.uxComponentCategoryLabel);
            this.Controls.Add(this.uxManufacturerLabel);
            this.Controls.Add(this.uxModelNumberLabel);
            this.Controls.Add(this.uxModelNumberBox);
            this.Controls.Add(this.uxComponentNameLabel);
            this.Controls.Add(this.uxComponentNameBox);
            this.Controls.Add(this.uxAddComponentButton);
            this.Name = "AddComponentView";
            this.Text = "Add Component";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxManufacturerPicker;
        private System.Windows.Forms.Label uxMSRPLabel;
        private System.Windows.Forms.TextBox uxMSRPBox;
        private System.Windows.Forms.Label uxComponentCategoryLabel;
        private System.Windows.Forms.Label uxManufacturerLabel;
        private System.Windows.Forms.Label uxModelNumberLabel;
        private System.Windows.Forms.TextBox uxModelNumberBox;
        private System.Windows.Forms.Label uxComponentNameLabel;
        private System.Windows.Forms.TextBox uxComponentNameBox;
        private System.Windows.Forms.Button uxAddComponentButton;
        private System.Windows.Forms.ComboBox uxComponentCategoryPicker;
        private System.Windows.Forms.Label uxDisplayLabel;
    }
}