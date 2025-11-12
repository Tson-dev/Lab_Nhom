using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmBrand : Form
    {
        private string oldName = "";
        public string SelectedName { get; private set; }

        public frmBrand()
        {
            InitializeComponent();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            LoadBrand();
        }

        private void LoadBrand(string timkiem = "")
        {
            string query = "SELECT Name AS [Brand], Phone AS [Phone], Email FROM Brand";
            if (!string.IsNullOrEmpty(timkiem))
                query += " WHERE Name LIKE @SearchTerm";

            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(timkiem))
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + timkiem + "%");

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBrand.DataSource = dt;
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadBrand(txtFind.Text.Trim());
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvBrand.Rows[e.RowIndex];
                txtName.Text = row.Cells["Brand"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                oldName = txtName.Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldName))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để cập nhật!");
                return;
            }

            string query = "UPDATE Brand SET [Name] = @newName, Phone = @Phone, Email = @Email WHERE [Name] = @oldName";
            using (SqlConnection conn = Connection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@oldName", oldName);
                cmd.Parameters.AddWithValue("@newName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                LoadBrand();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = Connection.GetConnection())
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Brand WHERE [Name] = @Name", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa!");
                    LoadBrand();
                }
            }
        }

        private void btnDefalut_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            oldName = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvBrand.SelectedRows.Count > 0)
            {
                SelectedName = dgvBrand.SelectedRows[0].Cells["Nhà cung cấp"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
