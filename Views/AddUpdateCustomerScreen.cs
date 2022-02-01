﻿using FinalProject_MobileMowersCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_MobileMowersCRM.Views
{
    public partial class AddUpdateCustomerScreen : Form
    {
        private AppController _appController;

        private bool _firstNameValidation;
        private bool _lastNameValidation;
        private bool _phoneValidation;
        private bool _emailValidation;
        private bool _address1Validation;
        private bool _cityValidation;
        private bool _stateValidation;
        private bool _areaCodeValidation;

        public AddUpdateCustomerScreen(AppController appController)
        {
            _appController = appController;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e) 
        { 
            base.OnShown(e);
        }

        private void AddUpdateCustomerScreen_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                var customer = new Customer()
                {
                    FirstName = TxtBoxFirstName.Text,
                    LastName = TxtBoxLastName.Text,
                    PhoneNumber = Convert.ToInt32(TxtBoxPhone.Text),
                    Email = TxtBoxEmail.Text,
                    Address1 = TxtBoxAddress1.Text,
                    Address2 = TxtBoxAddress2.Text,
                    City = TxtBoxCity.Text,
                    State = TxtBoxState.Text,
                    AreaCode = Convert.ToInt32(TxtBoxAreaCode.Text)
                };
                _appController.AddNewCustomer(customer);
                CleanUp();
            }
            else
            {
                SetTextBoxesRedIfEmpty();
                MessageBox.Show("Plesae fill out the required feilds.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CleanUp();
        }

        public bool CheckValidation()
        {
            if (_firstNameValidation && 
                _lastNameValidation && 
                _phoneValidation && 
                _emailValidation &&
                _address1Validation &&
                _cityValidation &&
                _stateValidation &&
                _areaCodeValidation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearFields()
        {
            TxtBoxFirstName.Text = string.Empty;
            TxtBoxLastName.Text = string.Empty;
            TxtBoxPhone.Text = string.Empty;
            TxtBoxEmail.Text = string.Empty;
            TxtBoxAddress1.Text = string.Empty;
            TxtBoxAddress2.Text = string.Empty;
            TxtBoxCity.Text = string.Empty;
            TxtBoxState.Text = string.Empty;
            TxtBoxAreaCode.Text = string.Empty;
        }

        public void SetTextBoxesRedIfEmpty()
        {
            if (TxtBoxFirstName.Text == string.Empty) TxtBoxFirstName.BackColor = Color.Red;
            if (TxtBoxLastName.Text == string.Empty) TxtBoxLastName.BackColor = Color.Red;
            if (TxtBoxPhone.Text == string.Empty) TxtBoxPhone.BackColor = Color.Red;
            if (TxtBoxEmail.Text == string.Empty) TxtBoxEmail.BackColor = Color.Red;
            if (TxtBoxAddress1.Text == string.Empty) TxtBoxAddress1.BackColor = Color.Red;
            if (TxtBoxCity.Text == string.Empty) TxtBoxCity.BackColor = Color.Red;
            if (TxtBoxState.Text == string.Empty) TxtBoxState.BackColor = Color.Red;
            if (TxtBoxAreaCode.Text == string.Empty) TxtBoxAreaCode.BackColor = Color.Red;
        }

        private void TxtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            _firstNameValidation = ValidateText(TxtBoxFirstName);
        }

        private void TxtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            _lastNameValidation = ValidateText(TxtBoxLastName);
        }

        private void TxtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            _phoneValidation = ValidateText(TxtBoxPhone);
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBoxPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TxtBoxPhone.Text = TxtBoxPhone.Text.Remove(TxtBoxPhone.Text.Length - 1);
            }
        }

        private void TxtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            _emailValidation = ValidateText(TxtBoxEmail);
        }

        private void TxtBoxAddress1_TextChanged(object sender, EventArgs e)
        {
            _address1Validation = ValidateText(TxtBoxAddress1);
        }

        private void TxtBoxCity_TextChanged(object sender, EventArgs e)
        {
            _cityValidation = ValidateText(TxtBoxCity);
        }

        private void TxtBoxState_TextChanged(object sender, EventArgs e)
        {
            _stateValidation = ValidateText(TxtBoxState);
        }

        private void TxtBoxAreaCode_TextChanged(object sender, EventArgs e)
        {
            _areaCodeValidation = ValidateText(TxtBoxAreaCode);
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBoxAreaCode.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TxtBoxAreaCode.Text = TxtBoxAreaCode.Text.Remove(TxtBoxAreaCode.Text.Length - 1);
            }
        }

        private bool ValidateText(TextBox textBox)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                return true;
            }
        }

        public void CleanUp()
        {
            ClearFields();
            Hide();
            _appController.LoadCustomerScreen();
        }
    }
}
