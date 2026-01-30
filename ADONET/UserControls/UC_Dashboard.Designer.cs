namespace ADONET.UserControls
{
    partial class UC_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cardTotal = new Panel();
            icon1 = new Label();
            lblTotalEmployees = new Label();
            label1 = new Label();
            cardActive = new Panel();
            icon2 = new Label();
            lblActiveEmployees = new Label();
            label2 = new Label();
            cardInactive = new Panel();
            icon3 = new Label();
            lblInactiveEmployees = new Label();
            label3 = new Label();
            labelTitle = new Label();
            panelChart = new Panel();
            cardTotal.SuspendLayout();
            cardActive.SuspendLayout();
            cardInactive.SuspendLayout();
            SuspendLayout();
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.FromArgb(85, 45, 223);
            cardTotal.Controls.Add(icon1);
            cardTotal.Controls.Add(lblTotalEmployees);
            cardTotal.Controls.Add(label1);
            cardTotal.Location = new Point(35, 90);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(260, 140);
            cardTotal.TabIndex = 1;
            // 
            // icon1
            // 
            icon1.Location = new Point(0, 0);
            icon1.Name = "icon1";
            icon1.Size = new Size(100, 23);
            icon1.TabIndex = 0;
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalEmployees.ForeColor = Color.White;
            lblTotalEmployees.Location = new Point(15, 70);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(230, 50);
            lblTotalEmployees.TabIndex = 1;
            lblTotalEmployees.Text = "0";
            lblTotalEmployees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "TỔNG NHÂN VIÊN";
            // 
            // cardActive
            // 
            cardActive.BackColor = Color.FromArgb(0, 184, 148);
            cardActive.Controls.Add(icon2);
            cardActive.Controls.Add(lblActiveEmployees);
            cardActive.Controls.Add(label2);
            cardActive.Location = new Point(315, 90);
            cardActive.Name = "cardActive";
            cardActive.Size = new Size(260, 140);
            cardActive.TabIndex = 2;
            // 
            // icon2
            // 
            icon2.Location = new Point(0, 0);
            icon2.Name = "icon2";
            icon2.Size = new Size(100, 23);
            icon2.TabIndex = 0;
            // 
            // lblActiveEmployees
            // 
            lblActiveEmployees.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblActiveEmployees.ForeColor = Color.White;
            lblActiveEmployees.Location = new Point(15, 70);
            lblActiveEmployees.Name = "lblActiveEmployees";
            lblActiveEmployees.Size = new Size(230, 50);
            lblActiveEmployees.TabIndex = 1;
            lblActiveEmployees.Text = "0";
            lblActiveEmployees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 23);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "ĐANG LÀM VIỆC";
            label2.Click += label2_Click;
            // 
            // cardInactive
            // 
            cardInactive.BackColor = Color.FromArgb(214, 48, 49);
            cardInactive.Controls.Add(icon3);
            cardInactive.Controls.Add(lblInactiveEmployees);
            cardInactive.Controls.Add(label3);
            cardInactive.Location = new Point(595, 90);
            cardInactive.Name = "cardInactive";
            cardInactive.Size = new Size(260, 140);
            cardInactive.TabIndex = 3;
            // 
            // icon3
            // 
            icon3.Location = new Point(0, 0);
            icon3.Name = "icon3";
            icon3.Size = new Size(100, 23);
            icon3.TabIndex = 0;
            // 
            // lblInactiveEmployees
            // 
            lblInactiveEmployees.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblInactiveEmployees.ForeColor = Color.White;
            lblInactiveEmployees.Location = new Point(15, 70);
            lblInactiveEmployees.Name = "lblInactiveEmployees";
            lblInactiveEmployees.Size = new Size(230, 50);
            lblInactiveEmployees.TabIndex = 1;
            lblInactiveEmployees.Text = "0";
            lblInactiveEmployees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 23);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "ĐÃ NGHỈ VIỆC";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(33, 11, 97);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(375, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "BẢNG ĐIỀU KHIỂN";
            // 
            // panelChart
            // 
            panelChart.Location = new Point(315, 271);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(260, 251);
            panelChart.TabIndex = 4;
            panelChart.Paint += panelChart_Paint;
            // 
            // UC_Dashboard
            // 
            BackColor = Color.White;
            Controls.Add(labelTitle);
            Controls.Add(cardTotal);
            Controls.Add(cardActive);
            Controls.Add(cardInactive);
            Controls.Add(panelChart);
            Name = "UC_Dashboard";
            Size = new Size(900, 600);
            cardTotal.ResumeLayout(false);
            cardActive.ResumeLayout(false);
            cardInactive.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label icon1;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblActiveEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label icon2;
        private System.Windows.Forms.Panel cardInactive;
        private System.Windows.Forms.Label lblInactiveEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label icon3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelChart;
    }
}