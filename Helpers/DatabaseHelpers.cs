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

        }

        public void DeleteCustomer(Customer customer)
        {

        }

        public Customer GetCustomerById(int customerId)
        {
            return new Customer();
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

        public int AddInvoice(Invoice invoice)
        {
            return db.Insert(invoice);
        }
        #endregion

        #region Service To Invoice

        public void AddnewServiceToInvoice(ServiceToInvoice serviceToInvoice)
        {
            db.Insert(serviceToInvoice);
        }

        #endregion
    }
}
