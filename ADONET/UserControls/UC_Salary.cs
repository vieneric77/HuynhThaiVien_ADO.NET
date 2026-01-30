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
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ma_nv, ho_ten, chuc_vu, luong FROM nhan_vien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
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
                txtChucVu.Text = row.Cells["chuc_vu"].Value.ToString();
                txtLuong.Text = row.Cells["luong"].Value.ToString();
                txtLuong.Focus();
                txtLuong.SelectAll();
            }
        }
    }
}