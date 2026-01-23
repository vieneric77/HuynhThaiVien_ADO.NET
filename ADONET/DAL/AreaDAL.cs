using System.Collections.Generic;
using System.Data.SqlClient;
using ADONET.Model;

namespace ADONET.DAL
{
    public class AreaDAL : DBConnection
    {
        public List<AreaBEL> ReadAreaList()
        {
            List<AreaBEL> lstArea = new List<AreaBEL>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from areas", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstArea.Add(new AreaBEL
                    {
                        Id = (int)reader["id"],
                        Name = reader["name"].ToString()
                    });
                }
            }
            return lstArea;
        }
    }
}