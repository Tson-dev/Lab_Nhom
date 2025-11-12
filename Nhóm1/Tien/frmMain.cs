using System;
using System.Windows.Forms;

namespace Nhóm1
{
    public partial class frmMain : Form
    {
        public static string userRole;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string ur)
        {
            InitializeComponent();
            userRole = ur;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                btnSell.Enabled = true;
                btnStorge.Enabled = true;
                btnEmployee.Enabled = true;
                btnStatictis.Enabled = true;
                btnEmployee.Enabled = true;
                btnBill.Enabled = true;
                btnProd.Enabled = true;
            }
            else if (userRole == "Sales")
            {
                btnSell.Enabled = false;
                btnStorge.Enabled = false;
                btnEmployee.Enabled = false;
                btnStatictis.Enabled = false;
                btnEmployee.Enabled = false;
                btnBill.Enabled = false;
                btnProd.Enabled = true;
            }
            else if (userRole == "Manager")
            {
                btnSell.Enabled = true;
                btnStorge.Enabled = true;
                btnEmployee.Enabled = true;
                btnStatictis.Enabled = true;
                btnEmployee.Enabled = false;
                btnBill.Enabled = true;
                btnProd.Enabled = true;
            }
            else if (userRole == "Cashier")
            {
                btnSell.Enabled = true;
                btnStorge.Enabled = false;
                btnEmployee.Enabled = false;
                btnStatictis.Enabled = false;
                btnEmployee.Enabled = false;
                btnBill.Enabled = true;
                btnProd.Enabled = true;
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
                floPhong.Width -= 10;
                if (floPhong.Width <= 61)
                {
                    menuExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                floPhong.Width += 10;
                if (floPhong.Width >= 203)
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
            OpenChildForm(new frmProd());
        }

        private void btnSanPham_MouseDown(object sender, MouseEventArgs e)
        {
            pbxProd.BackColor = System.Drawing.Color.DarkTurquoise;
        }

        private void btnSanPham_MouseUp(object sender, MouseEventArgs e)
        {
            pbxProd.BackColor = System.Drawing.Color.PaleTurquoise;
        }

        private void btnBanSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanSanPham());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProd());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            DialogResult rs =MessageBox.Show("Bạn chắc chắn muốn đăng xuất?","Đăng xuất",MessageBoxButtons.YesNo);
            if (rs == DialogResult.No)
                return;
            frmDangNhap form = new frmDangNhap();
            form.Show();
            this.Close();
        }
    }
}
