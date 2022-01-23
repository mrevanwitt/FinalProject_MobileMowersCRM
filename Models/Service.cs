using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Models
{
    internal class Service
    {
        public int ServiceId { get; set; }
        public int ServiceName { get; set; }
        public decimal ServiceAmount { get; set; }
        public string? ServiceDescription { get; set; }
    }
}
