using ADONET.UserControls;
using System;
using System.Windows.Forms;

namespace ADONET.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowDefaultDashboard();
        }

        private void ShowDefaultDashboard()
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_Dashboard());
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_AddEmployee());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_Salary());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}