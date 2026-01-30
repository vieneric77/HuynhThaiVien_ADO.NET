using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADONET.Data;

namespace ADONET.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        private int total = 0, active = 0, inactive = 0;

        public UC_Dashboard()
        {
            InitializeComponent();
            DisplayData();
        }

        private int GetCount(string query)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch { return 0; }
        }

        public void DisplayData()
        {
            // Lấy dữ liệu thực tế từ SQL
            total = GetCount("SELECT COUNT(*) FROM nhan_vien");
            active = GetCount("SELECT COUNT(*) FROM nhan_vien WHERE trang_thai = N'Đang làm việc'");
            inactive = GetCount("SELECT COUNT(*) FROM nhan_vien WHERE trang_thai = N'Đã nghỉ việc'");

            // Hiển thị lên Labels
            lblTotalEmployees.Text = total.ToString();
            lblActiveEmployees.Text = active.ToString();
            lblInactiveEmployees.Text = inactive.ToString();

            // Làm mới biểu đồ
            panelChart.Invalidate();
        }

        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (total == 0) return;

            // Tính toán tỷ lệ góc quay cho biểu đồ
            float angleActive = (float)active / total * 360;
            float angleInactive = (float)inactive / total * 360;

            Rectangle rect = new Rectangle(20, 20, 220, 220);

            // Vẽ phần Đang làm việc (Màu Xanh)
            using (SolidBrush bActive = new SolidBrush(Color.FromArgb(0, 184, 148)))
                g.FillPie(bActive, rect, -90, angleActive);

            // Vẽ phần Đã nghỉ việc (Màu Đỏ)
            using (SolidBrush bInactive = new SolidBrush(Color.FromArgb(214, 48, 49)))
                g.FillPie(bInactive, rect, -90 + angleActive, angleInactive);

            // Vẽ hình tròn đè lên để tạo hiệu ứng Donut Chart
            g.FillEllipse(new SolidBrush(Color.White), 65, 65, 130, 130);

            // Vẽ chữ ở giữa biểu đồ
            string txt = "TỶ LỆ %";
            Font f = new Font("Segoe UI", 10, FontStyle.Bold);
            SizeF sz = g.MeasureString(txt, f);
            g.DrawString(txt, f, Brushes.Gray, 130 - sz.Width / 2, 130 - sz.Height / 2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}