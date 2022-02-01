namespace FinalProject_MobileMowersCRM.Views
{
    partial class InvoiceScreen
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
            this.DataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.BtnAddNewInvoice = new System.Windows.Forms.Button();
            this.BtnDeleteInvoice = new System.Windows.Forms.Button();
            this.BtnUpdateInvoice = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewInvoices
            // 
            this.DataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInvoices.Location = new System.Drawing.Point(12, 77);
            this.DataGridViewInvoices.Name = "DataGridViewInvoices";
            this.DataGridViewInvoices.RowTemplate.Height = 25;
            this.DataGridViewInvoices.Size = new System.Drawing.Size(776, 297);
            this.DataGridViewInvoices.TabIndex = 2;
            // 
            // BtnAddNewInvoice
            // 
            this.BtnAddNewInvoice.Location = new System.Drawing.Point(12, 393);
            this.BtnAddNewInvoice.Name = "BtnAddNewInvoice";
            this.BtnAddNewInvoice.Size = new System.Drawing.Size(122, 45);
            this.BtnAddNewInvoice.TabIndex = 3;
            this.BtnAddNewInvoice.Text = "Add";
            this.BtnAddNewInvoice.UseVisualStyleBackColor = true;
            this.BtnAddNewInvoice.Click += new System.EventHandler(this.BtnAddNewInvoice_Click);
            // 
            // BtnDeleteInvoice
            // 
            this.BtnDeleteInvoice.Location = new System.Drawing.Point(268, 393);
            this.BtnDeleteInvoice.Name = "BtnDeleteInvoice";
            this.BtnDeleteInvoice.Size = new System.Drawing.Size(122, 45);
            this.BtnDeleteInvoice.TabIndex = 6;
            this.BtnDeleteInvoice.Text = "Delete";
            this.BtnDeleteInvoice.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateInvoice
            // 
            this.BtnUpdateInvoice.Location = new System.Drawing.Point(140, 393);
            this.BtnUpdateInvoice.Name = "BtnUpdateInvoice";
            this.BtnUpdateInvoice.Size = new System.Drawing.Size(122, 45);
            this.BtnUpdateInvoice.TabIndex = 5;
            this.BtnUpdateInvoice.Text = "Update";
            this.BtnUpdateInvoice.UseVisualStyleBackColor = true;
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
            // InvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteInvoice);
            this.Controls.Add(this.BtnUpdateInvoice);
            this.Controls.Add(this.BtnAddNewInvoice);
            this.Controls.Add(this.DataGridViewInvoices);
            this.Controls.Add(this.BtnDashboard);
            this.Name = "InvoiceScreen";
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView DataGridViewInvoices;
        private Button BtnAddNewInvoice;
        private Button BtnDeleteInvoice;
        private Button BtnUpdateInvoice;
        private Button BtnDashboard;
    }
}