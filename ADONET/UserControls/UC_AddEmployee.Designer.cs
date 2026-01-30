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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Size = new System.Drawing.Size(835, 250);
            this.dataGridView1.TabIndex = 0;
            // ĐĂNG KÝ SỰ KIỆN CLICK DÒNG
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.txtMaNV);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.txtHoTen);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.cbGioiTinh);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.txtSDT);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.cbChucVu);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.cbTrangThai);
            this.panelControl.Controls.Add(this.pbAnh);
            this.panelControl.Controls.Add(this.btnImport);
            this.panelControl.Controls.Add(this.btnAdd);
            this.panelControl.Controls.Add(this.btnUpdate);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Location = new System.Drawing.Point(20, 285);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(835, 260);

            // Label 1 - Mã NV
            this.label1.Text = "Mã Nhân Viên:";
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.Location = new System.Drawing.Point(130, 22);
            this.txtMaNV.Size = new System.Drawing.Size(160, 27);

            // Label 2 - Họ Tên
            this.label2.Text = "Họ và Tên:";
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.Location = new System.Drawing.Point(130, 62);
            this.txtHoTen.Size = new System.Drawing.Size(160, 27);

            // Label 3 - Giới Tính
            this.label3.Text = "Giới Tính:";
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cbGioiTinh.Location = new System.Drawing.Point(130, 102);
            this.cbGioiTinh.Size = new System.Drawing.Size(160, 28);
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Label 4 - SĐT
            this.label4.Text = "Số Điện Thoại:";
            this.label4.Location = new System.Drawing.Point(320, 25);
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.Location = new System.Drawing.Point(425, 22);
            this.txtSDT.Size = new System.Drawing.Size(160, 27);

            // Label 5 - Chức Vụ
            this.label5.Text = "Chức Vụ:";
            this.label5.Location = new System.Drawing.Point(320, 65);
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.cbChucVu.Items.AddRange(new object[] { "Quản lý", "Kế toán", "Lập trình viên", "Nhân viên Sales" });
            this.cbChucVu.Location = new System.Drawing.Point(425, 62);
            this.cbChucVu.Size = new System.Drawing.Size(160, 28);
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Label 7 - Trạng Thái
            this.label7.Text = "Trạng Thái:";
            this.label7.Location = new System.Drawing.Point(320, 105);
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.cbTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ việc" });
            this.cbTrangThai.Location = new System.Drawing.Point(425, 102);
            this.cbTrangThai.Size = new System.Drawing.Size(160, 28);
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // PictureBox
            this.pbAnh.BackColor = System.Drawing.Color.Gainsboro;
            this.pbAnh.Location = new System.Drawing.Point(680, 20);
            this.pbAnh.Size = new System.Drawing.Size(120, 130);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Button Import (Chọn Ảnh)
            this.btnImport.Text = "Chọn Ảnh";
            this.btnImport.Location = new System.Drawing.Point(680, 155);
            this.btnImport.Size = new System.Drawing.Size(120, 30);
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);

            // Button Add (Thêm)
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(100, 190);
            this.btnAdd.Size = new System.Drawing.Size(100, 45);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Button Update (Sửa)
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Location = new System.Drawing.Point(220, 190);
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // Button Delete (Xóa)
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(340, 190);
            this.btnDelete.Size = new System.Drawing.Size(100, 45);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Button Clear (Làm Mới)
            this.btnClear.Text = "Làm Mới";
            this.btnClear.Location = new System.Drawing.Point(460, 190);
            this.btnClear.Size = new System.Drawing.Size(100, 45);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // UC_AddEmployee
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

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtSDT;
        private System.Windows.Forms.ComboBox cbGioiTinh, cbChucVu, cbTrangThai;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear, btnImport;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label7;
        private System.Windows.Forms.Panel panelControl;
    }
}