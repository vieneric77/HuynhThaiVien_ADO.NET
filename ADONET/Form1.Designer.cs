namespace ADONET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.x`</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btRead = new Button();
            btNew = new Button();
            btDelete = new Button();
            btEdit = new Button();
            btExit = new Button();
            tbId = new TextBox();
            tbName = new TextBox();
            lblId = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvCustomer.Location = new Point(12, 12);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(624, 230);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.RowEnter += dgvCustomer_RowEnter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "Mã";
            dataGridViewTextBoxColumn1.Width = 230;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "Tên";
            dataGridViewTextBoxColumn2.Width = 350;
            // 
            // btRead
            // 
            btRead.Location = new Point(12, 330);
            btRead.Name = "btRead";
            btRead.Size = new Size(100, 35);
            btRead.TabIndex = 1;
            btRead.Text = "Đọc dữ liệu";
            btRead.Click += btRead_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(209, 330);
            btNew.Name = "btNew";
            btNew.Size = new Size(100, 35);
            btNew.TabIndex = 2;
            btNew.Text = "Thêm";
            btNew.Click += btNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(315, 330);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(100, 35);
            btDelete.TabIndex = 3;
            btDelete.Text = "Xóa";
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(421, 330);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(100, 35);
            btEdit.TabIndex = 4;
            btEdit.Text = "Sửa";
            btEdit.Click += btEdit_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(527, 330);
            btExit.Name = "btExit";
            btExit.Size = new Size(100, 35);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.Click += btExit_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(80, 257);
            tbId.Name = "tbId";
            tbId.Size = new Size(197, 27);
            tbId.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(80, 297);
            tbName.Name = "tbName";
            tbName.Size = new Size(197, 27);
            tbName.TabIndex = 7;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // lblId
            // 
            lblId.Location = new Point(12, 260);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 8;
            lblId.Text = "Mã:";
            // 
            // lblName
            // 
            lblName.Location = new Point(12, 297);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 9;
            lblName.Text = "Tên:";
            // 
            // Form1
            // 
            ClientSize = new Size(639, 400);
            Controls.Add(dgvCustomer);
            Controls.Add(btRead);
            Controls.Add(btNew);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btExit);
            Controls.Add(tbId);
            Controls.Add(tbName);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Quản lý khách hàng ADO.NET";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btRead, btNew, btDelete, btEdit, btExit;
        private System.Windows.Forms.TextBox tbId, tbName;
        private System.Windows.Forms.Label lblId, lblName;

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
