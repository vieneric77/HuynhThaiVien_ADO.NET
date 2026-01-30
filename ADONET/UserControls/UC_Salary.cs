using ADONET.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADONET.UserControls
{
    public partial class UC_Salary : UserControl
    {
        public UC_Salary()
        {
            InitializeComponent();
            LoadData();
            SetupReadOnlyFields();
        }

        private void SetupReadOnlyFields()
        {
            txtMaNV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtChucVu.ReadOnly = true;
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT nv.ma_nv, nv.ho_ten, cv.TenCV, nv.luong 
                                     FROM nhan_vien nv 
                                     LEFT JOIN ChucVu cv ON nv.MaCV = cv.MaCV";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Count > 0)
                    {
                        dataGridView1.Columns["ma_nv"].HeaderText = "Mã NV";
                        dataGridView1.Columns["ho_ten"].HeaderText = "Họ và Tên";
                        dataGridView1.Columns["TenCV"].HeaderText = "Chức Vụ";
                        dataGridView1.Columns["luong"].HeaderText = "Lương";
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên từ danh sách!");
                return;
            }
            if (!decimal.TryParse(txtLuong.Text, out decimal salary))
            {
                MessageBox.Show("Vui lòng nhập giá trị lương hợp lệ (số)!");
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "UPDATE nhan_vien SET luong=@l WHERE ma_nv=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@l", salary);
                cmd.Parameters.AddWithValue("@ma", txtMaNV.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật lương cho nhân viên " + txtMaNV.Text + " thành công!");
                LoadData();
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtChucVu.Clear();
            txtLuong.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["ma_nv"].Value.ToString();
                txtHoTen.Text = row.Cells["ho_ten"].Value.ToString();
                txtChucVu.Text = row.Cells["TenCV"].Value.ToString();
                txtLuong.Text = row.Cells["luong"].Value.ToString();
                txtLuong.Focus();
                txtLuong.SelectAll();
            }
        }
    }
}