namespace FinalProject_MobileMowersCRM.Views
{
    partial class CustomerScreen
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
            this.BtnDashboardScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDashboardScreen
            // 
            this.BtnDashboardScreen.Location = new System.Drawing.Point(63, 59);
            this.BtnDashboardScreen.Name = "BtnDashboardScreen";
            this.BtnDashboardScreen.Size = new System.Drawing.Size(75, 23);
            this.BtnDashboardScreen.TabIndex = 0;
            this.BtnDashboardScreen.Text = "Dashboard";
            this.BtnDashboardScreen.UseVisualStyleBackColor = true;
            this.BtnDashboardScreen.Click += new System.EventHandler(this.BtnDashboardScreen_Click);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDashboardScreen);
            this.Name = "CustomerScreen";
            this.Text = "Customers";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnDashboardScreen;
    }
}