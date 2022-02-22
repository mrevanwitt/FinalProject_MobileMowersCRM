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
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.BtnUpdateCustomer = new System.Windows.Forms.Button();
            this.BtnAddNewCustomer = new System.Windows.Forms.Button();
            this.DataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.TextBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.BtnSearchCustomer = new System.Windows.Forms.Button();
            this.BtnResetSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Location = new System.Drawing.Point(12, 12);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(122, 45);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "<- Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(268, 393);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnDeleteCustomer.TabIndex = 10;
            this.BtnDeleteCustomer.Text = "Delete";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = true;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(140, 393);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnUpdateCustomer.TabIndex = 9;
            this.BtnUpdateCustomer.Text = "Update";
            this.BtnUpdateCustomer.UseVisualStyleBackColor = true;
            this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(12, 393);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnAddNewCustomer.TabIndex = 8;
            this.BtnAddNewCustomer.Text = "Add";
            this.BtnAddNewCustomer.UseVisualStyleBackColor = true;
            this.BtnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
            // 
            // DataGridViewCustomers
            // 
            this.DataGridViewCustomers.AllowUserToDeleteRows = false;
            this.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomers.Location = new System.Drawing.Point(12, 63);
            this.DataGridViewCustomers.MultiSelect = false;
            this.DataGridViewCustomers.Name = "DataGridViewCustomers";
            this.DataGridViewCustomers.RowHeadersVisible = false;
            this.DataGridViewCustomers.RowTemplate.Height = 25;
            this.DataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCustomers.Size = new System.Drawing.Size(776, 314);
            this.DataGridViewCustomers.TabIndex = 7;
            // 
            // TextBoxSearchCustomer
            // 
            this.TextBoxSearchCustomer.Location = new System.Drawing.Point(442, 12);
            this.TextBoxSearchCustomer.Name = "TextBoxSearchCustomer";
            this.TextBoxSearchCustomer.Size = new System.Drawing.Size(184, 23);
            this.TextBoxSearchCustomer.TabIndex = 11;
            // 
            // BtnSearchCustomer
            // 
            this.BtnSearchCustomer.Location = new System.Drawing.Point(632, 11);
            this.BtnSearchCustomer.Name = "BtnSearchCustomer";
            this.BtnSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchCustomer.TabIndex = 12;
            this.BtnSearchCustomer.Text = "Search";
            this.BtnSearchCustomer.UseVisualStyleBackColor = true;
            this.BtnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
            // 
            // BtnResetSearch
            // 
            this.BtnResetSearch.Location = new System.Drawing.Point(713, 12);
            this.BtnResetSearch.Name = "BtnResetSearch";
            this.BtnResetSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnResetSearch.TabIndex = 13;
            this.BtnResetSearch.Text = "Reset";
            this.BtnResetSearch.UseVisualStyleBackColor = true;
            this.BtnResetSearch.Click += new System.EventHandler(this.BtnResetSearch_Click);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnResetSearch);
            this.Controls.Add(this.BtnSearchCustomer);
            this.Controls.Add(this.TextBoxSearchCustomer);
            this.Controls.Add(this.BtnDeleteCustomer);
            this.Controls.Add(this.BtnUpdateCustomer);
            this.Controls.Add(this.BtnAddNewCustomer);
            this.Controls.Add(this.DataGridViewCustomers);
            this.Controls.Add(this.BtnDashboard);
            this.Name = "CustomerScreen";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnDashboard;
        private Button BtnDeleteCustomer;
        private Button BtnUpdateCustomer;
        private Button BtnAddNewCustomer;
        private DataGridView DataGridViewCustomers;
        private TextBox TextBoxSearchCustomer;
        private Button BtnSearchCustomer;
        private Button BtnResetSearch;
    }
}