using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MobileMowersCRM.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public string? Username {get; set; }
        public string? Password { get; set; }
        public string? Salt { get; set; }
    }
}
