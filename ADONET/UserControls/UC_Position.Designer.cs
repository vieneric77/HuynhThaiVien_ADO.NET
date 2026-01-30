namespace ADONET.UserControls
{
    partial class UC_Position
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(121, 50);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(183, 27);
            this.txtMaCV.TabIndex = 0;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(121, 87);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(183, 27);
            this.txtTenCV.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(335, 47);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 32);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click); // GÁN SỰ KIỆN
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(417, 47);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 32);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click); // GÁN SỰ KIỆN
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(489, 47);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 33);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click); // GÁN SỰ KIỆN
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(566, 46);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click); // GÁN SỰ KIỆN
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Location = new System.Drawing.Point(27, 146);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowHeadersWidth = 51;
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            this.dgvChucVu.Size = new System.Drawing.Size(806, 371);
            this.dgvChucVu.TabIndex = 6;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick); // GÁN SỰ KIỆN
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.Text = "Mã Chức Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Tên Chức Vụ:";
            // 
            // UC_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtMaCV);
            this.Name = "UC_Position";
            this.Size = new System.Drawing.Size(864, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}