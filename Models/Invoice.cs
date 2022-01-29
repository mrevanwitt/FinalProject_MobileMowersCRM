using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Models
{
    internal class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceTaxAmount { get; set; }
        public DateTime DatePaid { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDue { get; set; }
    }
}
