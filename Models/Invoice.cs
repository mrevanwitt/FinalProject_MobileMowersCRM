using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Models
{
    public class Invoice
    {
        [PrimaryKey, AutoIncrement]
        public int InvoiceID { get; set; }
        [ForeignKey(typeof(Customer))]
        public int CustomerId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string DatePaid { get; set; }
        public string DateCreated { get; set; }
    }
}
