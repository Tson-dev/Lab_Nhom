using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhóm1
{
    public partial class Tạo_tài_khoản : Form
    {
        public Tạo_tài_khoản()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=NgocTuan\NGOCTUAN;Initial Catalog=ShoeShop;Integrated Security=True";

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
                txtXacNhan.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXacNhan.PasswordChar = '*';

            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string id = txtDangNhap1.Text;
            if (id.Length != 10)
            {
                MessageBox.Show("ID phải dài 10 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (id.Substring(0, 2) != "AD"
                && id.Substring(0, 2) != "NV")
            {
                MessageBox.Show("ID phải bắt đầu bằng \"AD\" (Cho quản lý) hoặc \"NV\" (Cho nhân viên)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txtMatKhau.Text;
            string confirmPassword = txtXacNhan.Text;
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert vào Acc trước
                    string queryAcc = "INSERT INTO Acc (ID, Pass) VALUES (@ID, @Pass)";
                    using (SqlCommand cmdAcc = new SqlCommand(queryAcc, conn, transaction))
                    {
                        cmdAcc.Parameters.AddWithValue("@ID", id);
                        cmdAcc.Parameters.AddWithValue("@Pass", password);
                        cmdAcc.ExecuteNonQuery();
                    }

                    // 2. Insert vào NhanVien sau
                    string queryNV = "INSERT INTO NhanVien (ID, Name, Gender, BornDate, Addr, SDT, Email, Type) " +
                                     "VALUES (@ID, NULL, NULL, NULL, NULL, NULL, NULL, NULL)";
                    using (SqlCommand cmdNV = new SqlCommand(queryNV, conn, transaction))
                    {
                        cmdNV.Parameters.AddWithValue("@ID", id);
                        cmdNV.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Tạo tài khoản và nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmNhanVien f = new frmNhanVien();
                    f.Show();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    if (ex.Number == 2627) // Trùng khóa chính
                    {
                        MessageBox.Show("ID đã tồn tại. Vui lòng chọn ID khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tạo tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Tạo_tài_khoản_Load(object sender, EventArgs e)
        {
            
        }
    }
}
