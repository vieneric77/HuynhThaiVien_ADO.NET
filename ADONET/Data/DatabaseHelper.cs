using System;
using System.Data.SqlClient;

namespace ADONET.Data
{
    public class DatabaseHelper
    {
        // Sử dụng tên Server từ SQL Server Management Studio của bạn
        public static string connString = @"Data Source=VIEW\THAIVIEN;Initial Catalog=QuanLyNhanVien;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}