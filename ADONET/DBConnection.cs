using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET.DAL
{
    public class DBConnection
    {
        protected string strConn = @"Data Source=VIEW\THAIVIEN;Initial Catalog=sale;Integrated Security=True";
        public SqlConnection CreateConnection() => new SqlConnection(strConn);
    }
}
