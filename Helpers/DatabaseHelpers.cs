using FinalProject_MobileMowersCRM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Helpers
{
    public class DatabaseHelpers
    {
        private SQLiteConnection db;

        public void ConnectDatabase()
        {
            db = new SQLiteConnection("Data Source=AppData.db");
            db.CreateTables<Customer, Invoice, Service, ServiceToInvoice>();            
        }

        #region Customer

        public void AddCusomter(Customer customer)
        {
            db.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            db.Update(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            db.Delete(customer);
        }

        public Customer GetCustomerByCustomerId(int customerId)
        {
            string query = $"SELECT * FROM Customer WHERE Customer.CustomerId = {customerId}";
            return db.Query<Customer>(query).FirstOrDefault();
        }

        public List<Customer> GetAllCustomers()
        {
            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Customer>(db);
        }

        public Task<List<Customer>> GetCustomersBySearch(string searchText)
        {
            string query = $"SELECT * FROM Customer WHERE Customer.FirstName like '%{searchText}%' OR Customer.LastName like '%{searchText}%'";
            return Task.FromResult(db.Query<Customer>(query).ToList());
        }

        #endregion

        #region Service


        public List<Service> GetAllServices()
        {
            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Service>(db);
        }

        public Task<List<ServiceToInvoice>> GetAllServicesByInvoiceId(int invoiceId)
        {
            string query = $"SELECT * FROM ServiceToInvoice WHERE InvoiceId = {invoiceId}";
            return Task.FromResult(db.Query<ServiceToInvoice>(query).ToList());
        }

        #endregion

        #region Invoice

        public void AddInvoice(Invoice invoice)
        {
            db.Insert(invoice);
        }

        public void UpdateInvoice(Invoice invoice)
        {
            db.Update(invoice);
        }

        public Invoice GetInvoiceByInvoiceId(int invoiceId)
        {
            string query = $"SELECT * FROM Invoice WHERE Invoice.InvoiceId = {invoiceId}";
            return db.Query<Invoice>(query).FirstOrDefault();
        }

        public List<Invoice> GetAllInvoices()
        {
            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Invoice>(db);
        }

        public void DeleteInvoice(Invoice invoice)
        {
            db.Delete(invoice);
        }

        public void DeleteInvoicesByCustomerId(int customerId)
        {
            var query = $"DELETE FROM Invoice WHERE Invoice.CustomerId = {customerId}";
            db.Execute(query);
        }
        #endregion

        #region Service To Invoice

        public void AddServiceToInvoice(ServiceToInvoice serviceToInvoice)
        {
            db.Insert(serviceToInvoice);
        }

        public void DeleteAllServiceToInvoicesByInvoiceId(int invoiceId)
        {
            string query = $"DELETE FROM ServiceToInvoice WHERE ServiceToInvoice.InvoiceId = {invoiceId}";
            db.Execute(query);
        }

        #endregion

        #region User

        public string GetSaltByUsername(string username)
        {
            string query = $"SELECT Salt FROM User WHERE User.Username = '{username}'";
            var result = db.QueryScalars<string>(query).FirstOrDefault();
            if (result == null)
            {
                return string.Empty;
            }
            else
            {
                return result;
            }

        }

        public string GetPasswordByUsername(string username)
        {
            string query = $"SELECT Password FROM User WHERE User.Username = '{username}'";
            return db.QueryScalars<string>(query).FirstOrDefault();
        }


        #endregion

        #region Reports

        public Task<List<Invoice>> GetAllUnpaidInvoices()
        {
            var query = "SELECT * FROM Invoice WHERE HasPaid = 0";
            return Task.FromResult(db.Query<Invoice>(query).ToList());
        }

        public Task<List<Invoice>> GetAllPaidInvoices()
        {
            var query = "SELECT * FROM Invoice WHERE HasPaid = 1";
            return Task.FromResult(db.Query<Invoice>(query).ToList());
        }

        public Task<List<Invoice>> GetAllInvoicesByCustomerId(int customerId)
        {
            var query = $"SELECT * FROM Invoice WHERE Invoice.CustomerId = {customerId}";
            return Task.FromResult(db.Query<Invoice>(query).ToList());
        }

        #endregion
    }
}
