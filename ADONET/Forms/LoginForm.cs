using ADONET.Data;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ADONET.Forms
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public LoginForm()
        {
            InitializeComponent();
            this.MouseDown += Form_Drag;
            this.pnlLeft.MouseDown += Form_Drag;
        }

        private void Form_Drag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000;
                return cp;
            }
        }
    }
}