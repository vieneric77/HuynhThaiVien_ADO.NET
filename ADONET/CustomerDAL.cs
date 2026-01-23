using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ADONET.Model;

namespace ADONET.DAL
{
    public class CustomerDAL : DBConnection
    {
        // 1. Lấy danh sách khách hàng (kèm tên khu vực)
        public List<CustomerBEL> ReadCustomerList()
        {
            List<CustomerBEL> lstCus = new List<CustomerBEL>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                // Sử dụng JOIN để lấy Tên khu vực từ bảng Areas
                string sql = "select c.id, c.name, a.name from customer c join areas a on c.id_area = a.id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    CustomerBEL cus = new CustomerBEL();
                    cus.Id = int.Parse(r[0].ToString());
                    cus.Name = r[1].ToString();
                    cus.Area = new AreaBEL { Name = r[2].ToString() };
                    lstCus.Add(cus);
                }
            }
            return lstCus;
        }

        // 2. Thêm khách hàng mới
        public void NewCustomer(CustomerBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string sql = "insert into customer (id, name, id_area) values (@id, @name, @id_area)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cus.Id);
                cmd.Parameters.AddWithValue("@name", cus.Name);
                cmd.Parameters.AddWithValue("@id_area", cus.Area.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // 3. Xóa khách hàng
        public void DeleteCustomer(CustomerBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string sql = "delete from customer where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cus.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // 4. Cập nhật thông tin khách hàng
        public void EditCustomer(CustomerBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string sql = "update customer set name = @name, id_area = @id_area where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cus.Id);
                cmd.Parameters.AddWithValue("@name", cus.Name);
                cmd.Parameters.AddWithValue("@id_area", cus.Area.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}