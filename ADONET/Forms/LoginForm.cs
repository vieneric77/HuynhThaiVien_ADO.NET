using ADONET.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADONET.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm() { InitializeComponent(); }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM tai_khoan WHERE ten_dang_nhap = @user AND mat_khau = @pass";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }
    }
}