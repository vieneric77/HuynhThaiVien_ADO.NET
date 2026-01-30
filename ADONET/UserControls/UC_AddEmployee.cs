using ADONET.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ADONET.UserControls
{
    public partial class UC_AddEmployee : UserControl
    {
        private string imgPath = "";
        private string currentSelectedID = "";

        public UC_AddEmployee()
        {
            InitializeComponent();
            LoadData();
        }

        private void FormatDataGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["ma_nv"].HeaderText = "Mã NV";
                dataGridView1.Columns["ho_ten"].HeaderText = "Họ và Tên";
                dataGridView1.Columns["gioi_tinh"].HeaderText = "Giới Tính";
                dataGridView1.Columns["so_dien_thoai"].HeaderText = "SĐT";
                dataGridView1.Columns["chuc_vu"].HeaderText = "Chức Vụ";
                dataGridView1.Columns["luong"].HeaderText = "Lương";
                dataGridView1.Columns["trang_thai"].HeaderText = "Trạng Thái";

                if (dataGridView1.Columns.Contains("duong_dan_anh"))
                {
                    dataGridView1.Columns["duong_dan_anh"].Visible = false;
                }

                if (dataGridView1.Columns.Contains("luong"))
                {
                    dataGridView1.Columns["luong"].DefaultCellStyle.Format = "N0";
                    dataGridView1.Columns["luong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                dataGridView1.ColumnHeadersHeight = 30;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void LoadData()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT ma_nv, ho_ten, gioi_tinh, so_dien_thoai, chuc_vu, luong, trang_thai, duong_dan_anh FROM nhan_vien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                FormatDataGridView();
            }
        }

        private bool CheckIDExists(string maNV)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM nhan_vien WHERE ma_nv = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNV);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng nhập Mã NV!");
                return;
            }

            if (CheckIDExists(maNV))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại!");
                return;
            }

            ExecuteQuery("INSERT INTO nhan_vien(ma_nv, ho_ten, gioi_tinh, so_dien_thoai, chuc_vu, trang_thai, duong_dan_anh) VALUES(@ma, @ten, @gt, @sdt, @cv, @tt, @anh)",
                         "Thêm mới thành công!", maNV);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maNVInput = txtMaNV.Text.Trim();

            if (string.IsNullOrEmpty(currentSelectedID))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách!");
                return;
            }

            if (maNVInput != currentSelectedID)
            {
                if (CheckIDExists(maNVInput))
                {
                    MessageBox.Show("Mã nhân viên mới đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Bạn muốn đổi mã định danh?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }

            string sql = "UPDATE nhan_vien SET ma_nv=@ma, ho_ten=@ten, gioi_tinh=@gt, so_dien_thoai=@sdt, chuc_vu=@cv, trang_thai=@tt, duong_dan_anh=@anh WHERE ma_nv=@oldMa";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNVInput);
                cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@gt", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@cv", cbChucVu.Text);
                cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);
                cmd.Parameters.AddWithValue("@anh", imgPath ?? "");
                cmd.Parameters.AddWithValue("@oldMa", currentSelectedID);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                currentSelectedID = maNVInput;
                LoadData();
            }
        }

        private void ExecuteQuery(string sql, string successMsg, string maNV)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNV);
                cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@gt", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@cv", cbChucVu.Text);
                cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);
                cmd.Parameters.AddWithValue("@anh", imgPath ?? "");
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(successMsg);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentSelectedID)) return;

            if (MessageBox.Show("Xóa nhân viên " + currentSelectedID + "?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM nhan_vien WHERE ma_nv=@ma", conn);
                    cmd.Parameters.AddWithValue("@ma", currentSelectedID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnClear_Click(sender, e);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            cbGioiTinh.SelectedIndex = -1;
            cbChucVu.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            if (pbAnh.Image != null) pbAnh.Image.Dispose();
            pbAnh.Image = null;
            imgPath = "";
            currentSelectedID = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                currentSelectedID = row.Cells["ma_nv"].Value.ToString();

                txtMaNV.Text = currentSelectedID;
                txtHoTen.Text = row.Cells["ho_ten"].Value.ToString();
                cbGioiTinh.Text = row.Cells["gioi_tinh"].Value.ToString();
                txtSDT.Text = row.Cells["so_dien_thoai"].Value.ToString();
                cbChucVu.Text = row.Cells["chuc_vu"].Value.ToString();
                cbTrangThai.Text = row.Cells["trang_thai"].Value.ToString();
                imgPath = row.Cells["duong_dan_anh"].Value.ToString();

                if (pbAnh.Image != null) pbAnh.Image.Dispose();

                try
                {
                    if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                    {
                        using (FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                        {
                            pbAnh.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        pbAnh.Image = null;
                    }
                }
                catch
                {
                    pbAnh.Image = null;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    imgPath = open.FileName;
                    if (pbAnh.Image != null) pbAnh.Image.Dispose();

                    using (FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    {
                        pbAnh.Image = Image.FromStream(fs);
                    }
                }
            }
        }
    }
}