using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
