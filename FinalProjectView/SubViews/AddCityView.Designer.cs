
namespace FinalProjectView.SubViews
{
    partial class AddCityView
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
            this.uxCityStatePicker = new System.Windows.Forms.ComboBox();
            this.uxStateNameLabel = new System.Windows.Forms.Label();
            this.uxCityNameLabel = new System.Windows.Forms.Label();
            this.uxCityNameBox = new System.Windows.Forms.TextBox();
            this.uxAddCityButton = new System.Windows.Forms.Button();
            this.uxDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxCityStatePicker
            // 
            this.uxCityStatePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCityStatePicker.FormattingEnabled = true;
            this.uxCityStatePicker.Location = new System.Drawing.Point(145, 66);
            this.uxCityStatePicker.Name = "uxCityStatePicker";
            this.uxCityStatePicker.Size = new System.Drawing.Size(194, 24);
            this.uxCityStatePicker.TabIndex = 51;
            // 
            // uxStateNameLabel
            // 
            this.uxStateNameLabel.AutoSize = true;
            this.uxStateNameLabel.Location = new System.Drawing.Point(41, 73);
            this.uxStateNameLabel.Name = "uxStateNameLabel";
            this.uxStateNameLabel.Size = new System.Drawing.Size(86, 17);
            this.uxStateNameLabel.TabIndex = 50;
            this.uxStateNameLabel.Text = "State Name:";
            // 
            // uxCityNameLabel
            // 
            this.uxCityNameLabel.AutoSize = true;
            this.uxCityNameLabel.Location = new System.Drawing.Point(51, 26);
            this.uxCityNameLabel.Name = "uxCityNameLabel";
            this.uxCityNameLabel.Size = new System.Drawing.Size(76, 17);
            this.uxCityNameLabel.TabIndex = 49;
            this.uxCityNameLabel.Text = "City Name:";
            // 
            // uxCityNameBox
            // 
            this.uxCityNameBox.Location = new System.Drawing.Point(145, 21);
            this.uxCityNameBox.Name = "uxCityNameBox";
            this.uxCityNameBox.Size = new System.Drawing.Size(194, 22);
            this.uxCityNameBox.TabIndex = 48;
            // 
            // uxAddCityButton
            // 
            this.uxAddCityButton.Location = new System.Drawing.Point(135, 161);
            this.uxAddCityButton.Name = "uxAddCityButton";
            this.uxAddCityButton.Size = new System.Drawing.Size(134, 39);
            this.uxAddCityButton.TabIndex = 47;
            this.uxAddCityButton.Text = "Add City";
            this.uxAddCityButton.UseVisualStyleBackColor = true;
            this.uxAddCityButton.Click += new System.EventHandler(this.uxAddCityButton_Click);
            // 
            // uxDisplayLabel
            // 
            this.uxDisplayLabel.AutoSize = true;
            this.uxDisplayLabel.Location = new System.Drawing.Point(69, 124);
            this.uxDisplayLabel.Name = "uxDisplayLabel";
            this.uxDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDisplayLabel.TabIndex = 52;
            // 
            // AddCityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 212);
            this.Controls.Add(this.uxDisplayLabel);
            this.Controls.Add(this.uxCityStatePicker);
            this.Controls.Add(this.uxStateNameLabel);
            this.Controls.Add(this.uxCityNameLabel);
            this.Controls.Add(this.uxCityNameBox);
            this.Controls.Add(this.uxAddCityButton);
            this.Name = "AddCityView";
            this.Text = "AddCityView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxCityStatePicker;
        private System.Windows.Forms.Label uxStateNameLabel;
        private System.Windows.Forms.Label uxCityNameLabel;
        private System.Windows.Forms.TextBox uxCityNameBox;
        private System.Windows.Forms.Button uxAddCityButton;
        private System.Windows.Forms.Label uxDisplayLabel;
    }
}