
namespace FinalProjectView
{
    partial class AdminView
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
            this.uxClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxClientButton
            // 
            this.uxClientButton.Location = new System.Drawing.Point(676, 12);
            this.uxClientButton.Name = "uxClientButton";
            this.uxClientButton.Size = new System.Drawing.Size(112, 51);
            this.uxClientButton.TabIndex = 1;
            this.uxClientButton.Text = "Switch to Client View";
            this.uxClientButton.UseVisualStyleBackColor = true;
            this.uxClientButton.Click += new System.EventHandler(this.uxClientButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxClientButton);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxClientButton;
    }
}