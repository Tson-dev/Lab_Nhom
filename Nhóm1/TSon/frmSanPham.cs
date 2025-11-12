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
    public partial class frmProd : Form
    {
        public frmProd()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            txtFind.Text = "Nhập tên để tìm";
            txtFind.ForeColor = Color.Gray;
            txtFind.Enter += (s, ev) =>
            {
                if (txtFind.Text == "Nhập tên để tìm")
                {
                    txtFind.Text = "";
                    txtFind.ForeColor = Color.Black;
                }
            };
            txtFind.Leave += (s, ev) =>
            {
                if (string.IsNullOrEmpty(txtFind.Text))
                {
                    txtFind.Text = "Nhập tên để tìm";
                    txtFind.ForeColor = Color.Gray;
                }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
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

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
