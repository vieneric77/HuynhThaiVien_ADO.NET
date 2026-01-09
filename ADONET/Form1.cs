using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONET
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=VIEW\THAIVIEN;Initial Catalog=sale;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from customer", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvCustomer.Rows.Clear();
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "insert into customer values(" + tbId.Text + ", '" + tbName.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                btRead_Click(sender, e);
                MessageBox.Show("Thêm thành công!");
            }
        }
        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && dgvCustomer.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "update customer set name = '" + tbName.Text + "' where id = " + tbId.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                btRead_Click(sender, e);
                MessageBox.Show("Đã sửa!");
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "delete from customer where id = " + tbId.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                btRead_Click(sender, e);
                MessageBox.Show("Đã xóa!");
            }
        }

        private void btExit_Click(object sender, EventArgs e) => Application.Exit();

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}