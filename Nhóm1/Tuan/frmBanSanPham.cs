using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmBanSanPham : Form
    {
        public frmBanSanPham()
        {
            InitializeComponent();
        }

        List<string> sp = new List<string>();
        List<string> gioHang = new List<string>();

        #region Query
        static string basequery = @"
                            SELECT i.ID, i.Name, 
                                CASE i.Gender 
                                    WHEN 0 THEN N'Unisex' 
                                    WHEN 1 THEN N'Nữ' 
                                   WHEN 2 THEN N'Nam' 
                                END AS Gender,
                                CASE i.Age 
                                    WHEN 'u5' THEN N'Em bé' 
                                    WHEN 'u11' THEN N'Trẻ em' 
                                    WHEN 'u18' THEN N'Thiếu niên' 
                                    WHEN '18' THEN N'Trưởng thành' 
                                END AS Age,
                                t.Name AS TypeName,
                                i.Price,
                                i.Stock,
                                b.Name AS BrandName
                            FROM Item AS i
                            INNER JOIN Brand AS b ON i.BrandID = b.ID
                            INNER JOIN [Type] t ON i.TypeID = t.ID
                            ";

        static string queryFName = basequery + " Where LOWER(Name) LIKE LOWER(@tenSP)";
        #endregion Query

        #region Method
        private void frmBanSanPham_Load(object sender, EventArgs e)
        {
            LoadDataSanPham();
            LoadclbBrand();
            LoadclbType();
        }

        public void LoadDataSanPham()
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(basequery, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDSSP.DataSource = dt;
                conn.Close();
            }
        }

        public void LoadclbBrand()
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                clbBrand.Items.Clear();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM Brand", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clbBrand.DataSource = dt;
                clbBrand.DisplayMember = "Name";
                conn.Close();
            }
        }

        public void LoadclbType()
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                clbKieu.Items.Clear();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM [Type]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    clbKieu.Items.Add(row["Name"].ToString());
                }
                conn.Close();
            }
        }

        private void dataDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataDSSP.Rows[e.RowIndex];
                if (row.IsNewRow)
                    return;
                if (row.Cells[6].Value.Equals(0))
                {
                    MessageBox.Show("Sản phẩm đã hết hàng");
                    return;
                }

                sp.Clear();
                sp.Add(row.Cells["ID"].Value.ToString());       // sp[0]
                sp.Add(row.Cells["NameSP"].Value.ToString());   // sp[1]
                sp.Add(row.Cells["Gender"].Value.ToString());   // sp[2]
                sp.Add(row.Cells["Age"].Value.ToString());      // sp[3]
                sp.Add(row.Cells["Type"].Value.ToString());     // sp[4]
                sp.Add(row.Cells["Price"].Value.ToString());    // sp[5]
                sp.Add(row.Cells["Stock"].Value.ToString());    // sp[6]
                sp.Add(row.Cells["BrandName"].Value.ToString());  // sp[7]


                if (!kiemTraTrung(sp[0]))
                {
                    dgvGioHang.Rows.Add(sp[0], sp[1], sp[6], 1, sp[5], int.Parse(sp[5]));
                }
                else
                {
                    foreach (DataGridViewRow r in dgvGioHang.Rows)
                    {
                        if (r.Cells[0].Value.ToString() == sp[0])
                        {
                            int soLuong = int.Parse(r.Cells[3].Value.ToString());
                            if (soLuong < int.Parse(sp[6]))
                            {
                                soLuong++;
                                r.Cells[3].Value = soLuong;
                                r.Cells[5].Value = soLuong * int.Parse(sp[5]);
                            }
                            else
                            {
                                MessageBox.Show("Số lượng sản phẩm trong kho không đủ");
                            }
                            break;
                        }
                    }
                }
                decimal tongTien = dgvGioHang.Rows.Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[5].Value != null)
                                    .Sum(r => Convert.ToDecimal(r.Cells[5].Value));
                lblTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
        }

        private bool kiemTraTrung(string id)
        {
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[0].Value == null || row.Cells[0].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            btnGioHang.PerformClick();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();

            if (pnLoc.Visible == true)
            {
                string qr = "";
                LayIn4Loc(sender, e, ref qr);
                MessageBox.Show(qr);
                if (tenSP != "")
                {
                    string tenHang = txtHang.Text.Trim();
                    using (SqlConnection conn = Connection.GetConnection())
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(queryFName + qr, conn);
                        da.SelectCommand.Parameters.AddWithValue("@tenSP", "%" + tenSP + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataDSSP.DataSource = dt;
                        conn.Close();
                    }
                }
                else if (qr == " Where")
                {
                    using (SqlConnection conn = Connection.GetConnection())
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(basequery, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataDSSP.DataSource = dt;
                        conn.Close();
                    }
                }
                else
                {
                    //MessageBox.Show("Vui lòng nhập tên sản phẩm, hoặc chọn các tiêu chí trong mục lọc để tìm kiểm sản phẩm", "Thông báo");
                    using (SqlConnection conn = Connection.GetConnection())
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(basequery + qr, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataDSSP.DataSource = dt;
                        conn.Close();
                    }
                }
            }
            else
            {
                string tenHang = txtHang.Text.Trim();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(queryFName, conn);
                    da.SelectCommand.Parameters.AddWithValue("@tenSP", "%" + tenSP + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataDSSP.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void LayIn4Loc(object sender, EventArgs e, ref string qr)
        {
            qr = " Where";

            if (txtTu.Text != "" && txtDen.Text != "")
            {
                if (int.Parse(txtTu.Text) > int.Parse(txtDen.Text))
                {
                    MessageBox.Show("Giá từ phải nhỏ hơn giá đến");
                    return;
                }
                else if (int.Parse(txtTu.Text) < 0 || int.Parse(txtDen.Text) < 0)
                {
                    MessageBox.Show("Giá không được âm");
                    return;
                }
                else
                {
                    string giaTu = txtTu.Text.Trim();
                    string giaDen = txtDen.Text.Trim();
                    qr += " Price >= " + giaTu + " And Price <= " + giaDen;
                }
            }
            //KieuDang
            List<string> kieuDang = new List<string>();
            foreach (var item in clbKieu.CheckedItems)
            {
                kieuDang.Add(item.ToString());
            }
            if (kieuDang.Count > 0)
            {
                if (qr != " Where")
                {
                    qr += " And (";
                }
                else
                {
                    qr += " (";
                }
                for (int i = 0; i < kieuDang.Count; i++)
                {
                    if (i == kieuDang.Count - 1)
                    {
                        qr += " TypeName = N'" + kieuDang[i] + "') ";
                    }
                    else
                    {
                        qr += " TypeName = N'" + kieuDang[i] + "' Or";
                    }
                }
            }
            //DoTuoi
            List<string> doTuoi = new List<string>();
            foreach (var item in clbAge.CheckedItems)
            {
                if (item.ToString() == "Em bé") doTuoi.Add("u5");
                if (item.ToString() == "Trẻ em") doTuoi.Add("u11");
                if (item.ToString() == "Thiếu niên") doTuoi.Add("u18");
                if (item.ToString() == "Trưởng thành") doTuoi.Add("18");
            }
            if (doTuoi.Count > 0)
            {
                if (qr != " Where")
                {
                    qr += " And (";
                }
                else
                {
                    qr += " (";
                }
                for (int i = 0; i < doTuoi.Count; i++)
                {
                    if (i == doTuoi.Count - 1)
                    {
                        qr += " Age = '" + doTuoi[i] + "') ";
                    }
                    else
                    {
                        qr += " Age = '" + doTuoi[i] + "' Or";
                    }
                }
            }
            //Hang
            List<string> hang = new List<string>();
            int index = -1;

            if (index == -1 && clbBrand.Items.Count > 0)
                index = clbBrand.Items.Count - 1;

            foreach (var item in clbBrand.SelectedItems)
            {
                hang.Add(item.ToString());
                MessageBox.Show(item.ToString());
            }
            if (clbBrand.GetItemChecked(index))
            {
                hang.Add(txtHang.Text.Trim());
            }
            if (hang.Count > 0)
            {
                if (qr != " Where")
                {
                    qr += " And (";
                }
                else
                {
                    qr += " (";
                }
                for (int i = 0; i < hang.Count; i++)
                {
                    if (i == hang.Count - 1)
                    {
                        qr += " IDBr = N'" + hang[i] + "') ";
                    }
                    else
                    {
                        qr += " IDBr = N'" + hang[i] + "' Or";
                    }
                }
            }
            //Gender
            List<string> gd = new List<string>();
            foreach (var item in clbGender.CheckedItems)
            {
                if (item.ToString() == "Unisex") gd.Add("0");
                if (item.ToString() == "Nữ") gd.Add("1");
                if (item.ToString() == "Nam") gd.Add("2");
            }
            if (gd.Count > 0)
            {
                if (qr != " Where")
                {
                    qr += " And (";
                }
                else
                {
                    qr += " (";
                }
                for (int i = 0; i < gd.Count; i++)
                {
                    if (i == gd.Count - 1)
                    {
                        qr += " Gender = '" + gd[i] + "') ";
                    }
                    else
                    {
                        qr += " Gender = '" + gd[i] + "' Or";
                    }
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (pnLoc.Visible != true)
            {
                pnLoc.Visible = true;
                btnLoc.Text = "Đóng";
            }
            else
            {
                pnLoc.Visible = false;
                btnLoc.Text = "Lọc";
            }
            if(PNGioHang.Visible == true)
            {
                PNGioHang.Visible = false;
                btnGioHang.Text = "Giỏ hàng";
            }
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            if (PNGioHang.Visible != true)
            {
                PNGioHang.Visible = true;
                btnGioHang.Text = "Đóng giỏ hàng";
            }
            else
            {
                PNGioHang.Visible = false;
                btnGioHang.Text = "Giỏ hàng";
            }
            if (pnLoc.Visible == true)
            {
                pnLoc.Visible = false;
                btnLoc.Text = "Lọc";
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearPNLoc();
            txtTenSP.Text = "";
            frmBanSanPham_Load(sender, e);
        }

        private void ClearPNLoc()
        {
            txtTu.Text = "";
            txtDen.Text = "";

            for (int i = 0; i < clbKieu.Items.Count; i++)
            {
                clbKieu.SetItemChecked(i, false);
            }

            for (int i = 0; i < clbAge.Items.Count; i++)
            {
                clbAge.SetItemChecked(i, false);
            }

            for (int i = 0; i < clbBrand.Items.Count; i++)
            {
                clbBrand.SetItemChecked(i, false);
            }
            txtHang.Text = "";

            for (int i = 0; i < clbGender.Items.Count; i++)
            {
                clbGender.SetItemChecked(i, false);
            }
        }

        private void dgvGioHang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvGioHang.Rows[e.RowIndex].IsNewRow)
                return;

            var row = dgvGioHang.Rows[e.RowIndex];
            if (dgvGioHang.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                if (!int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int newValue) || newValue < 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên dương).",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells["SoLuong"].Value = 1;
                    return;
                }

                // Nếu nhập = 0 thì xóa dòng (dùng BeginInvoke để tránh lỗi InvalidOperationException)
                if (newValue == 0)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        if (e.RowIndex >= 0 && e.RowIndex < dgvGioHang.Rows.Count)
                        {
                            dgvGioHang.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Đã xóa sản phẩm.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }));
                    return;
                }

                // Kiểm tra số lượng tồn kho
                if (!int.TryParse(row.Cells["StockGH"].Value?.ToString(), out int stock))
                    stock = 0;

                if (newValue > stock)
                {
                    MessageBox.Show($"Số lượng trong kho không đủ. Tối đa có thể mua: {stock}.",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells["SoLuong"].Value = stock; // set về tối đa
                    newValue = stock;
                }

                // Cập nhật thành tiền (nếu có cột Giá và ThànhTiền)
                if (row.Cells[4].Value != null)
                {
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal gia))
                    {
                        row.Cells[5].Value = newValue * gia;
                    }
                }

                // Cập nhật tổng tiền giỏ hàng
                if (dgvGioHang.Columns.Contains("ThanhTien"))
                {
                    decimal tongTien = dgvGioHang.Rows.Cast<DataGridViewRow>()
                                        .Where(r => r.Cells[5].Value != null)
                                        .Sum(r => Convert.ToDecimal(r.Cells[5].Value));
                    lblTien.Text = tongTien.ToString("N0") + " VNĐ";
                }
            }
        }

        private void cmnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?",
                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvGioHang.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvGioHang.Rows.Remove(row);
                    }
                }
                // Cập nhật tổng tiền giỏ hàng sau khi xóa
                decimal tongTien = dgvGioHang.Rows.Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[5].Value != null)
                                    .Sum(r => Convert.ToDecimal(r.Cells[5].Value));
                lblTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvGioHang.Rows.Clear();
        }

        private void mnuNhapSoLuong_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần nhập số lượng.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvGioHang.SelectedRows[0];
            string tenSP = row.Cells[1].Value.ToString();

            // Lấy số lượng hiện tại
            int soLuongHienTai = int.Parse(row.Cells[3].Value.ToString());

            // Hộp thoại nhập số lượng mới
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nhập số lượng mới cho sản phẩm:\n{tenSP}",
                "Nhập số lượng",
                soLuongHienTai.ToString());

            if (int.TryParse(input, out int soLuongMoi))
            {
                if (soLuongMoi <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy số lượng tồn kho từ cột 2 (Stock)
                int tonKho = int.Parse(row.Cells[2].Value.ToString());
                if (soLuongMoi > tonKho)
                {
                    MessageBox.Show("Số lượng vượt quá tồn kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật số lượng và thành tiền
                row.Cells[3].Value = soLuongMoi;
                decimal donGia = Convert.ToDecimal(row.Cells[4].Value);
                row.Cells[5].Value = soLuongMoi * donGia;

                CapNhatTongTien();
            }
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow r in dgvGioHang.Rows)
            {
                if (r.Cells[5].Value != null && decimal.TryParse(r.Cells[5].Value.ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            lblTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            string bt = "Export";
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống. Vui lòng chọn sản phẩm trước khi thanh toán.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn tạo hóa đơn cho đơn hàng này?",
                                                   "Xác nhận thanh toán",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Hỏi mã tài khoản người lập (AccID)
            string accInput = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập ID tài khoản (Account.ID) thực hiện giao dịch:",
                "Xác nhận tài khoản",
                "1"); // mặc định là 1 (admin)

            if (!int.TryParse(accInput, out int accID))
            {
                MessageBox.Show("❌ ID tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Thêm hóa đơn mới (Bill)
                    string insertBill = @"
                INSERT INTO Bill (AccountID,BillType, Date, Total)
                OUTPUT INSERTED.ID
                VALUES (@accID,@billtype, GETDATE(), 0)";
                    SqlCommand cmdBill = new SqlCommand(insertBill, conn, tran);
                    cmdBill.Parameters.AddWithValue("@accID", accID);
                    cmdBill.Parameters.AddWithValue("@billtype", bt);

                    int newBillID = Convert.ToInt32(cmdBill.ExecuteScalar());

                    // Thêm các dòng chi tiết hóa đơn (BillDetail)
                    decimal total = 0;
                    foreach (DataGridViewRow row in dgvGioHang.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int itemID = Convert.ToInt32(row.Cells[0].Value);
                        int quantity = Convert.ToInt32(row.Cells[3].Value);
                        int price = Convert.ToInt32(row.Cells[4].Value);

                        string insertDetail = @"
                    INSERT INTO BillDetail (BillID, ItemID, Quantity, Price)
                    VALUES (@bill, @item, @qty, @price)";
                        SqlCommand cmdDetail = new SqlCommand(insertDetail, conn, tran);
                        cmdDetail.Parameters.AddWithValue("@bill", newBillID);
                        cmdDetail.Parameters.AddWithValue("@item", itemID);
                        cmdDetail.Parameters.AddWithValue("@qty", quantity);
                        cmdDetail.Parameters.AddWithValue("@price", price);
                        cmdDetail.ExecuteNonQuery();

                        total += quantity * price;

                        // Trừ tồn kho trong Items
                        string updateStock = @"UPDATE Item SET Stock = Stock - @qty WHERE ID = @item";
                        SqlCommand cmdStock = new SqlCommand(updateStock, conn, tran);
                        cmdStock.Parameters.AddWithValue("@qty", quantity);
                        cmdStock.Parameters.AddWithValue("@item", itemID);
                        cmdStock.ExecuteNonQuery();
                    }

                    // Cập nhật tổng tiền hóa đơn
                    string updateTotal = @"UPDATE Bill SET Total = @total WHERE ID = @billID";
                    SqlCommand cmdTotal = new SqlCommand(updateTotal, conn, tran);
                    cmdTotal.Parameters.AddWithValue("@total", total);
                    cmdTotal.Parameters.AddWithValue("@billID", newBillID);
                    cmdTotal.ExecuteNonQuery();

                    // Commit transaction
                    tran.Commit();

                    MessageBox.Show($"Thanh toán thành công!\nMã hóa đơn: {newBillID}\nTổng tiền: {total:N0} VNĐ",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa giỏ hàng sau khi thanh toán
                    dgvGioHang.Rows.Clear();
                    lblTien.Text = "0 VNĐ";

                    // Hỏi có muốn in hóa đơn không
                    DialogResult print = MessageBox.Show("Bạn có muốn in hóa đơn ngay không?",
                                                         "In hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (print == DialogResult.Yes)
                    {
                        frmPrintBill frmIn = new frmPrintBill(newBillID);
                        frmIn.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion Method
    }
}
