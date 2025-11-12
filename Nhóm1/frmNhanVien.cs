using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmNhanVien : Form
    {
        private bool isUpdatingCheck = false; // 🧱 tránh vòng lặp CheckedChanged
        private List<string> selectedEmployee = new List<string>();

        public frmNhanVien()
        {
            InitializeComponent();
        }

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
            using (SqlConnection conn = Connection.GetConnection())
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
            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"
                    SELECT 
                        e.ID,
                        e.FullName,
                        e.Gender,
                        e.BirthDate,
                        e.Phone,
                        e.Address,
                        e.Email,
                        r.RoleName,
                        a.Username,
                        a.Password,
                        a.Active
                    FROM Employee e
                    LEFT JOIN Role r ON e.RoleID = r.ID
                    LEFT JOIN Account a ON e.AccountID = a.ID";

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

            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = rdID.Checked
                    ? @"SELECT e.ID, e.FullName, e.Gender, e.BirthDate, e.Phone, e.Address, e.Email, r.RoleName, a.Username, a.Password, a.Active
                       FROM Employee e 
                       LEFT JOIN Role r ON e.RoleID = r.ID
                       LEFT JOIN Account a ON e.AccountID = a.ID
                       WHERE CAST(e.ID AS NVARCHAR) LIKE @inf"
                    : @"SELECT e.ID, e.FullName, e.Gender, e.BirthDate, e.Phone, e.Address, e.Email, r.RoleName, a.Username, a.Password, a.Active
                       FROM Employee e 
                       LEFT JOIN Role r ON e.RoleID = r.ID
                       LEFT JOIN Account a ON e.AccountID = a.ID
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
            txtUsername.Clear();
            txtPassword.Clear();
            cbGioiTinh.SelectedIndex = -1;
            cbLoaiNV.SelectedIndex = -1;
            dateNgaySinh.Value = DateTime.Now;
            txtSDT.Clear();
            txtEmail.Clear();
            txtAddr.Clear();
            ckActive.Checked = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnRSPass.Enabled = false;

            LoadEmployeeList();
        }

        // ============================ SELECT ROW ============================
        private void dataDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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
            txtUsername.Text = row.Cells["Username"].Value?.ToString();
            txtPassword.Text = row.Cells["Password"].Value?.ToString();

            bool isActive = Convert.ToBoolean(row.Cells["Active"].Value ?? false);
            isUpdatingCheck = true; // ⚠️ tránh trigger sự kiện
            ckActive.Checked = isActive;
            isUpdatingCheck = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRSPass.Enabled = true;
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
            string username = txtUsername.Text.Trim();

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string query = @"UPDATE Employee
                                     SET FullName=@Name, Gender=@Gender, RoleID=@RoleID,
                                         BirthDate=@BirthDate, Phone=@Phone, Email=@Email, Address=@Address
                                     WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn, tran);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);
                    cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();

                    string queryAcc = @"
                        UPDATE a
                        SET a.Username=@Username
                        FROM Account a
                        INNER JOIN Employee e ON a.ID=e.AccountID
                        WHERE e.ID=@EmpID";
                    SqlCommand cmdAcc = new SqlCommand(queryAcc, conn, tran);
                    cmdAcc.Parameters.AddWithValue("@Username", username);
                    cmdAcc.Parameters.AddWithValue("@EmpID", id);
                    cmdAcc.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadEmployeeList();
        }

        // ============================ DELETE EMPLOYEE ============================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.Count == 0) return;
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = "DELETE FROM Employee WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", selectedEmployee[0]);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }

        // ============================ RESET PASSWORD ============================
        private void btnRSPass_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.Count == 0) return;
            string id = selectedEmployee[0];

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                string query = @"
                    UPDATE a
                    SET a.Password='123456'
                    FROM Account a
                    INNER JOIN Employee e ON a.ID=e.AccountID
                    WHERE e.ID=@EmpID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã reset mật khẩu: 123456", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployeeList();
        }

        // ============================ ACTIVE CHECK ============================
        private void ckActive_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingCheck) return;
            if (selectedEmployee.Count == 0) return;

            bool newState = ckActive.Checked;
            int empID = int.Parse(selectedEmployee[0]);

            using (SqlConnection conn = Connection.GetConnection())
            {
                string query = @"
                    UPDATE a
                    SET a.Active=@State
                    FROM Account a
                    INNER JOIN Employee e ON a.ID=e.AccountID
                    WHERE e.ID=@EmpID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", empID);
                cmd.Parameters.AddWithValue("@State", newState ? 1 : 0);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                newState ? "Đã kích hoạt tài khoản!" : "Đã hủy kích hoạt tài khoản!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadEmployeeList();
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
