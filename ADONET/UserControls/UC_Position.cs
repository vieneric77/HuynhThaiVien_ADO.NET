using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADONET.Data;

namespace ADONET.UserControls
{
    public partial class UC_Position : UserControl
    {
        public UC_Position()
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
                    string query = "SELECT MaCV, TenCV FROM ChucVu";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChucVu.DataSource = dt;

                    // Đổi tên tiêu đề cột
                    if (dgvChucVu.Columns["MaCV"] != null)
                        dgvChucVu.Columns["MaCV"].HeaderText = "Mã Chức Vụ";
                    if (dgvChucVu.Columns["TenCV"] != null)
                        dgvChucVu.Columns["TenCV"].HeaderText = "Tên Chức Vụ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtMaCV.Enabled = true;
            txtMaCV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text) || string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO ChucVu (MaCV, TenCV) VALUES (@ma, @ten)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenCV.Text.Trim());
                    cmd.ExecuteNonQuery();

                    LoadData();
                    MessageBox.Show("Thêm chức vụ thành công!");
                    btnThem_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text)) return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE ChucVu SET TenCV = @ten WHERE MaCV = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ten", txtTenCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ma", txtMaCV.Text.Trim());
                    cmd.ExecuteNonQuery();

                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text)) return;

            if (MessageBox.Show("Bạn có muốn xóa chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM ChucVu WHERE MaCV = @ma";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", txtMaCV.Text.Trim());
                        cmd.ExecuteNonQuery();

                        LoadData();
                        btnThem_Click(null, null);
                        MessageBox.Show("Đã xóa chức vụ!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa chức vụ này vì đã có nhân viên thuộc chức vụ này!", "Lỗi ràng buộc");
                }
            }
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ (không phải tiêu đề)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChucVu.Rows[e.RowIndex];
                txtMaCV.Text = row.Cells["MaCV"].Value.ToString();
                txtTenCV.Text = row.Cells["TenCV"].Value.ToString();

                // Khi sửa/xóa thì không cho sửa Mã (Khóa chính)
                txtMaCV.Enabled = false;
            }
        }
    }
}