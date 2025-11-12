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
    public partial class frmTrangChu : Form
    {
        public static string userRole;
        public frmTrangChu()
        {
            InitializeComponent();
        }

        public frmTrangChu(string ur)
        {
            InitializeComponent();
            userRole = ur;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                btnBanSanPham.Enabled = true;
                btnNhapSanPham.Enabled = true;
                btnNhanVien.Enabled = true;
                btnThongKe.Enabled = true;
                btnNhanVien.Enabled = true;
                btnHoaDon.Enabled = true;
                btnSanPham.Enabled = true;
            }
            else if (userRole == "Sales")
            {
                btnBanSanPham.Enabled = false;
                btnNhapSanPham.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
                btnHoaDon.Enabled = false;
                btnSanPham.Enabled = true;
            }
            else if (userRole == "Manager")
            {
                btnBanSanPham.Enabled = true;
                btnNhapSanPham.Enabled = true;
                btnNhanVien.Enabled = true;
                btnThongKe.Enabled = true;
                btnNhanVien.Enabled = false;
                btnHoaDon.Enabled = true;
                btnSanPham.Enabled = true;
            }
            else if (userRole == "Cashier")
            {
                btnBanSanPham.Enabled = true;
                btnNhapSanPham.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
                btnHoaDon.Enabled = true;
                btnSanPham.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanSanPham());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        bool menuExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                Phong.Width -= 10;
                if (Phong.Width <= 61)
                {
                    menuExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                Phong.Width += 10;
                if (Phong.Width >= 203)
                {
                    menuExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private Form currnetFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currnetFormChild != null)
            {
                currnetFormChild.Close();
            }
            currnetFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void btnNhapSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham());
        }

        private void btnSanPham_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.Color.DarkTurquoise;
        }

        private void btnSanPham_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.Color.PaleTurquoise;
        }

        private void btnBanSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanSanPham());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham());
        }

        private bool lblDanhSach_Click(object sender, EventArgs e, Form frm)
        {
            return true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStatictis());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            DialogResult rs =MessageBox.Show("Bạn chắc chắn muốn đăng xuất?","Đăng xuất",MessageBoxButtons.YesNo);
            if (rs != DialogResult.No)
                return;
            frmDangNhap form = new frmDangNhap();
            form.Show();
            this.Close();
        }
    }
}
