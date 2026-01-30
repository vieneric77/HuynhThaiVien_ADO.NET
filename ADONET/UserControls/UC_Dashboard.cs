using ADONET.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADONET.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard() { InitializeComponent(); GetData(); }

        void GetData()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                lblTotal.Text = new SqlCommand("SELECT COUNT(*) FROM nhan_vien", conn).ExecuteScalar().ToString();
                lblActive.Text = new SqlCommand("SELECT COUNT(*) FROM nhan_vien WHERE trang_thai=N'Đang làm việc'", conn).ExecuteScalar().ToString();
                lblInactive.Text = new SqlCommand("SELECT COUNT(*) FROM nhan_vien WHERE trang_thai=N'Đã nghỉ việc'", conn).ExecuteScalar().ToString();
            }
        }
    }
}