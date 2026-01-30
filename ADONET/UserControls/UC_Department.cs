using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADONET.Data;

namespace ADONET.UserControls
{
    public partial class UC_Department : UserControl
    {
        public UC_Department()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MaPB, TenPB, SoNV FROM PhongBan";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDepartment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaPB.Enabled = true;
            txtMaPB.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPB.Text) || string.IsNullOrEmpty(txtTenPB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO PhongBan (MaPB, TenPB, SoNV) VALUES (@MaPB, @TenPB, 0)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
                    cmd.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
                    cmd.ExecuteNonQuery();

                    LoadData();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE PhongBan SET TenPB = @TenPB WHERE MaPB = @MaPB";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
                    cmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
                    cmd.ExecuteNonQuery();

                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM PhongBan WHERE MaPB = @MaPB";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
                        cmd.ExecuteNonQuery();

                        LoadData();
                        txtMaPB.Clear();
                        txtTenPB.Clear();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];
                txtMaPB.Text = row.Cells["MaPB"].Value.ToString();
                txtTenPB.Text = row.Cells["TenPB"].Value.ToString();
                txtMaPB.Enabled = false;
            }
        }
    }
}