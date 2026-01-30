namespace ADONET.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            void SetupNavButton(System.Windows.Forms.Button btn, string text, string iconText)
            {
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(53, 45, 125);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Size = new System.Drawing.Size(225, 55);
                btn.Text = "   " + iconText + "    " + text;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.UseVisualStyleBackColor = true;
            }

            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.panelSidebar.Controls.Add(this.btnSignOut);
            this.panelSidebar.Controls.Add(this.btnPosition);
            this.panelSidebar.Controls.Add(this.btnDepartment);
            this.panelSidebar.Controls.Add(this.btnSalary);
            this.panelSidebar.Controls.Add(this.btnAddEmployee);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.picUser);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Size = new System.Drawing.Size(225, 600);

            this.picUser.BackColor = System.Drawing.Color.Gray;
            this.picUser.Location = new System.Drawing.Point(67, 35);
            this.picUser.Size = new System.Drawing.Size(90, 90);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUser.Location = new System.Drawing.Point(0, 130);
            this.lblUser.Size = new System.Drawing.Size(225, 25);
            this.lblUser.Text = "Chào mừng, Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            SetupNavButton(this.btnDashboard, "Bảng điều khiển", "📊");
            this.btnDashboard.Location = new System.Drawing.Point(0, 190);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            SetupNavButton(this.btnAddEmployee, "Thêm nhân viên", "👤");
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 245);
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            SetupNavButton(this.btnSalary, "Lương nhân viên", "💵");
            this.btnSalary.Location = new System.Drawing.Point(0, 300);
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);

            SetupNavButton(this.btnDepartment, "Phòng ban", "🏢");
            this.btnDepartment.Location = new System.Drawing.Point(0, 355);
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);

            SetupNavButton(this.btnPosition, "Chức vụ", "🎓");
            this.btnPosition.Location = new System.Drawing.Point(0, 410);
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);

            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(170, 0, 0);
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(12, 535);
            this.btnSignOut.Size = new System.Drawing.Size(200, 45);
            this.btnSignOut.Text = "🚪  ĐĂNG XUẤT";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);

            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(875, 50);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Hệ thống Quản lý Nhân sự";

            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.Text = "✕";
            this.btnClose.Click += (s, e) => Application.Exit();

            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(225, 50);
            this.panelContainer.Size = new System.Drawing.Size(875, 550);

            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}