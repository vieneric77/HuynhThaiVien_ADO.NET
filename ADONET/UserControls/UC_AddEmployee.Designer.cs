namespace ADONET.UserControls
{
    partial class UC_AddEmployee
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(835, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.txtLuong);
            this.panelControl.Controls.Add(this.rbNu);
            this.panelControl.Controls.Add(this.rbNam);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.txtMaNV);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.txtHoTen);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.txtSDT);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.cbChucVu);
            this.panelControl.Controls.Add(this.label6);
            this.panelControl.Controls.Add(this.cbPhongBan);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.cbTrangThai);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.txtDiaChi);
            this.panelControl.Controls.Add(this.pbAnh);
            this.panelControl.Controls.Add(this.btnImport);
            this.panelControl.Controls.Add(this.btnAdd);
            this.panelControl.Controls.Add(this.btnUpdate);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Location = new System.Drawing.Point(20, 260);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(835, 285);

            this.label1.Text = "Mã Nhân Viên:";
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.txtMaNV.Location = new System.Drawing.Point(130, 22);
            this.txtMaNV.Size = new System.Drawing.Size(160, 27);

            this.label2.Text = "Họ và Tên:";
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.txtHoTen.Location = new System.Drawing.Point(130, 62);
            this.txtHoTen.Size = new System.Drawing.Size(160, 27);

            this.label3.Text = "Giới Tính:";
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.rbNam.Text = "Nam";
            this.rbNam.Location = new System.Drawing.Point(130, 102);
            this.rbNam.Size = new System.Drawing.Size(70, 24);
            this.rbNam.Checked = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.Location = new System.Drawing.Point(200, 102);
            this.rbNu.Size = new System.Drawing.Size(70, 24);

            this.label4.Text = "Số Điện Thoại:";
            this.label4.Location = new System.Drawing.Point(320, 25);
            this.txtSDT.Location = new System.Drawing.Point(425, 22);
            this.txtSDT.Size = new System.Drawing.Size(160, 27);

            this.label5.Text = "Chức Vụ:";
            this.label5.Location = new System.Drawing.Point(320, 65);
            this.cbChucVu.Location = new System.Drawing.Point(425, 62);
            this.cbChucVu.Size = new System.Drawing.Size(160, 28);
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label6.Text = "Phòng Ban:";
            this.label6.Location = new System.Drawing.Point(320, 105);
            this.cbPhongBan.Location = new System.Drawing.Point(425, 102);
            this.cbPhongBan.Size = new System.Drawing.Size(160, 28);
            this.cbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label7.Text = "Trạng Thái:";
            this.label7.Location = new System.Drawing.Point(320, 145);
            this.cbTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ việc" });
            this.cbTrangThai.Location = new System.Drawing.Point(425, 142);
            this.cbTrangThai.Size = new System.Drawing.Size(160, 28);
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label8.Text = "Địa chỉ:";
            this.label8.Location = new System.Drawing.Point(25, 145);
            this.txtDiaChi.Location = new System.Drawing.Point(130, 142);
            this.txtDiaChi.Size = new System.Drawing.Size(160, 27);

            this.label9.Text = "Lương:";
            this.label9.Location = new System.Drawing.Point(25, 185);
            this.txtLuong.Location = new System.Drawing.Point(130, 182);
            this.txtLuong.Size = new System.Drawing.Size(160, 27);
            this.txtLuong.ReadOnly = true;
            this.txtLuong.BackColor = System.Drawing.Color.LightGray;

            this.pbAnh.BackColor = System.Drawing.Color.Gainsboro;
            this.pbAnh.Location = new System.Drawing.Point(680, 20);
            this.pbAnh.Size = new System.Drawing.Size(120, 130);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnImport.Text = "Chọn Ảnh";
            this.btnImport.Location = new System.Drawing.Point(680, 155);
            this.btnImport.Size = new System.Drawing.Size(120, 30);
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);

            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(100, 225);
            this.btnAdd.Size = new System.Drawing.Size(100, 45);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Location = new System.Drawing.Point(220, 225);
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(340, 225);
            this.btnDelete.Size = new System.Drawing.Size(100, 45);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Làm Mới";
            this.btnClear.Location = new System.Drawing.Point(460, 225);
            this.btnClear.Size = new System.Drawing.Size(100, 45);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_AddEmployee";
            this.Size = new System.Drawing.Size(875, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtSDT, txtDiaChi, txtLuong;
        private System.Windows.Forms.RadioButton rbNam, rbNu;
        private System.Windows.Forms.ComboBox cbChucVu, cbTrangThai, cbPhongBan;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear, btnImport;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8, label9;
        private System.Windows.Forms.Panel panelControl;
    }
}