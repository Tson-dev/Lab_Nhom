using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '*';

            cbHienPass.CheckedChanged += cbHienMk_CheckedChanged;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo");
                return;
            }

            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT a.Role, a.Active FROM Account as a WHERE Username = @user AND Password=@pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        bool active = Convert.ToBoolean(reader["Active"]);
                        string role = reader["Role"].ToString();

                        if (!active)
                        {
                            MessageBox.Show("Tài khoản này đã bị khóa!", "Cảnh báo");
                            return;
                        }

                        MessageBox.Show($"Đăng nhập thành công! Tài khoản: {role}", "Thành công");

                        frmMain tt = new frmMain(role);
                        tt.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
   
        private void cbHienMk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
