using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Nhóm1
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=NgocTuan\NGOCTUAN;Initial Catalog=ShoeShop;Integrated Security=True";
        List<string> selectedEmployee = new List<string>();

        // ============================ LOAD FORM ============================
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadEmployeeList();
            btnLamMoi_Click(sender, e);

            // Placeholder tìm kiếm
            txtTimKiem.Text = "Nhập tên hoặc ID để tìm";
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Enter += (s, ev) =>
            {
                if (txtTimKiem.Text == "Nhập tên hoặc ID để tìm")
                {
                    txtTimKiem.Text = "";
                    txtTimKiem.ForeColor = Color.Black;
                }
            };
            txtTimKiem.Leave += (s, ev) =>
            {
                if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    txtTimKiem.Text = "Nhập tên hoặc ID để tìm";
                    txtTimKiem.ForeColor = Color.Gray;
                }
            };
        }

        // ============================ LOAD ROLE ============================
        private void LoadRoles()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, RoleName FROM Role";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbLoaiNV.DataSource = dt;
                cbLoaiNV.DisplayMember = "RoleName";
                cbLoaiNV.ValueMember = "ID";
                cbLoaiNV.SelectedIndex = -1;
            }
        }

        // ============================ LOAD EMPLOYEES ============================
        private void LoadEmployeeList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT e.ID, e.FullName, e.Gender, e.BirthDate, e.Phone, e.Address, e.Email, r.RoleName 
                FROM Employee e
                LEFT JOIN Role r ON e.RoleID = r.ID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDSNV.DataSource = dt;
            }

            dataDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDSNV.ReadOnly = true;
            dataDSNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ============================ SEARCH ============================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string inf = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(inf) || inf == "Nhập tên hoặc ID để tìm")
            {
                LoadEmployeeList();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = rdID.Checked
                    ? @"SELECT e.ID, e.FullName, e.Gender, e.BirthDate, e.Phone, e.Address, e.Email, r.RoleName 
                       FROM Employee e LEFT JOIN Role r ON e.RoleID = r.ID
                       WHERE CAST(e.ID AS NVARCHAR) LIKE @inf"
                    : @"SELECT e.ID, e.FullName, e.Gender, e.BirthDate, e.Phone, e.Address, e.Email, r.RoleName 
                       FROM Employee e LEFT JOIN Role r ON e.RoleID = r.ID
                       WHERE e.FullName LIKE @inf";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@inf", "%" + inf + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDSNV.DataSource = dt;
            }
        }

        // ============================ REFRESH ============================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            selectedEmployee.Clear();
            txtTenNV.Clear();
            cbGioiTinh.SelectedIndex = -1;
            cbLoaiNV.SelectedIndex = -1;
            dateNgaySinh.Value = DateTime.Now;
            txtSDT.Clear();
            txtEmail.Clear();
            txtAddr.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLamMoi1_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
            btnLamMoi_Click(sender, e);
        }

        // ============================ SELECT ROW ============================
        private void dataDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataDSNV.Rows[e.RowIndex];
                if (row.Cells["ID"].Value == null) return;

                selectedEmployee.Clear();
                selectedEmployee.Add(row.Cells["ID"].Value.ToString());

                txtTenNV.Text = row.Cells["FullName"].Value?.ToString();
                cbGioiTinh.Text = row.Cells["Gender"].Value?.ToString();
                txtSDT.Text = row.Cells["Phone"].Value?.ToString();
                txtAddr.Text = row.Cells["Address"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["BirthDate"].Value?.ToString(), out DateTime birth))
                    dateNgaySinh.Value = birth;

                cbLoaiNV.Text = row.Cells["RoleName"].Value?.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // ============================ UPDATE EMPLOYEE ============================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.Count == 0) return;

            string id = selectedEmployee[0];
            string name = txtTenNV.Text.Trim();
            string gender = cbGioiTinh.Text;
            int roleID = (int)cbLoaiNV.SelectedValue;
            string phone = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddr.Text.Trim();
            string birthDate = dateNgaySinh.Value.ToString("yyyy-MM-dd");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Employee
                                 SET FullName = @Name, Gender = @Gender, RoleID = @RoleID,
                                     BirthDate = @BirthDate, Phone = @Phone, Email = @Email, Address = @Address
                                 WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@RoleID", roleID);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployeeList();
        }

        // ============================ DELETE EMPLOYEE ============================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.Count == 0) return;
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", selectedEmployee[0]);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployeeList();
            btnLamMoi_Click(sender, e);
        }

        // ============================ ADD NEW ============================
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Tạo_tài_khoản tk = new Tạo_tài_khoản();
            tk.Show();
            this.Hide();
        }
    }
}
