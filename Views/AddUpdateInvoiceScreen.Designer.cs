﻿namespace FinalProject_MobileMowersCRM.Views
{
    partial class AddUpdateInvoiceScreen
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
            this.DropDownCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddNewInvoice = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CheckBoxHasPaid = new System.Windows.Forms.CheckBox();
            this.TextBoxDateCreated = new System.Windows.Forms.TextBox();
            this.TextBoxDatePaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropDownCustomers
            // 
            this.DropDownCustomers.FormattingEnabled = true;
            this.DropDownCustomers.Location = new System.Drawing.Point(184, 97);
            this.DropDownCustomers.Name = "DropDownCustomers";
            this.DropDownCustomers.Size = new System.Drawing.Size(121, 23);
            this.DropDownCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // TextBoxTotalAmount
            // 
            this.TextBoxTotalAmount.Enabled = false;
            this.TextBoxTotalAmount.Location = new System.Drawing.Point(240, 504);
            this.TextBoxTotalAmount.Name = "TextBoxTotalAmount";
            this.TextBoxTotalAmount.Size = new System.Drawing.Size(65, 23);
            this.TextBoxTotalAmount.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total";
            // 
            // BtnAddNewInvoice
            // 
            this.BtnAddNewInvoice.Location = new System.Drawing.Point(33, 598);
            this.BtnAddNewInvoice.Name = "BtnAddNewInvoice";
            this.BtnAddNewInvoice.Size = new System.Drawing.Size(122, 45);
            this.BtnAddNewInvoice.TabIndex = 32;
            this.BtnAddNewInvoice.Text = "Add";
            this.BtnAddNewInvoice.UseVisualStyleBackColor = true;
            this.BtnAddNewInvoice.Click += new System.EventHandler(this.BtnAddNewInvoice_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(183, 598);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(122, 45);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CheckBoxHasPaid
            // 
            this.CheckBoxHasPaid.AutoSize = true;
            this.CheckBoxHasPaid.Location = new System.Drawing.Point(33, 548);
            this.CheckBoxHasPaid.Name = "CheckBoxHasPaid";
            this.CheckBoxHasPaid.Size = new System.Drawing.Size(72, 19);
            this.CheckBoxHasPaid.TabIndex = 34;
            this.CheckBoxHasPaid.Text = "Has Paid";
            this.CheckBoxHasPaid.UseVisualStyleBackColor = true;
            // 
            // TextBoxDateCreated
            // 
            this.TextBoxDateCreated.Enabled = false;
            this.TextBoxDateCreated.Location = new System.Drawing.Point(161, 12);
            this.TextBoxDateCreated.Name = "TextBoxDateCreated";
            this.TextBoxDateCreated.Size = new System.Drawing.Size(144, 23);
            this.TextBoxDateCreated.TabIndex = 35;
            // 
            // TextBoxDatePaid
            // 
            this.TextBoxDatePaid.Enabled = false;
            this.TextBoxDatePaid.Location = new System.Drawing.Point(161, 52);
            this.TextBoxDatePaid.Name = "TextBoxDatePaid";
            this.TextBoxDatePaid.Size = new System.Drawing.Size(144, 23);
            this.TextBoxDatePaid.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date Created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Date Paid";
            // 
            // AddUpdateInvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxDatePaid);
            this.Controls.Add(this.TextBoxDateCreated);
            this.Controls.Add(this.CheckBoxHasPaid);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddNewInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DropDownCustomers);
            this.Name = "AddUpdateInvoiceScreen";
            this.Text = "AddUpdateInvoiceScreen";
            this.Load += new System.EventHandler(this.AddUpdateInvoiceScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox DropDownCustomers;
        private Label label1;
        private CheckBox CheckBoxBladeSharpen;
        private CheckBox CheckBoxOilChange;
        private CheckBox CheckBoxCleanSparkPlug;
        private CheckBox CheckBoxReplaceSparkPlug;
        private CheckBox CheckBoxCleanAirFilter;
        private CheckBox CheckBoxReplaceAirFilter;
        private CheckBox CheckBoxCleanUndercarriage;
        private CheckBox CheckBoxCleanEngine;
        private CheckBox CheckBoxCleanCarburetor;
        private Label LblReplaceAirFilter;
        private Label LblCleanAirFilter;
        private Label LblReplaceSparkPlug;
        private Label LblCleanSparkPlug;
        private Label LblOilChange;
        private Label LblBladeSharpening;
        private Label LblCleanUndercarriage;
        private Label LblCleanEngine;
        private Label LblCleanCarburetor;
        private TextBox TextBoxTotalAmount;
        private Label label3;
        private Button BtnAddNewInvoice;
        private Button BtnCancel;
        private CheckBox CheckBoxHasPaid;
        private TextBox TextBoxDateCreated;
        private TextBox TextBoxDatePaid;
        private Label label2;
        private Label label4;
    }
}