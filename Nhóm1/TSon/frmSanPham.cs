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
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên để tìm";
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Enter += (s, ev) =>
            {
                if (txtTimKiem.Text == "Nhập tên để tìm")
                {
                    txtTimKiem.Text = "";
                    txtTimKiem.ForeColor = Color.Black;
                }
            };
            txtTimKiem.Leave += (s, ev) =>
            {
                if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    txtTimKiem.Text = "Nhập tên để tìm";
                    txtTimKiem.ForeColor = Color.Gray;
                }
            };
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void cmsCategory_tsiAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmsCategory_tsiOpen_Click(object sender, EventArgs e)
        {

        }

        private void cmsBrand_tsiAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmsBrand_tsiOpen_Click(object sender, EventArgs e)
        {
            frmBrand frmBrand = new frmBrand();
            frmBrand.Show(this);
        }

        private void dataSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadForm()
        {
            using(SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select i.ID, i.[Name], i.Age, i.[Type], i.Price, i.Stock, b.[Name] as BrandName from item i join Brand b on i.BrandID = b.ID", conn);
                conn.Open();

            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
