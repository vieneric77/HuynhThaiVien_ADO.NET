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
            // Thiết lập ô lương chỉ để xem
            if (txtLuong != null)
            {
                txtLuong.ReadOnly = true;
                txtLuong.BackColor = Color.LightGray; // Đổi màu để người dùng biết không được sửa
            }

            LoadPhongBan();
            LoadChucVu();
            LoadData();
        }

        private void LoadPhongBan()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT MaPB, TenPB FROM PhongBan";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbPhongBan.DataSource = dt;
                    cbPhongBan.DisplayMember = "TenPB";
                    cbPhongBan.ValueMember = "MaPB";
                    cbPhongBan.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải phòng ban: " + ex.Message); }
        }

        private void LoadChucVu()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT MaCV, TenCV FROM ChucVu";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbChucVu.DataSource = dt;
                    cbChucVu.DisplayMember = "TenCV";
                    cbChucVu.ValueMember = "MaCV";
                    cbChucVu.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải chức vụ: " + ex.Message); }
        }

        private void FormatDataGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["ma_nv"].HeaderText = "Mã NV";
                dataGridView1.Columns["ho_ten"].HeaderText = "Họ và Tên";
                dataGridView1.Columns["gioi_tinh"].HeaderText = "Giới Tính";
                dataGridView1.Columns["so_dien_thoai"].HeaderText = "SĐT";
                dataGridView1.Columns["dia_chi"].HeaderText = "Địa Chỉ";
                dataGridView1.Columns["TenCV"].HeaderText = "Chức Vụ";
                dataGridView1.Columns["TenPB"].HeaderText = "Phòng Ban";
                dataGridView1.Columns["trang_thai"].HeaderText = "Trạng Thái";

                // Hiển thị cột lương từ Database (chỉ xem)
                if (dataGridView1.Columns.Contains("luong"))
                {
                    dataGridView1.Columns["luong"].HeaderText = "Lương (VNĐ)";
                    dataGridView1.Columns["luong"].Visible = true;
                    dataGridView1.Columns["luong"].DefaultCellStyle.Format = "N0";
                    dataGridView1.Columns["luong"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                }

                if (dataGridView1.Columns.Contains("duong_dan_anh")) dataGridView1.Columns["duong_dan_anh"].Visible = false;
                if (dataGridView1.Columns.Contains("MaPB")) dataGridView1.Columns["MaPB"].Visible = false;
                if (dataGridView1.Columns.Contains("MaCV")) dataGridView1.Columns["MaCV"].Visible = false;

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 11, 97);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT nv.*, pb.TenPB, cv.TenCV 
                                     FROM nhan_vien nv 
                                     LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB 
                                     LEFT JOIN ChucVu cv ON nv.MaCV = cv.MaCV";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    FormatDataGridView();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private bool IsMaNVExist(string maNV)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM nhan_vien WHERE ma_nv = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", maNV);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNV) || cbPhongBan.SelectedValue == null || cbChucVu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV, Phòng Ban và Chức Vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsMaNVExist(maNV))
            {
                MessageBox.Show($"Mã nhân viên '{maNV}' đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // KHÔNG thêm 'luong' vào đây vì lương do trang Salary quản lý
            string sql = "INSERT INTO nhan_vien(ma_nv, ho_ten, gioi_tinh, so_dien_thoai, MaCV, trang_thai, duong_dan_anh, MaPB, dia_chi) " +
                         "VALUES(@ma, @ten, @gt, @sdt, @macv, @tt, @anh, @mapb, @dc)";

            ExecuteEmployeeQuery(sql, "Thêm mới thành công!", maNV);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentSelectedID)) return;

            // KHÔNG cập nhật 'luong' tại đây
            string sql = "UPDATE nhan_vien SET ho_ten=@ten, gioi_tinh=@gt, so_dien_thoai=@sdt, MaCV=@macv, " +
                         "trang_thai=@tt, duong_dan_anh=@anh, MaPB=@mapb, dia_chi=@dc WHERE ma_nv=@ma";

            ExecuteEmployeeQuery(sql, "Cập nhật thành công!", currentSelectedID);
        }

        private void ExecuteEmployeeQuery(string sql, string msg, string maNV)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", maNV);
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@gt", rbNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@macv", cbChucVu.SelectedValue);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@anh", imgPath ?? "");
                    cmd.Parameters.AddWithValue("@mapb", cbPhongBan.SelectedValue);
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi truy vấn: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentSelectedID)) return;
            if (MessageBox.Show("Xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
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
                catch (Exception ex) { MessageBox.Show("Lỗi khi xóa: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear(); txtHoTen.Clear(); txtSDT.Clear(); txtDiaChi.Clear();
            if (txtLuong != null) txtLuong.Clear();
            rbNam.Checked = true; cbChucVu.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1; cbPhongBan.SelectedIndex = -1;
            pbAnh.Image = null; imgPath = ""; currentSelectedID = "";
            txtMaNV.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                currentSelectedID = row.Cells["ma_nv"].Value.ToString();
                txtMaNV.Text = currentSelectedID;
                txtMaNV.Enabled = false;

                txtHoTen.Text = row.Cells["ho_ten"].Value.ToString();

                // Hiển thị lương lên TextBox để xem (Định dạng tiền tệ VN)
                if (dataGridView1.Columns.Contains("luong") && row.Cells["luong"].Value != DBNull.Value)
                {
                    decimal salaryValue = Convert.ToDecimal(row.Cells["luong"].Value);
                    txtLuong.Text = salaryValue.ToString("N0");
                }
                else { txtLuong.Text = "0"; }

                string gt = row.Cells["gioi_tinh"].Value.ToString();
                if (gt == "Nam") rbNam.Checked = true; else rbNu.Checked = true;

                txtSDT.Text = row.Cells["so_dien_thoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["dia_chi"].Value?.ToString();
                cbChucVu.SelectedValue = row.Cells["MaCV"].Value;
                cbTrangThai.Text = row.Cells["trang_thai"].Value.ToString();
                cbPhongBan.SelectedValue = row.Cells["MaPB"].Value;

                imgPath = row.Cells["duong_dan_anh"].Value.ToString();
                if (File.Exists(imgPath))
                {
                    using (FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                        pbAnh.Image = Image.FromStream(fs);
                }
                else pbAnh.Image = null;
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
                    using (FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                        pbAnh.Image = Image.FromStream(fs);
                }
            }
        }
    }
}