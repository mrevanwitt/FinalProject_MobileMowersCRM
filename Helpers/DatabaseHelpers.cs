using FinalProject_MobileMowersCRM.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Helpers
{
    internal class DatabaseHelpers
    {
        private MySqlConnection? mySqlConnection;
        public void ConnectDatabase()
        {
            if (mySqlConnection == null)
            {
                mySqlConnection = new MySqlConnection("server=sql3.freemysqlhosting.net;userid=sql3467012;database=sql3467012;password=NP9C2wF8AD");
            }
            mySqlConnection.Open();
        }

        #region Customer

        public void AddCusomter(Customer customer)
        {

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
            return new List<Customer>();
        }

        #endregion

        #region Service

        public void AddService(Service service)
        {

        }

        public void UpdateService(Service service)
        {

        }

        public void DeleteService(Service service)
        {

        }

        public Service GetServiceById(int serviceId)
        {
            return new Service();
        }

        public List<Service> GetAllServices()
        {
            return new List<Service>();
        }

        #endregion

        #region Invoice

        public void AddInvoice(Invoice invoice)
        {

        }

        public void UpdateInvoice(Invoice invoice)
        {

        }

        public void DeleteInvoice(Invoice invoice)
        {

        }

        public Invoice GetInvoiceById(int invoice)
        {
            return new Invoice();
        }

        public List<Invoice> GetAllInvoices()
        {
            return new List<Invoice>();
        }

        #endregion

    }
}
