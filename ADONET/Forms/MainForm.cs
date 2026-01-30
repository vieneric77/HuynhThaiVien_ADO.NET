using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ADONET.UserControls;

namespace ADONET.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += (s, e) => MakeCirclePictureBox(picUser);
            addUserControl(new UC_Dashboard());
        }

        private void MakeCirclePictureBox(PictureBox p)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, p.Width, p.Height);
            p.Region = new Region(gp);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e) => addUserControl(new UC_Dashboard());
        private void btnAddEmployee_Click(object sender, EventArgs e) => addUserControl(new UC_AddEmployee());
        private void btnSalary_Click(object sender, EventArgs e) => addUserControl(new UC_Salary());
        private void btnDepartment_Click(object sender, EventArgs e) => addUserControl(new UC_Department());
        private void btnPosition_Click(object sender, EventArgs e) => addUserControl(new UC_Position());

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}