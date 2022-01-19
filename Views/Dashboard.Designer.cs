namespace FinalProject_MobileMowersCRM
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoadCustomerScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoadCustomerScreen
            // 
            this.BtnLoadCustomerScreen.Location = new System.Drawing.Point(59, 61);
            this.BtnLoadCustomerScreen.Name = "BtnLoadCustomerScreen";
            this.BtnLoadCustomerScreen.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadCustomerScreen.TabIndex = 0;
            this.BtnLoadCustomerScreen.Text = "Customers";
            this.BtnLoadCustomerScreen.UseVisualStyleBackColor = true;
            this.BtnLoadCustomerScreen.Click += new System.EventHandler(this.BtnLoadCustomerScreen_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLoadCustomerScreen);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnLoadCustomerScreen;
    }
}