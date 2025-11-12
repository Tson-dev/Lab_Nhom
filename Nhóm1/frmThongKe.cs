using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAccess;

namespace Nhóm1
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // Load danh sách năm (từ dữ liệu có trong Bill)
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT DISTINCT YEAR(Date) AS Nam FROM Bill ORDER BY Nam DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbNam.DataSource = dt;
                cbNam.DisplayMember = "Nam";
                cbNam.ValueMember = "Nam";
            }

            if (cbNam.Items.Count > 0)
                cbNam.SelectedIndex = 0;

            LoadThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            if (cbNam.SelectedValue == null) return;
            int nam = Convert.ToInt32(cbNam.SelectedValue);

            DataTable dt = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"
                SELECT 
                    MONTH(Date) AS Thang,
                    SUM(CASE WHEN BillType = 'Export' THEN Total ELSE 0 END) AS TongExport,
                    SUM(CASE WHEN BillType = 'Import' THEN Total ELSE 0 END) AS TongImport
                FROM Bill
                WHERE YEAR(Date) = @Nam
                GROUP BY MONTH(Date)
                ORDER BY Thang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nam", nam);
                da.Fill(dt);
            }

            // Vẽ biểu đồ
            chartThongKe.Series.Clear();
            chartThongKe.ChartAreas[0].AxisX.Title = "Tháng";
            chartThongKe.ChartAreas[0].AxisY.Title = "Giá trị (VNĐ)";
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;

            Series sExport = new Series("Doanh thu (Export)");
            sExport.ChartType = SeriesChartType.Area;
            sExport.Color = System.Drawing.Color.FromArgb(100, 46, 204, 113);
            sExport.BorderWidth = 2;

            Series sImport = new Series("Nhập hàng (Import)");
            sImport.ChartType = SeriesChartType.Area;
            sImport.Color = System.Drawing.Color.FromArgb(100, 52, 152, 219);
            sImport.BorderWidth = 2;

            decimal tongXuat = 0, tongNhap = 0;
            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                decimal export = row["TongExport"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongExport"]);
                decimal import = row["TongImport"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongImport"]);
                sExport.Points.AddXY(thang, export);
                sImport.Points.AddXY(thang, import);
                tongXuat += export;
                tongNhap += import;
            }

            chartThongKe.Series.Add(sExport);
            chartThongKe.Series.Add(sImport);

            // Cập nhật thống kê tổng
            lblTongDoanhThu.Text = $"{tongXuat:N0} VNĐ";
            lblTongNhap.Text = $"{tongNhap:N0} VNĐ";
            lblLoiNhuan.Text = $"{(tongXuat - tongNhap):N0} VNĐ";

            LoadTopSanPham();
        }

        private void LoadTopSanPham()
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();

                string queryTop = @"
                SELECT TOP 5 i.Name AS [Sản phẩm], SUM(bd.Quantity) AS [Số lượng bán], N'Bán chạy' AS [Loại]
                FROM BillDetail bd
                INNER JOIN Bill b ON bd.BillID = b.ID
                INNER JOIN Item i ON bd.ItemID = i.ID
                WHERE b.BillType = 'Export'
                GROUP BY i.Name
                UNION ALL
                SELECT TOP 5 i.Name AS [Sản phẩm], SUM(bd.Quantity) AS [Số lượng bán], N'Nhập nhiều' AS [Loại]
                FROM BillDetail bd
                INNER JOIN Bill b ON bd.BillID = b.ID
                INNER JOIN Item i ON bd.ItemID = i.ID
                WHERE b.BillType = 'Import'
                GROUP BY i.Name";

                SqlDataAdapter da = new SqlDataAdapter(queryTop, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSanPham.DataSource = dt;
            }

            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ReadOnly = true;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
