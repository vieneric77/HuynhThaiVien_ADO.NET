using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONET
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=VIEW\THAIVIEN;Initial Catalog=sale;Integrated Security=True";
        bool isDataLoaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlDataAdapter daArea = new SqlDataAdapter("select * from areas", conn);
                    DataTable dtArea = new DataTable();
                    daArea.Fill(dtArea);

                    cbArea.DataSource = dtArea;
                    cbArea.DisplayMember = "name";
                    cbArea.ValueMember = "id";
                }

                LoadData();

                dgvCustomer.ClearSelection();
                ClearForm();

                isDataLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            tbId.Clear();
            tbName.Clear();
            tbPhone.Clear();
            cbArea.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            chkVip.Checked = false;
            dtpDob.Value = DateTime.Now;
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "select c.id, c.name, a.name, c.gender, c.dob, c.phone, c.is_vip " +
                             "from customer c inner join areas a on c.id_area = a.id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvCustomer.Rows.Clear();
                while (reader.Read())
                {
                    string gender = reader["gender"] == DBNull.Value ? "" : reader["gender"].ToString();
                    string dob = reader["dob"] != DBNull.Value ? Convert.ToDateTime(reader["dob"]).ToString("dd/MM/yyyy") : "";
                    string phone = reader["phone"] == DBNull.Value ? "" : reader["phone"].ToString();
                    bool isVip = reader["is_vip"] != DBNull.Value ? (bool)reader["is_vip"] : false;

                    dgvCustomer.Rows.Add(reader["id"], reader["name"], reader[2], gender, dob, phone, isVip ? "VIP" : "Thường");
                }
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && dgvCustomer.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
                cbArea.Text = dgvCustomer.Rows[idx].Cells[2].Value?.ToString();

                string gender = dgvCustomer.Rows[idx].Cells[3].Value?.ToString();
                rbMale.Checked = (gender == "Nam");
                rbFemale.Checked = (gender == "Nữ");

                string dateStr = dgvCustomer.Rows[idx].Cells[4].Value?.ToString();
                if (!string.IsNullOrEmpty(dateStr))
                    dtpDob.Value = DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);

                tbPhone.Text = dgvCustomer.Rows[idx].Cells[5].Value?.ToString() ?? "";
                chkVip.Checked = (dgvCustomer.Rows[idx].Cells[6].Value?.ToString() == "VIP");
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "insert into customer(id, name, id_area, gender, dob, phone, is_vip) " +
                             "values(@id, @name, @id_area, @gender, @dob, @phone, @is_vip)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", tbId.Text);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@id_area", cbArea.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Nam" : (rbFemale.Checked ? "Nữ" : ""));
                cmd.Parameters.AddWithValue("@dob", dtpDob.Value);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@is_vip", chkVip.Checked);

                cmd.ExecuteNonQuery();
                LoadData();
                ClearForm();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng có đang chọn dòng nào trong bảng không
            if (dgvCustomer.CurrentRow == null) return;

            // Lấy ID gốc của dòng đang chọn (id trước khi người dùng sửa trong ô TextBox)
            string oldId = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            string newId = tbId.Text;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                // 2. Nếu người dùng thay đổi giá trị ID trong TextBox (newId khác oldId)
                if (newId != oldId)
                {
                    // Kiểm tra xem ID mới này đã tồn tại ở dòng khác chưa
                    string checkSql = "SELECT COUNT(*) FROM customer WHERE id = @newId";
                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@newId", newId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("ID " + newId + " đã tồn tại. Không thể sửa thành ID này!");
                        return; // Thoát hàm, không thực hiện UPDATE
                    }
                }

                // 3. Thực hiện cập nhật: Sửa id cũ thành id mới và các thông tin đi kèm
                string sql = "update customer set id=@newId, name=@name, id_area=@id_area, " +
                             "gender=@gender, dob=@dob, phone=@phone, is_vip=@is_vip where id=@oldId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@newId", newId);
                cmd.Parameters.AddWithValue("@oldId", oldId);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@id_area", cbArea.SelectedValue);
                cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Nam" : (rbFemale.Checked ? "Nữ" : ""));
                cmd.Parameters.AddWithValue("@dob", dtpDob.Value);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@is_vip", chkVip.Checked);

                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa!");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = "delete from customer where id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", tbId.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Đã xóa!");
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}