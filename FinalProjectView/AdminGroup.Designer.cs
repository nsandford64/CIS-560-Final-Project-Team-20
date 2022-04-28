
namespace FinalProjectView
{
    partial class AdminGroup
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
            this.uxAddComponentButton = new System.Windows.Forms.Button();
            this.uxAddManufacturerButton = new System.Windows.Forms.Button();
            this.uxAddCityButton = new System.Windows.Forms.Button();
            this.uxAddStorefrontButton = new System.Windows.Forms.Button();
            this.uxAddComponentStorefrontButton = new System.Windows.Forms.Button();
            this.uxClientButton = new System.Windows.Forms.Button();
            this.uxUpdateComponentStorefrontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxAddComponentButton
            // 
            this.uxAddComponentButton.Location = new System.Drawing.Point(17, 67);
            this.uxAddComponentButton.Name = "uxAddComponentButton";
            this.uxAddComponentButton.Size = new System.Drawing.Size(176, 167);
            this.uxAddComponentButton.TabIndex = 0;
            this.uxAddComponentButton.Text = "Add Component";
            this.uxAddComponentButton.UseVisualStyleBackColor = true;
            this.uxAddComponentButton.Click += new System.EventHandler(this.uxAddComponentButton_Click);
            // 
            // uxAddManufacturerButton
            // 
            this.uxAddManufacturerButton.Location = new System.Drawing.Point(215, 67);
            this.uxAddManufacturerButton.Name = "uxAddManufacturerButton";
            this.uxAddManufacturerButton.Size = new System.Drawing.Size(176, 167);
            this.uxAddManufacturerButton.TabIndex = 1;
            this.uxAddManufacturerButton.Text = "Add Manufacturer";
            this.uxAddManufacturerButton.UseVisualStyleBackColor = true;
            this.uxAddManufacturerButton.Click += new System.EventHandler(this.uxAddManufacturerButton_Click);
            // 
            // uxAddCityButton
            // 
            this.uxAddCityButton.Location = new System.Drawing.Point(415, 67);
            this.uxAddCityButton.Name = "uxAddCityButton";
            this.uxAddCityButton.Size = new System.Drawing.Size(176, 167);
            this.uxAddCityButton.TabIndex = 2;
            this.uxAddCityButton.Text = "Add City";
            this.uxAddCityButton.UseVisualStyleBackColor = true;
            this.uxAddCityButton.Click += new System.EventHandler(this.uxAddCityButton_Click);
            // 
            // uxAddStorefrontButton
            // 
            this.uxAddStorefrontButton.Location = new System.Drawing.Point(614, 67);
            this.uxAddStorefrontButton.Name = "uxAddStorefrontButton";
            this.uxAddStorefrontButton.Size = new System.Drawing.Size(176, 167);
            this.uxAddStorefrontButton.TabIndex = 3;
            this.uxAddStorefrontButton.Text = "Add Storefront";
            this.uxAddStorefrontButton.UseVisualStyleBackColor = true;
            this.uxAddStorefrontButton.Click += new System.EventHandler(this.uxAddStorefrontButton_Click);
            // 
            // uxAddComponentStorefrontButton
            // 
            this.uxAddComponentStorefrontButton.Location = new System.Drawing.Point(808, 67);
            this.uxAddComponentStorefrontButton.Name = "uxAddComponentStorefrontButton";
            this.uxAddComponentStorefrontButton.Size = new System.Drawing.Size(176, 167);
            this.uxAddComponentStorefrontButton.TabIndex = 4;
            this.uxAddComponentStorefrontButton.Text = "Add Component to a Storefront";
            this.uxAddComponentStorefrontButton.UseVisualStyleBackColor = true;
            this.uxAddComponentStorefrontButton.Click += new System.EventHandler(this.uxAddComponentStorefrontButton_Click);
            // 
            // uxClientButton
            // 
            this.uxClientButton.Location = new System.Drawing.Point(1066, 10);
            this.uxClientButton.Name = "uxClientButton";
            this.uxClientButton.Size = new System.Drawing.Size(112, 51);
            this.uxClientButton.TabIndex = 5;
            this.uxClientButton.Text = "Switch to Client View";
            this.uxClientButton.UseVisualStyleBackColor = true;
            this.uxClientButton.Click += new System.EventHandler(this.uxClientButton_Click);
            // 
            // uxUpdateComponentStorefrontButton
            // 
            this.uxUpdateComponentStorefrontButton.Location = new System.Drawing.Point(1002, 67);
            this.uxUpdateComponentStorefrontButton.Name = "uxUpdateComponentStorefrontButton";
            this.uxUpdateComponentStorefrontButton.Size = new System.Drawing.Size(176, 167);
            this.uxUpdateComponentStorefrontButton.TabIndex = 6;
            this.uxUpdateComponentStorefrontButton.Text = "Update a Component in a Storefront";
            this.uxUpdateComponentStorefrontButton.UseVisualStyleBackColor = true;
            // 
            // AdminGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 246);
            this.Controls.Add(this.uxUpdateComponentStorefrontButton);
            this.Controls.Add(this.uxClientButton);
            this.Controls.Add(this.uxAddComponentStorefrontButton);
            this.Controls.Add(this.uxAddStorefrontButton);
            this.Controls.Add(this.uxAddCityButton);
            this.Controls.Add(this.uxAddManufacturerButton);
            this.Controls.Add(this.uxAddComponentButton);
            this.Name = "AdminGroup";
            this.Text = "AdminGroup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminGroup_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxAddComponentButton;
        private System.Windows.Forms.Button uxAddManufacturerButton;
        private System.Windows.Forms.Button uxAddCityButton;
        private System.Windows.Forms.Button uxAddStorefrontButton;
        private System.Windows.Forms.Button uxAddComponentStorefrontButton;
        private System.Windows.Forms.Button uxClientButton;
        private System.Windows.Forms.Button uxUpdateComponentStorefrontButton;
    }
}