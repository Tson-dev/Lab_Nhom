using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            bool hien = cbxHienThi.Checked;
            txtMatKhau.PasswordChar = hien ? '\0' : '*';
            txtXacNhan.PasswordChar = hien ? '\0' : '*';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string confirmPassword = txtXacNhan.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = "";
            if (username.StartsWith("AD", StringComparison.OrdinalIgnoreCase))
                role = "Admin";
            else if (username.StartsWith("NV", StringComparison.OrdinalIgnoreCase))
                role = "Sales";
            else
            {
                MessageBox.Show("Tên đăng nhập phải bắt đầu bằng \"AD\" (Admin) hoặc \"NV\" (Nhân viên).",
                                "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryAcc = @"
                        INSERT INTO Account (Username, Password, Role, Active)
                        VALUES (@Username, @Password, @Role, 1);
                        SELECT SCOPE_IDENTITY();";
                    int newAccountId;

                    using (SqlCommand cmd = new SqlCommand(queryAcc, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        newAccountId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string queryEmp = @"
                        INSERT INTO Employee (FullName, Gender, BirthDate, Address, Phone, Email, RoleID, AccountID)
                        VALUES (NULL, NULL, NULL, NULL, NULL, NULL, 
                            (SELECT ID FROM Role WHERE RoleName = @RoleName), @AccountID)";
                    using (SqlCommand cmd = new SqlCommand(queryEmp, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RoleName", role);
                        cmd.Parameters.AddWithValue("@AccountID", newAccountId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Tạo tài khoản thành công!", "Thành công",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmNhanVien f = new frmNhanVien();
                    f.Show();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    if (ex.Number == 2627 || ex.Number == 2601)
                        MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Lỗi khi tạo tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
