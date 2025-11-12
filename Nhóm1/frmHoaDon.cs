using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Nhóm1
{
    public partial class frmHoaDon : Form
    {
        private readonly string connectionString =
            @"Data Source=NgocTuan\NGOCTUAN;Initial Catalog=ShoeShop;Integrated Security=True";

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // Đặt ngày mặc định
            dateTimePicker2.Value = DateTime.Now;            // Hôm nay
            dateTimePicker1.Value = new DateTime(2000, 1, 1);

            // (phần code còn lại giữ nguyên)
            StyleDataGridView(dgvBill);
            StyleDataGridView(dgvBillDetail);
            cbLoaiHoaDon.Items.Add("Tất cả");
            cbLoaiHoaDon.Items.Add("Hóa đơn nhập");
            cbLoaiHoaDon.Items.Add("Hóa đơn xuất");
            cbLoaiHoaDon.SelectedIndex = 0;
            LoadBillList();
        }


        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        // ===========================
        // 📋 Tải danh sách hóa đơn
        // ===========================
        private void LoadBillList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        b.ID AS [Mã Hóa Đơn],
                        b.BillType AS [Loại Hóa Đơn],
                        ISNULL(a.Username, N'(Không có tài khoản)') AS [Tài Khoản],
                        ISNULL(e.FullName, N'(Không xác định)') AS [Nhân Viên],
                        ISNULL(br.Name, N'(Không có)') AS [Nhà Cung Cấp],
                        FORMAT(b.Date, 'dd/MM/yyyy HH:mm') AS [Ngày Lập],
                        CAST(b.Total AS DECIMAL(18,2)) AS [Tổng Tiền],
                        ISNULL(b.Note, N'') AS [Ghi Chú]
                    FROM dbo.Bill AS b
                    LEFT JOIN dbo.Account AS a ON b.AccountID = a.ID
                    LEFT JOIN dbo.Employee AS e ON a.ID = e.AccountID
                    LEFT JOIN dbo.Brand AS br ON b.BrandID = br.ID
                    WHERE b.Date BETWEEN @from AND @to
                ";

                // Lọc loại hóa đơn theo combobox
                if (cbLoaiHoaDon.SelectedIndex == 1)
                    query += " AND b.BillType = 'Import'";
                else if (cbLoaiHoaDon.SelectedIndex == 2)
                    query += " AND b.BillType = 'Export'";

                query += " ORDER BY b.Date DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@to", dateTimePicker2.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBill.DataSource = dt;

                if (dgvBill.Columns.Contains("Tổng Tiền"))
                {
                    dgvBill.Columns["Tổng Tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBill.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";
                }

                if (dgvBill.Columns.Contains("Ngày Lập"))
                    dgvBill.Columns["Ngày Lập"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (dgvBill.Columns.Contains("Loại Hóa Đơn"))
                    dgvBill.Columns["Loại Hóa Đơn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // ===========================
        // 🧾 Tải chi tiết hóa đơn
        // ===========================
        private void LoadBillDetail(int billID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        bd.ItemID AS [Mã Sản Phẩm],
                        i.Name AS [Tên Sản Phẩm],
                        bd.Quantity AS [Số Lượng],
                        CAST(bd.Price AS DECIMAL(18,2)) AS [Đơn Giá],
                        CAST(bd.Quantity * bd.Price AS DECIMAL(18,2)) AS [Thành Tiền]
                    FROM dbo.BillDetail AS bd
                    INNER JOIN dbo.Item AS i ON bd.ItemID = i.ID
                    WHERE bd.BillID = @billID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@billID", billID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBillDetail.DataSource = dt;

                if (dgvBillDetail.Columns.Contains("Đơn Giá"))
                    dgvBillDetail.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";

                if (dgvBillDetail.Columns.Contains("Thành Tiền"))
                    dgvBillDetail.Columns["Thành Tiền"].DefaultCellStyle.Format = "N0";
            }
        }

        // ===========================
        // 📌 Sự kiện click bảng hóa đơn
        // ===========================
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cell = dgvBill.Rows[e.RowIndex].Cells["Mã Hóa Đơn"].Value;
                if (cell == null || cell == DBNull.Value) return;

                int billID = Convert.ToInt32(cell);
                labelBillDetail.Text = $"Chi tiết hóa đơn #{billID}";
                LoadBillDetail(billID);
            }
        }

        // ===========================
        // 🔍 Nút tìm kiếm
        // ===========================
        private void pbTimKiem_Click(object sender, EventArgs e)
        {
            LoadBillList();
        }

        // ===========================
        // 🔄 Thay đổi loại hóa đơn
        // ===========================
        private void cbLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBillList();
        }

        // ===========================
        // 🖨️ In hóa đơn
        // ===========================
        private void pbTaoPhieu_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int billID = Convert.ToInt32(dgvBill.SelectedRows[0].Cells["Mã Hóa Đơn"].Value);
            frmInHoaDon frm = new frmInHoaDon(billID);
            frm.ShowDialog();
        }
    }
}
