namespace FinalProject_MobileMowersCRM.Views
{
    partial class ReportScreen
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
            this.DataGridViewReports = new System.Windows.Forms.DataGridView();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnAllPaidInvoices = new System.Windows.Forms.Button();
            this.BtnAllInvoicesByCustomer = new System.Windows.Forms.Button();
            this.BtnAllUnpaidInvoices = new System.Windows.Forms.Button();
            this.DropDownCustomerFirstNames = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewReports
            // 
            this.DataGridViewReports.AllowUserToAddRows = false;
            this.DataGridViewReports.AllowUserToDeleteRows = false;
            this.DataGridViewReports.AllowUserToResizeRows = false;
            this.DataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReports.Location = new System.Drawing.Point(12, 105);
            this.DataGridViewReports.MultiSelect = false;
            this.DataGridViewReports.Name = "DataGridViewReports";
            this.DataGridViewReports.ReadOnly = true;
            this.DataGridViewReports.RowHeadersVisible = false;
            this.DataGridViewReports.RowTemplate.Height = 25;
            this.DataGridViewReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewReports.Size = new System.Drawing.Size(784, 297);
            this.DataGridViewReports.TabIndex = 9;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Location = new System.Drawing.Point(12, 12);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(122, 45);
            this.BtnDashboard.TabIndex = 8;
            this.BtnDashboard.Text = "<- Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnAllPaidInvoices
            // 
            this.BtnAllPaidInvoices.Location = new System.Drawing.Point(538, 12);
            this.BtnAllPaidInvoices.Name = "BtnAllPaidInvoices";
            this.BtnAllPaidInvoices.Size = new System.Drawing.Size(122, 45);
            this.BtnAllPaidInvoices.TabIndex = 33;
            this.BtnAllPaidInvoices.Text = "All Paid Invoices";
            this.BtnAllPaidInvoices.UseVisualStyleBackColor = true;
            this.BtnAllPaidInvoices.Click += new System.EventHandler(this.BtnAllPaidInvoices_Click);
            // 
            // BtnAllInvoicesByCustomer
            // 
            this.BtnAllInvoicesByCustomer.Location = new System.Drawing.Point(666, 12);
            this.BtnAllInvoicesByCustomer.Name = "BtnAllInvoicesByCustomer";
            this.BtnAllInvoicesByCustomer.Size = new System.Drawing.Size(122, 45);
            this.BtnAllInvoicesByCustomer.TabIndex = 34;
            this.BtnAllInvoicesByCustomer.Text = "Invoices by Customer";
            this.BtnAllInvoicesByCustomer.UseVisualStyleBackColor = true;
            this.BtnAllInvoicesByCustomer.Click += new System.EventHandler(this.BtnAllInvoicesByCustomer_Click);
            // 
            // BtnAllUnpaidInvoices
            // 
            this.BtnAllUnpaidInvoices.Location = new System.Drawing.Point(410, 12);
            this.BtnAllUnpaidInvoices.Name = "BtnAllUnpaidInvoices";
            this.BtnAllUnpaidInvoices.Size = new System.Drawing.Size(122, 45);
            this.BtnAllUnpaidInvoices.TabIndex = 35;
            this.BtnAllUnpaidInvoices.Text = "All Unpaid Invoices";
            this.BtnAllUnpaidInvoices.UseVisualStyleBackColor = true;
            this.BtnAllUnpaidInvoices.Click += new System.EventHandler(this.BtnAllUnpaidInvoices_Click);
            // 
            // DropDownCustomerFirstNames
            // 
            this.DropDownCustomerFirstNames.FormattingEnabled = true;
            this.DropDownCustomerFirstNames.Location = new System.Drawing.Point(666, 63);
            this.DropDownCustomerFirstNames.Name = "DropDownCustomerFirstNames";
            this.DropDownCustomerFirstNames.Size = new System.Drawing.Size(121, 23);
            this.DropDownCustomerFirstNames.TabIndex = 36;
            this.DropDownCustomerFirstNames.SelectedIndexChanged += new System.EventHandler(this.DropDownCustomerFirstNames_SelectedIndexChanged);
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 412);
            this.Controls.Add(this.DropDownCustomerFirstNames);
            this.Controls.Add(this.BtnAllUnpaidInvoices);
            this.Controls.Add(this.BtnAllInvoicesByCustomer);
            this.Controls.Add(this.BtnAllPaidInvoices);
            this.Controls.Add(this.DataGridViewReports);
            this.Controls.Add(this.BtnDashboard);
            this.Name = "ReportScreen";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridViewReports;
        private Button BtnDashboard;
        private Button BtnAllPaidInvoices;
        private Button BtnAllInvoicesByCustomer;
        private Button BtnAllUnpaidInvoices;
        private ComboBox DropDownCustomerFirstNames;
    }
}