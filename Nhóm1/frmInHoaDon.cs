using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmInHoaDon : Form
    {
        private int billID; // Mã hóa đơn được truyền vào
       
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        public frmInHoaDon(int billID)
        {
            InitializeComponent();
            this.billID = billID;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            LoadBillInfo();
            LoadBillDetail();
        }

        // ======================================
        // 🔹 LOAD THÔNG TIN HÓA ĐƠN
        // ======================================
        private void LoadBillInfo()
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"
                    SELECT b.ID, b.Date, b.Total, a.ID AS AccID, a.Password
                    FROM dbo.Bill AS b
                    LEFT JOIN dbo.Account AS a ON a.ID = b.AccountID
                    WHERE b.ID = @billID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@billID", billID);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMaHD.Text = "Mã hóa đơn: " + reader["ID"].ToString();
                    lblTaiKhoan.Text = "Tài khoản: " + reader["AccID"].ToString();
                    lblNgayLap.Text = "Ngày lập: " + Convert.ToDateTime(reader["Date"]).ToString("dd/MM/yyyy");
                    lblTongTien.Text = "Tổng cộng: " + Convert.ToDecimal(reader["Total"]).ToString("N0") + " VNĐ";
                }
                conn.Close();
            }
        }

        // ======================================
        // 🔹 LOAD CHI TIẾT HÓA ĐƠN
        // ======================================
        private void LoadBillDetail()
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"
                    SELECT i.Name AS [Tên Sản Phẩm],
                           bd.Quantity AS [Số Lượng],
                           bd.Price AS [Đơn Giá],
                           (bd.Quantity * bd.Price) AS [Thành Tiền]
                    FROM dbo.BillDetail AS bd
                    INNER JOIN dbo.Item AS i ON bd.ItemID = i.ID
                    WHERE bd.BillID = @billID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@billID", billID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvChiTiet.DataSource = dt;
                dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvChiTiet.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["Thành Tiền"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["Đơn Giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvChiTiet.Columns["Thành Tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvChiTiet.Columns["Số Lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // ======================================
        // 🔹 IN HÓA ĐƠN
        // ======================================
        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                ev.Graphics.DrawImage(bmp, 0, 0);
            };

            printDialog.Document = doc;
            if (printDialog.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
    }
}
