﻿namespace FinalProject_MobileMowersCRM
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
            this.BtnInvoices = new System.Windows.Forms.Button();
            this.BtnServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoadCustomerScreen
            // 
            this.BtnLoadCustomerScreen.Location = new System.Drawing.Point(92, 12);
            this.BtnLoadCustomerScreen.Name = "BtnLoadCustomerScreen";
            this.BtnLoadCustomerScreen.Size = new System.Drawing.Size(122, 45);
            this.BtnLoadCustomerScreen.TabIndex = 0;
            this.BtnLoadCustomerScreen.Text = "Customers";
            this.BtnLoadCustomerScreen.UseVisualStyleBackColor = true;
            this.BtnLoadCustomerScreen.Click += new System.EventHandler(this.BtnLoadCustomerScreen_Click);
            // 
            // BtnInvoices
            // 
            this.BtnInvoices.Location = new System.Drawing.Point(92, 63);
            this.BtnInvoices.Name = "BtnInvoices";
            this.BtnInvoices.Size = new System.Drawing.Size(122, 45);
            this.BtnInvoices.TabIndex = 1;
            this.BtnInvoices.Text = "Invoices";
            this.BtnInvoices.UseVisualStyleBackColor = true;
            this.BtnInvoices.Click += new System.EventHandler(this.BtnInvoices_Click);
            // 
            // BtnServices
            // 
            this.BtnServices.Location = new System.Drawing.Point(92, 114);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(122, 45);
            this.BtnServices.TabIndex = 2;
            this.BtnServices.Text = "Services";
            this.BtnServices.UseVisualStyleBackColor = true;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 223);
            this.Controls.Add(this.BtnServices);
            this.Controls.Add(this.BtnInvoices);
            this.Controls.Add(this.BtnLoadCustomerScreen);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnLoadCustomerScreen;
        private Button BtnInvoices;
        private Button BtnServices;
    }
}