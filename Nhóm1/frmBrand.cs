using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmBrand : Form
    {
        private string Name_Cu = "";
        public string SelectedName { get; private set; }

        public frmBrand()
        {
            InitializeComponent();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            LoadNhaCC();
        }

        private void LoadNhaCC(string timkiem = "")
        {
            string query = "SELECT Name AS [Nhà cung cấp], Phone AS [Số điện thoại], Email FROM Brand";
            if (!string.IsNullOrEmpty(timkiem))
                query += " WHERE Name LIKE @SearchTerm";

            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(timkiem))
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + timkiem + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataNCC.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Cảnh báo");
                return;
            }

            string query = "INSERT INTO Brand (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(Phone) ? (object)DBNull.Value : Phone);
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);
                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    SelectedName = Name;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadNhaCC(txtNCC.Text.Trim());
        }

        private void dataNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataNCC.Rows[e.RowIndex];
                txtName.Text = row.Cells["Nhà cung cấp"].Value.ToString();
                txtPhone.Text = row.Cells["Số điện thoại"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                Name_Cu = txtName.Text;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_Cu))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để cập nhật!");
                return;
            }

            string query = "UPDATE Brand SET Name=@NameMoi, Phone=@Phone, Email=@Email WHERE Name=@NameCu";
            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NameCu", Name_Cu);
                cmd.Parameters.AddWithValue("@NameMoi", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                LoadNhaCC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = Connection.GetConnection())
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Brand WHERE Name=@Name", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa!");
                    LoadNhaCC();
                }
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            Name_Cu = "";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dataNCC.SelectedRows.Count > 0)
            {
                SelectedName = dataNCC.SelectedRows[0].Cells["Nhà cung cấp"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
