namespace ADONET.UserControls
{
    partial class UC_Department
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

        private void InitializeComponent()
        {
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(130, 50);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(250, 22);
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(130, 90);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(250, 22);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(400, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(600, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(700, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Location = new System.Drawing.Point(20, 150);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(800, 350);
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            // 
            // lblMaPB
            // 
            this.lblMaPB.Location = new System.Drawing.Point(20, 53);
            this.lblMaPB.Text = "Mã Phòng Ban:";
            // 
            // lblTenPB
            // 
            this.lblTenPB.Location = new System.Drawing.Point(20, 93);
            this.lblTenPB.Text = "Tên Phòng Ban:";
            // 
            // UC_Department
            // 
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Size = new System.Drawing.Size(850, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblTenPB;
    }
}