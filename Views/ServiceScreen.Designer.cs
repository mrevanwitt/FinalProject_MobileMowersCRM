namespace FinalProject_MobileMowersCRM.Views
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
            this.DataGridViewServices = new System.Windows.Forms.DataGridView();
            this.BtnAddNewService = new System.Windows.Forms.Button();
            this.BtnUpdateService = new System.Windows.Forms.Button();
            this.BtnDeleteService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewServices)).BeginInit();
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
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // DataGridViewServices
            // 
            this.DataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewServices.Location = new System.Drawing.Point(12, 79);
            this.DataGridViewServices.Name = "DataGridViewServices";
            this.DataGridViewServices.RowTemplate.Height = 25;
            this.DataGridViewServices.Size = new System.Drawing.Size(776, 297);
            this.DataGridViewServices.TabIndex = 1;
            // 
            // BtnAddNewService
            // 
            this.BtnAddNewService.Location = new System.Drawing.Point(12, 393);
            this.BtnAddNewService.Name = "BtnAddNewService";
            this.BtnAddNewService.Size = new System.Drawing.Size(122, 45);
            this.BtnAddNewService.TabIndex = 2;
            this.BtnAddNewService.Text = "Add";
            this.BtnAddNewService.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateService
            // 
            this.BtnUpdateService.Location = new System.Drawing.Point(140, 393);
            this.BtnUpdateService.Name = "BtnUpdateService";
            this.BtnUpdateService.Size = new System.Drawing.Size(122, 45);
            this.BtnUpdateService.TabIndex = 3;
            this.BtnUpdateService.Text = "Update";
            this.BtnUpdateService.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteService
            // 
            this.BtnDeleteService.Location = new System.Drawing.Point(268, 393);
            this.BtnDeleteService.Name = "BtnDeleteService";
            this.BtnDeleteService.Size = new System.Drawing.Size(122, 45);
            this.BtnDeleteService.TabIndex = 4;
            this.BtnDeleteService.Text = "Delete";
            this.BtnDeleteService.UseVisualStyleBackColor = true;
            // 
            // ServiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteService);
            this.Controls.Add(this.BtnUpdateService);
            this.Controls.Add(this.BtnAddNewService);
            this.Controls.Add(this.DataGridViewServices);
            this.Controls.Add(this.BtnDashboard);
            this.Name = "ServiceScreen";
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnDashboard;
        private DataGridView DataGridViewServices;
        private Button BtnAddNewService;
        private Button BtnUpdateService;
        private Button BtnDeleteService;
    }
}