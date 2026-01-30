namespace ADONET.UserControls
{
    partial class UC_Salary
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnClear);
            this.panelLeft.Controls.Add(this.btnUpdate);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtLuong);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.txtChucVu);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.txtHoTen);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.txtMaNV);
            this.panelLeft.Location = new System.Drawing.Point(15, 15);
            this.panelLeft.Size = new System.Drawing.Size(300, 530);

            this.label1.Text = "Employee ID:"; this.label1.Location = new System.Drawing.Point(20, 30);
            this.txtMaNV.Location = new System.Drawing.Point(20, 55); this.txtMaNV.Size = new System.Drawing.Size(260, 25); this.txtMaNV.ReadOnly = true;

            this.label2.Text = "Full Name:"; this.label2.Location = new System.Drawing.Point(20, 100);
            this.txtHoTen.Location = new System.Drawing.Point(20, 125); this.txtHoTen.Size = new System.Drawing.Size(260, 25); this.txtHoTen.ReadOnly = true;

            this.label3.Text = "Position:"; this.label3.Location = new System.Drawing.Point(20, 170);
            this.txtChucVu.Location = new System.Drawing.Point(20, 195); this.txtChucVu.Size = new System.Drawing.Size(260, 25); this.txtChucVu.ReadOnly = true;

            this.label4.Text = "Salary:"; this.label4.Location = new System.Drawing.Point(20, 240);
            this.txtLuong.Location = new System.Drawing.Point(20, 265); this.txtLuong.Size = new System.Drawing.Size(260, 25);

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 330);
            this.btnUpdate.Size = new System.Drawing.Size(110, 45);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(33, 11, 97);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(170, 330);
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.labelTitle);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Location = new System.Drawing.Point(335, 15);
            this.panelRight.Size = new System.Drawing.Size(525, 530);

            this.labelTitle.Text = "Employees"; this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold); this.labelTitle.Location = new System.Drawing.Point(20, 20);

            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Size = new System.Drawing.Size(485, 450);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Size = new System.Drawing.Size(875, 560);
            this.panelLeft.ResumeLayout(false); this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false); this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label1, label2, label3, label4, labelTitle;
        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtChucVu, txtLuong;
        private System.Windows.Forms.Button btnUpdate, btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}