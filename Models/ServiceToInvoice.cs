using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Models
{
    public class ServiceToInvoice
    {
        public int ServiceToInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
    }
}
