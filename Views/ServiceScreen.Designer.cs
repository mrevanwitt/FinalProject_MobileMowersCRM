﻿namespace FinalProject_MobileMowersCRM.Views
{
    partial class ServiceScreen
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
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.DataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.BtnAddNewCustomer = new System.Windows.Forms.Button();
            this.BtnUpdateCustomer = new System.Windows.Forms.Button();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Location = new System.Drawing.Point(12, 12);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(122, 45);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "<- Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridViewCustomers
            // 
            this.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomers.Location = new System.Drawing.Point(12, 79);
            this.DataGridViewCustomers.Name = "DataGridViewCustomers";
            this.DataGridViewCustomers.RowTemplate.Height = 25;
            this.DataGridViewCustomers.Size = new System.Drawing.Size(776, 297);
            this.DataGridViewCustomers.TabIndex = 1;
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(12, 393);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnAddNewCustomer.TabIndex = 2;
            this.BtnAddNewCustomer.Text = "Add";
            this.BtnAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(140, 393);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnUpdateCustomer.TabIndex = 3;
            this.BtnUpdateCustomer.Text = "Update";
            this.BtnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(268, 393);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnDeleteCustomer.TabIndex = 4;
            this.BtnDeleteCustomer.Text = "Delete";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // ServiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteCustomer);
            this.Controls.Add(this.BtnUpdateCustomer);
            this.Controls.Add(this.BtnAddNewCustomer);
            this.Controls.Add(this.DataGridViewCustomers);
            this.Controls.Add(this.BtnDashboard);
            this.Name = "ServiceScreen";
            this.Text = "ServiceScreen";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnDashboard;
        private DataGridView DataGridViewCustomers;
        private Button BtnAddNewCustomer;
        private Button BtnUpdateCustomer;
        private Button BtnDeleteCustomer;
    }
}