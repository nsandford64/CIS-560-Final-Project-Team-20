
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
            this.uxAddComponentButton = new System.Windows.Forms.Button();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.uxComponentNameBox = new System.Windows.Forms.TextBox();
            this.uxComponentNameLabel = new System.Windows.Forms.Label();
            this.uxModelNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // uxAddComponentButton
            // 
            this.uxAddComponentButton.Location = new System.Drawing.Point(29, 24);
            this.uxAddComponentButton.Name = "uxAddComponentButton";
            this.uxAddComponentButton.Size = new System.Drawing.Size(134, 39);
            this.uxAddComponentButton.TabIndex = 2;
            this.uxAddComponentButton.Text = "Add Component";
            this.uxAddComponentButton.UseVisualStyleBackColor = true;
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Location = new System.Drawing.Point(695, 400);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(93, 38);
            this.uxSubmitButton.TabIndex = 3;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxComponentNameBox
            // 
            this.uxComponentNameBox.Location = new System.Drawing.Point(161, 102);
            this.uxComponentNameBox.Name = "uxComponentNameBox";
            this.uxComponentNameBox.Size = new System.Drawing.Size(100, 22);
            this.uxComponentNameBox.TabIndex = 4;
            // 
            // uxComponentNameLabel
            // 
            this.uxComponentNameLabel.AutoSize = true;
            this.uxComponentNameLabel.Location = new System.Drawing.Point(30, 102);
            this.uxComponentNameLabel.Name = "uxComponentNameLabel";
            this.uxComponentNameLabel.Size = new System.Drawing.Size(125, 17);
            this.uxComponentNameLabel.TabIndex = 5;
            this.uxComponentNameLabel.Text = "Component Name:";
            // 
            // uxModelNumberLabel
            // 
            this.uxModelNumberLabel.AutoSize = true;
            this.uxModelNumberLabel.Location = new System.Drawing.Point(30, 150);
            this.uxModelNumberLabel.Name = "uxModelNumberLabel";
            this.uxModelNumberLabel.Size = new System.Drawing.Size(104, 17);
            this.uxModelNumberLabel.TabIndex = 7;
            this.uxModelNumberLabel.Text = "Model Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxModelNumberLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxComponentNameLabel);
            this.Controls.Add(this.uxComponentNameBox);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.uxAddComponentButton);
            this.Controls.Add(this.uxClientButton);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxClientButton;
        private System.Windows.Forms.Button uxAddComponentButton;
        private System.Windows.Forms.Button uxSubmitButton;
        private System.Windows.Forms.TextBox uxComponentNameBox;
        private System.Windows.Forms.Label uxComponentNameLabel;
        private System.Windows.Forms.Label uxModelNumberLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}