namespace ADONET
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvCustomer = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colDob = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colVip = new DataGridViewTextBoxColumn();
            btNew = new Button();
            btDelete = new Button();
            btEdit = new Button();
            btExit = new Button();
            tbId = new TextBox();
            tbName = new TextBox();
            lblId = new Label();
            lblName = new Label();
            cbArea = new ComboBox();
            lblArea = new Label();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblDob = new Label();
            dtpDob = new DateTimePicker();
            lblPhone = new Label();
            tbPhone = new TextBox();
            chkVip = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();

            // dgvCustomer
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colArea, colGender, colDob, colPhone, colVip });
            dgvCustomer.Location = new Point(12, 12);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(776, 230);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;

            // Cấu hình các cột GridView
            colId.HeaderText = "Mã";
            colId.Name = "colId";
            colId.Width = 60;

            colName.HeaderText = "Họ tên";
            colName.Name = "colName";
            colName.Width = 150;

            colArea.HeaderText = "Khu vực";
            colArea.Name = "colArea";
            colArea.Width = 100;

            colGender.HeaderText = "Giới tính";
            colGender.Name = "colGender";
            colGender.Width = 80;

            colDob.HeaderText = "Ngày sinh";
            colDob.Name = "colDob";
            colDob.Width = 100;

            colPhone.HeaderText = "SĐT";
            colPhone.Name = "colPhone";
            colPhone.Width = 100;

            colVip.HeaderText = "Loại khách";
            colVip.Name = "colVip";
            colVip.Width = 90;

            // Các TextBox và Label
            tbId.Location = new Point(90, 260);
            tbId.Name = "tbId";
            tbId.Size = new Size(150, 27);
            tbId.TabIndex = 1;

            lblId.Location = new Point(12, 263);
            lblId.Name = "lblId";
            lblId.Size = new Size(70, 23);
            lblId.Text = "Mã:";

            tbName.Location = new Point(340, 260);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 27);
            tbName.TabIndex = 2;

            lblName.Location = new Point(260, 263);
            lblName.Name = "lblName";
            lblName.Size = new Size(70, 23);
            lblName.Text = "Họ tên:";

            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(630, 259);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(158, 28);
            cbArea.TabIndex = 3;

            lblArea.Location = new Point(555, 263);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(70, 23);
            lblArea.Text = "Khu vực:";

            // Giới tính
            lblGender.Location = new Point(12, 305);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 23);
            lblGender.Text = "Giới tính:";

            rbMale.AutoSize = true;
            rbMale.Location = new Point(90, 303);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;

            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(160, 303);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;

            // Ngày sinh
            lblDob.Location = new Point(260, 305);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(80, 23);
            lblDob.Text = "Ngày sinh:";

            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(340, 301);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(200, 27);
            dtpDob.TabIndex = 6;

            // Số điện thoại
            lblPhone.Location = new Point(555, 305);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(70, 23);
            lblPhone.Text = "SĐT:";

            tbPhone.Location = new Point(630, 301);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(158, 27);
            tbPhone.TabIndex = 7;

            // CheckBox VIP
            chkVip.AutoSize = true;
            chkVip.Location = new Point(90, 345);
            chkVip.Name = "chkVip";
            chkVip.Size = new Size(170, 24);
            chkVip.TabIndex = 8;
            chkVip.Text = "Khách hàng thân thiết";
            chkVip.UseVisualStyleBackColor = true;

            // Các nút bấm
            btNew.Location = new Point(210, 390);
            btNew.Name = "btNew";
            btNew.Size = new Size(100, 35);
            btNew.TabIndex = 9;
            btNew.Text = "Thêm";
            btNew.Click += btNew_Click;

            btDelete.Location = new Point(320, 390);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(100, 35);
            btDelete.TabIndex = 10;
            btDelete.Text = "Xóa";
            btDelete.Click += btDelete_Click;

            btEdit.Location = new Point(430, 390);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(100, 35);
            btEdit.TabIndex = 11;
            btEdit.Text = "Sửa";
            btEdit.Click += btEdit_Click;

            btExit.Location = new Point(540, 390);
            btExit.Name = "btExit";
            btExit.Size = new Size(100, 35);
            btExit.TabIndex = 12;
            btExit.Text = "Thoát";
            btExit.Click += btExit_Click;

            // Form1
            ClientSize = new Size(800, 450);
            Controls.Add(chkVip);
            Controls.Add(tbPhone);
            Controls.Add(lblPhone);
            Controls.Add(dtpDob);
            Controls.Add(lblDob);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(lblGender);
            Controls.Add(lblArea);
            Controls.Add(cbArea);
            Controls.Add(dgvCustomer);
            Controls.Add(btNew);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btExit);
            Controls.Add(tbId);
            Controls.Add(tbName);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Quản lý khách hàng";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomer;
        private Button btNew, btDelete, btEdit, btExit;
        private TextBox tbId, tbName, tbPhone;
        private Label lblId, lblName, lblArea, lblGender, lblDob, lblPhone;
        private ComboBox cbArea;
        private RadioButton rbMale, rbFemale;
        private DateTimePicker dtpDob;
        private CheckBox chkVip;
        private DataGridViewTextBoxColumn colId, colName, colArea, colGender, colDob, colPhone, colVip;
    }
}