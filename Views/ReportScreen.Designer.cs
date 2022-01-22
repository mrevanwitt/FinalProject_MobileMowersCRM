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
            this.DataGridViewReport = new System.Windows.Forms.DataGridView();
            this.BtnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewReport
            // 
            this.DataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReport.Location = new System.Drawing.Point(12, 77);
            this.DataGridViewReport.Name = "DataGridViewReport";
            this.DataGridViewReport.RowTemplate.Height = 25;
            this.DataGridViewReport.Size = new System.Drawing.Size(776, 297);
            this.DataGridViewReport.TabIndex = 9;
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
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.DataGridViewReport);
            this.Controls.Add(this.BtnDashboard);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridViewReport;
        private Button BtnDashboard;
    }
}