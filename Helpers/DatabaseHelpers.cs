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
        //private MySqlConnection? mySqlConnection;
        private SQLiteConnection db;



        public void ConnectDatabase()
        {
            //    if (db == null)
            //    {
            //        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AppData");
            //        db = new SqliteConnection(dbPath);
            //    }

            //    db.CreateTables

            db = new SQLiteConnection("Data Source=AppData.db");
            db.CreateTables<Customer, Invoice, Service, ServiceToInvoice>();
            
        }

        //public void ConnectDatabase()
        //{
        //    if (mySqlConnection == null)
        //    {
        //        mySqlConnection = new MySqlConnection("server=sql3.freemysqlhosting.net;userid=sql3467012;database=sql3467012;password=NP9C2wF8AD");
        //    }
        //    mySqlConnection.Open();
        //}

        #region Customer

        public void AddCusomter(Customer customer)
        {
            db.Insert(customer);

            //var sql = @$"
            //        INSERT INTO `Customer` (
            //            `CustomerId`,  
            //            `UserName`, 
            //            `Password`, 
            //            `FirstName`, 
            //            `LastName`, 
            //            `PhoneNumber`, 
            //            `Email`, 
            //            `Address1`, 
            //            `Address2`, 
            //            `City`, 
            //            `State`, 
            //            `AreaCode`)
            //        VALUES (
            //            NULL, 
            //            '{customer.Username}', 
            //            '{customer.Password}', 
            //            '{customer.FirstName}', 
            //            '{customer.LastName}', 
            //            '{customer.PhoneNumber}', 
            //            '{customer.Email}', 
            //            '{customer.Address1}', 
            //            '{customer.Address2}', 
            //            '{customer.City}', 
            //            '{customer.State}', 
            //            '{customer.AreaCode}')";
            //ExecuteSql(sql);
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
            //var command = db.();
            //command.CommandText = "";

            return SQLiteNetExtensions.Extensions.ReadOperations.GetAllWithChildren<Customer>(db);

            

            //return ExecuteSqlWithDataTable(sql);
        }

        #endregion

        #region Service

        //public void AddService(Service service)
        //{

        //}

        //public void UpdateService(Service service)
        //{

        //}

        //public void DeleteService(Service service)
        //{

        //}

        //public Service GetServiceById(int serviceId)
        //{
        //    return new Service();
        //}

        //public List<Service> GetAllServices()
        //{
        //    return new List<Service>();
        //}

        //#endregion

        //#region Invoice

        //public void AddInvoice(Invoice invoice)
        //{

        //}

        //public void UpdateInvoice(Invoice invoice)
        //{

        //}

        //public void DeleteInvoice(Invoice invoice)
        //{

        //}

        //public Invoice GetInvoiceById(int invoice)
        //{
        //    return new Invoice();
        //}

        //public List<Invoice> GetAllInvoices()
        //{
        //    return new List<Invoice>();
        //}

        #endregion

        //public void ExecuteSql(string sql)
        //{
        //    new MySqlCommand(sql, mySqlConnection).ExecuteNonQuery();
        //}

        //public DataTable ExecuteSqlWithDataTable(string sql)
        //{
        //  var cmd = new MySqlCommand(sql, mySqlConnection);
        //  var adp = new MySqlDataAdapter(cmd);
        //  var dt = new DataTable();
        //  adp.Fill(dt);
        //  return dt;
        //}
    }
}
