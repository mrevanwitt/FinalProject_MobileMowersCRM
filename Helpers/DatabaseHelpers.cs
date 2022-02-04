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

        public Customer GetCustomerById(int customerId)
        {
            string query = $"SELECT * FROM Customer WHERE Customer.CustomerId = {customerId}";
            return db.Query<Customer>(query).FirstOrDefault();
        }

        public List<Customer> GetAllCustomers()
        {

            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Customer>(db);

        }

        #endregion

        #region Service


        public List<Service> GetAllServices()
        {
            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Service>(db);
        }

        #endregion

        #region Invoice

        public void AddInvoice(Invoice invoice)
        {
            db.Insert(invoice);

            //var invoices = GetAllInvoices();
            //return invoices[invoices.Count-1].InvoiceID;
        }

        public List<Invoice> GetAllInvoices()
        {
            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Invoice>(db);
        }
        #endregion

        #region Service To Invoice

        public void AddServiceToInvoice(ServiceToInvoice serviceToInvoice)
        {
            db.Insert(serviceToInvoice);
        }

        #endregion
    }
}
