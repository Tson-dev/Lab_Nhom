using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmKho : Form
    {       
        private DataTable dtChiTietNhapTam;

        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dgvProd.AutoGenerateColumns = false;
            dgvProd.ReadOnly = true;
            dgvProd.AllowUserToAddRows = false;
            dgvProd.AllowUserToDeleteRows = false;

            dgvProd.DataSource = LoadProd(null);
            LoadNhaCungCap();

            dtChiTietNhapTam = new DataTable();
            dtChiTietNhapTam.Columns.Add("ID", typeof(int));
            dtChiTietNhapTam.Columns.Add("Tên sản phẩm", typeof(string));
            dtChiTietNhapTam.Columns.Add("Số lượng nhập", typeof(int));
            dtChiTietNhapTam.Columns.Add("Giá nhập", typeof(decimal));
            dtChiTietNhapTam.Columns.Add("Tổng tiền", typeof(decimal));

            dgvTTPhieu.DataSource = dtChiTietNhapTam;
        }

        private DataTable LoadProd(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    i.ID, 
                    i.Name AS [Tên sản phẩm],
                    t.Name AS [Loại],
                    i.Price AS [Giá bán],
                    i.Stock AS [Số lượng tồn],
                    b.Name AS [Thương hiệu]
                FROM Item i
                INNER JOIN Brand b ON i.BrandID = b.ID
                INNER JOIN Type t ON i.TypeID = t.ID
                " + (string.IsNullOrEmpty(keyword) ? "" : "WHERE i.Name LIKE @Keyword OR b.Name LIKE @Keyword");

            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(keyword))
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        private void LoadNhaCungCap()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT Name FROM Brand", conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            cbxBrand.DataSource = dt;
            cbxBrand.DisplayMember = "Name";
            cbxBrand.ValueMember = "Name";
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProd.Rows[e.RowIndex];
                txtID.Text = row.Cells["colMaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["colTenSP"].Value.ToString();
                cbxBrand.Text = row.Cells["colThuongHieu"].Value.ToString();
                txtPrice.Text = row.Cells["colGiaBan"].Value.ToString();
                txtStock.Text = row.Cells["colSoLuong"].Value.ToString();
                cbxImport.Text = "1";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dgvProd.DataSource = LoadProd(keyword);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            string loai = "Shoes";
            int brandID = GetBrandID(cbxBrand.Text),
                typeID = GetTypeID(loai);

            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo");
                return;
            }

            if (brandID == 0)
            {
                MessageBox.Show("Thương hiệu không hợp lệ!", "Lỗi");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Giá bán phải là số dương hợp lệ!", "Cảnh báo");
                return;
            }

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                string query = @"
                    INSERT INTO Item (Name, Gender, Age, TypeID, Price, Stock, BrandID)
                    VALUES (@Name, 0, '18', @TypeID, @Price, 0, @BrandID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", tenSP);
                cmd.Parameters.AddWithValue("@TypeID", typeID);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@BrandID", brandID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show($"✅ Đã thêm sản phẩm '{tenSP}' với giá {price:N0} VNĐ!");
            dgvProd.DataSource = LoadProd(null);
            txtTenSP.Clear();
            txtPrice.Clear();
        }

        private int GetBrandID(string brandName)
        {
            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Brand WHERE [Name] = @Name", conn))
            {
                cmd.Parameters.AddWithValue("@Name", brandName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int GetTypeID(string typeName)
        {
            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT ID FROM [Type] WHERE [Name] = @Name", conn))
            {
                cmd.Parameters.AddWithValue("@Name", typeName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo");
                return;
            }

            DataGridViewRow selectedRow = dgvProd.SelectedRows[0];
            string maSP = selectedRow.Cells["colMaSP"].Value.ToString();
            string tenSP = selectedRow.Cells["colTenSP"].Value.ToString();
            decimal giaNhap = Convert.ToDecimal(selectedRow.Cells["colGiaBan"].Value) * 0.8m;
            int soLuong = int.TryParse(cbxImport.Text, out int sl) ? sl : 1;

            DataRow existingRow = dtChiTietNhapTam.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("Tên sản phẩm") == tenSP);

            if (existingRow != null)
            {
                existingRow["Số lượng nhập"] = (int)existingRow["Số lượng nhập"] + soLuong;
                existingRow["Tổng tiền"] = Convert.ToDecimal(existingRow["Số lượng nhập"]) * giaNhap;
            }
            else
            {
                DataRow newRow = dtChiTietNhapTam.NewRow();
                newRow["ID"] = Convert.ToInt32(maSP);
                newRow["Tên sản phẩm"] = tenSP;
                newRow["Số lượng nhập"] = soLuong;
                newRow["Giá nhập"] = giaNhap;
                newRow["Tổng tiền"] = soLuong * giaNhap;
                dtChiTietNhapTam.Rows.Add(newRow);
            }

            dtChiTietNhapTam.AcceptChanges();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dtChiTietNhapTam.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong phiếu.", "Thông báo");
                return;
            }

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertBill = @"
                        INSERT INTO Bill (AccountID, Date, Total, BillType, BrandID)
                        OUTPUT INSERTED.ID
                        VALUES (1, GETDATE(), @Total, 'Import', @BrandID)";
                    SqlCommand cmd = new SqlCommand(insertBill, conn, transaction);
                    decimal total = dtChiTietNhapTam.AsEnumerable().Sum(r => r.Field<decimal>("Tổng tiền"));
                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Parameters.AddWithValue("@BrandID", GetBrandID(cbxBrand.Text));

                    int billID = (int)cmd.ExecuteScalar();

                    foreach (DataRow row in dtChiTietNhapTam.Rows)
                    {
                        int itemID = Convert.ToInt32(row["ID"]);
                        int soLuongNhap = Convert.ToInt32(row["Số lượng nhập"]);
                        decimal giaNhap = Convert.ToDecimal(row["Giá nhập"]);

                        string insertDetail = "INSERT INTO BillDetail (BillID, ItemID, Quantity, Price) VALUES (@BillID, @ItemID, @Quantity, @Price)";
                        SqlCommand cmdDetail = new SqlCommand(insertDetail, conn, transaction);
                        cmdDetail.Parameters.AddWithValue("@BillID", billID);
                        cmdDetail.Parameters.AddWithValue("@ItemID", itemID);
                        cmdDetail.Parameters.AddWithValue("@Quantity", soLuongNhap);
                        cmdDetail.Parameters.AddWithValue("@Price", giaNhap);
                        cmdDetail.ExecuteNonQuery();

                        string updateStock = "UPDATE Item SET Stock = Stock + @Quantity WHERE ID = @ItemID";
                        SqlCommand cmdStock = new SqlCommand(updateStock, conn, transaction);
                        cmdStock.Parameters.AddWithValue("@Quantity", soLuongNhap);
                        cmdStock.Parameters.AddWithValue("@ItemID", itemID);
                        cmdStock.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("✅ Phiếu nhập hàng đã được lưu và tồn kho đã được cập nhật!", "Thành công");
                    dtChiTietNhapTam.Rows.Clear();
                    dgvProd.DataSource = LoadProd(null);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("❌ Lỗi khi lưu phiếu nhập: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(frm.SelectedName))
            {
                LoadNhaCungCap();
                cbxBrand.Text = frm.SelectedName;
            }
            else
            {
                LoadNhaCungCap();
            }
        }
    }
}
