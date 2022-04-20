
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
            this.SuspendLayout();
            // 
            // uxAdminButton
            // 
            this.uxAdminButton.Location = new System.Drawing.Point(986, 12);
            this.uxAdminButton.Name = "uxAdminButton";
            this.uxAdminButton.Size = new System.Drawing.Size(112, 51);
            this.uxAdminButton.TabIndex = 0;
            this.uxAdminButton.Text = "Switch to Admin View";
            this.uxAdminButton.UseVisualStyleBackColor = true;
            this.uxAdminButton.Click += new System.EventHandler(this.uxAdminButton_Click);
            // 
            // uxStatePicker
            // 
            this.uxStatePicker.FormattingEnabled = true;
            this.uxStatePicker.Location = new System.Drawing.Point(92, 26);
            this.uxStatePicker.Name = "uxStatePicker";
            this.uxStatePicker.Size = new System.Drawing.Size(106, 24);
            this.uxStatePicker.TabIndex = 1;
            this.uxStatePicker.VisibleChanged += new System.EventHandler(this.uxStatePicker_VisibleChanged);
            // 
            // uxStateLabel
            // 
            this.uxStateLabel.AutoSize = true;
            this.uxStateLabel.Location = new System.Drawing.Point(42, 29);
            this.uxStateLabel.Name = "uxStateLabel";
            this.uxStateLabel.Size = new System.Drawing.Size(45, 17);
            this.uxStateLabel.TabIndex = 2;
            this.uxStateLabel.Text = "State:";
            // 
            // uxAddressBox
            // 
            this.uxAddressBox.Location = new System.Drawing.Point(92, 69);
            this.uxAddressBox.Name = "uxAddressBox";
            this.uxAddressBox.Size = new System.Drawing.Size(230, 22);
            this.uxAddressBox.TabIndex = 4;
            // 
            // uxAddressLabel
            // 
            this.uxAddressLabel.AutoSize = true;
            this.uxAddressLabel.Location = new System.Drawing.Point(23, 72);
            this.uxAddressLabel.Name = "uxAddressLabel";
            this.uxAddressLabel.Size = new System.Drawing.Size(64, 17);
            this.uxAddressLabel.TabIndex = 5;
            this.uxAddressLabel.Text = "Address:";
            // 
            // uxStorefrontBox
            // 
            this.uxStorefrontBox.Location = new System.Drawing.Point(92, 117);
            this.uxStorefrontBox.Name = "uxStorefrontBox";
            this.uxStorefrontBox.Size = new System.Drawing.Size(230, 22);
            this.uxStorefrontBox.TabIndex = 6;
            // 
            // uxStoreLabel
            // 
            this.uxStoreLabel.AutoSize = true;
            this.uxStoreLabel.Location = new System.Drawing.Point(12, 120);
            this.uxStoreLabel.Name = "uxStoreLabel";
            this.uxStoreLabel.Size = new System.Drawing.Size(75, 17);
            this.uxStoreLabel.TabIndex = 7;
            this.uxStoreLabel.Text = "Storefront:";
            // 
            // uxComponentCategoryPicker
            // 
            this.uxComponentCategoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComponentCategoryPicker.FormattingEnabled = true;
            this.uxComponentCategoryPicker.Location = new System.Drawing.Point(92, 234);
            this.uxComponentCategoryPicker.Name = "uxComponentCategoryPicker";
            this.uxComponentCategoryPicker.Size = new System.Drawing.Size(106, 24);
            this.uxComponentCategoryPicker.TabIndex = 8;
            // 
            // uxComponentNameBox
            // 
            this.uxComponentNameBox.Location = new System.Drawing.Point(92, 286);
            this.uxComponentNameBox.Name = "uxComponentNameBox";
            this.uxComponentNameBox.Size = new System.Drawing.Size(230, 22);
            this.uxComponentNameBox.TabIndex = 9;
            // 
            // uxModelNumberBox
            // 
            this.uxModelNumberBox.Location = new System.Drawing.Point(92, 331);
            this.uxModelNumberBox.Name = "uxModelNumberBox";
            this.uxModelNumberBox.Size = new System.Drawing.Size(230, 22);
            this.uxModelNumberBox.TabIndex = 10;
            // 
            // uxComponentCategoryLabel
            // 
            this.uxComponentCategoryLabel.AutoSize = true;
            this.uxComponentCategoryLabel.Location = new System.Drawing.Point(18, 237);
            this.uxComponentCategoryLabel.Name = "uxComponentCategoryLabel";
            this.uxComponentCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.uxComponentCategoryLabel.TabIndex = 11;
            this.uxComponentCategoryLabel.Text = "Category:";
            // 
            // uxComponentNameLabel
            // 
            this.uxComponentNameLabel.AutoSize = true;
            this.uxComponentNameLabel.Location = new System.Drawing.Point(38, 289);
            this.uxComponentNameLabel.Name = "uxComponentNameLabel";
            this.uxComponentNameLabel.Size = new System.Drawing.Size(49, 17);
            this.uxComponentNameLabel.TabIndex = 12;
            this.uxComponentNameLabel.Text = "Name:";
            // 
            // uxModelNumberLabel
            // 
            this.uxModelNumberLabel.AutoSize = true;
            this.uxModelNumberLabel.Location = new System.Drawing.Point(10, 334);
            this.uxModelNumberLabel.Name = "uxModelNumberLabel";
            this.uxModelNumberLabel.Size = new System.Drawing.Size(76, 17);
            this.uxModelNumberLabel.TabIndex = 13;
            this.uxModelNumberLabel.Text = "Model No.:";
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(92, 374);
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
            this.uxResultsBox.Location = new System.Drawing.Point(344, 26);
            this.uxResultsBox.Name = "uxResultsBox";
            this.uxResultsBox.Size = new System.Drawing.Size(618, 399);
            this.uxResultsBox.TabIndex = 15;
            this.uxResultsBox.UseCompatibleStateImageBehavior = false;
            this.uxResultsBox.View = System.Windows.Forms.View.Details;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 449);
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
    }
}

