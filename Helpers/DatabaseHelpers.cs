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
    }
}
