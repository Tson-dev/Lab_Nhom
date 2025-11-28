namespace Nhóm1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.palMenu = new System.Windows.Forms.Panel();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.floPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxProd = new System.Windows.Forms.PictureBox();
            this.btnProd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxSell = new System.Windows.Forms.PictureBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbxStorge = new System.Windows.Forms.PictureBox();
            this.btnStorge = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxBill = new System.Windows.Forms.PictureBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pbxEmployee = new System.Windows.Forms.PictureBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pixStatictis = new System.Windows.Forms.PictureBox();
            this.btnStatictis = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            this.palMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            this.floPhong.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSell)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStorge)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBill)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixStatictis)).BeginInit();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // palMenu
            // 
            this.palMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.palMenu.Controls.Add(this.lblDanhSach);
            this.palMenu.Controls.Add(this.pbxMenu);
            this.palMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.palMenu.Location = new System.Drawing.Point(0, 0);
            this.palMenu.Name = "palMenu";
            this.palMenu.Size = new System.Drawing.Size(1301, 40);
            this.palMenu.TabIndex = 0;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(67, 9);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(122, 22);
            this.lblDanhSach.TabIndex = 1;
            this.lblDanhSach.Text = "DANH SÁCH";
            // 
            // pbxMenu
            // 
            this.pbxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenu.Image")));
            this.pbxMenu.Location = new System.Drawing.Point(0, 0);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(61, 40);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu.TabIndex = 1;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // floPhong
            // 
            this.floPhong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.floPhong.Controls.Add(this.panel2);
            this.floPhong.Controls.Add(this.panel3);
            this.floPhong.Controls.Add(this.panel4);
            this.floPhong.Controls.Add(this.panel5);
            this.floPhong.Controls.Add(this.panel7);
            this.floPhong.Controls.Add(this.panel8);
            this.floPhong.Controls.Add(this.btnSignOut);
            this.floPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.floPhong.Location = new System.Drawing.Point(0, 40);
            this.floPhong.Name = "floPhong";
            this.floPhong.Size = new System.Drawing.Size(202, 654);
            this.floPhong.TabIndex = 1;
            this.floPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxProd);
            this.panel2.Controls.Add(this.btnProd);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 60);
            this.panel2.TabIndex = 2;
            // 
            // pbxProd
            // 
            this.pbxProd.Image = ((System.Drawing.Image)(resources.GetObject("pbxProd.Image")));
            this.pbxProd.Location = new System.Drawing.Point(1, 3);
            this.pbxProd.Name = "pbxProd";
            this.pbxProd.Size = new System.Drawing.Size(57, 54);
            this.pbxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProd.TabIndex = 4;
            this.pbxProd.TabStop = false;
            this.pbxProd.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.Black;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(-3, 0);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(200, 60);
            this.btnProd.TabIndex = 0;
            this.btnProd.Text = "Sản phẩm";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnSanPham_Click);
            this.btnProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSanPham_MouseDown);
            this.btnProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSanPham_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbxSell);
            this.panel3.Controls.Add(this.btnSell);
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 58);
            this.panel3.TabIndex = 2;
            // 
            // pbxSell
            // 
            this.pbxSell.Image = ((System.Drawing.Image)(resources.GetObject("pbxSell.Image")));
            this.pbxSell.Location = new System.Drawing.Point(0, 3);
            this.pbxSell.Name = "pbxSell";
            this.pbxSell.Size = new System.Drawing.Size(57, 54);
            this.pbxSell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSell.TabIndex = 3;
            this.pbxSell.TabStop = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSell.Location = new System.Drawing.Point(-3, 0);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(200, 58);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "        Bán sản phẩm";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnBanSanPham_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbxStorge);
            this.panel4.Controls.Add(this.btnStorge);
            this.panel4.Location = new System.Drawing.Point(3, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 64);
            this.panel4.TabIndex = 2;
            // 
            // pbxStorge
            // 
            this.pbxStorge.Image = ((System.Drawing.Image)(resources.GetObject("pbxStorge.Image")));
            this.pbxStorge.Location = new System.Drawing.Point(0, 7);
            this.pbxStorge.Name = "pbxStorge";
            this.pbxStorge.Size = new System.Drawing.Size(57, 54);
            this.pbxStorge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStorge.TabIndex = 2;
            this.pbxStorge.TabStop = false;
            // 
            // btnStorge
            // 
            this.btnStorge.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStorge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorge.Location = new System.Drawing.Point(-3, 0);
            this.btnStorge.Name = "btnStorge";
            this.btnStorge.Size = new System.Drawing.Size(200, 64);
            this.btnStorge.TabIndex = 3;
            this.btnStorge.Text = "Nhà kho";
            this.btnStorge.UseVisualStyleBackColor = false;
            this.btnStorge.Click += new System.EventHandler(this.btnNhapSanPham_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbxBill);
            this.panel5.Controls.Add(this.btnBill);
            this.panel5.Location = new System.Drawing.Point(3, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 64);
            this.panel5.TabIndex = 3;
            // 
            // pbxBill
            // 
            this.pbxBill.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pbxBill.Image = ((System.Drawing.Image)(resources.GetObject("pbxBill.Image")));
            this.pbxBill.Location = new System.Drawing.Point(3, 11);
            this.pbxBill.Name = "pbxBill";
            this.pbxBill.Size = new System.Drawing.Size(54, 50);
            this.pbxBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBill.TabIndex = 2;
            this.pbxBill.TabStop = false;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(-3, 0);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(200, 64);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Hóa Đơn";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pbxEmployee);
            this.panel7.Controls.Add(this.btnEmployee);
            this.panel7.Location = new System.Drawing.Point(3, 273);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 64);
            this.panel7.TabIndex = 4;
            // 
            // pbxEmployee
            // 
            this.pbxEmployee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pbxEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbxEmployee.Image")));
            this.pbxEmployee.Location = new System.Drawing.Point(4, 11);
            this.pbxEmployee.Name = "pbxEmployee";
            this.pbxEmployee.Size = new System.Drawing.Size(54, 50);
            this.pbxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployee.TabIndex = 4;
            this.pbxEmployee.TabStop = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(-3, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 64);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Nhân Viên";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pixStatictis);
            this.panel8.Controls.Add(this.btnStatictis);
            this.panel8.Location = new System.Drawing.Point(3, 343);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 64);
            this.panel8.TabIndex = 5;
            // 
            // pixStatictis
            // 
            this.pixStatictis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pixStatictis.Image = ((System.Drawing.Image)(resources.GetObject("pixStatictis.Image")));
            this.pixStatictis.Location = new System.Drawing.Point(3, 3);
            this.pixStatictis.Name = "pixStatictis";
            this.pixStatictis.Size = new System.Drawing.Size(53, 58);
            this.pixStatictis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pixStatictis.TabIndex = 6;
            this.pixStatictis.TabStop = false;
            this.pixStatictis.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btnStatictis
            // 
            this.btnStatictis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStatictis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatictis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatictis.Location = new System.Drawing.Point(0, 0);
            this.btnStatictis.Name = "btnStatictis";
            this.btnStatictis.Size = new System.Drawing.Size(197, 64);
            this.btnStatictis.TabIndex = 3;
            this.btnStatictis.Text = "Thống kê";
            this.btnStatictis.UseVisualStyleBackColor = false;
            this.btnStatictis.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(3, 413);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(197, 64);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(471, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Trang chủ";
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.lblTitle);
            this.panel_body.Controls.Add(this.pbxBackground);
            this.panel_body.Location = new System.Drawing.Point(207, 43);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1093, 651);
            this.panel_body.TabIndex = 2;
            // 
            // pbxBackground
            // 
            this.pbxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbxBackground.Image")));
            this.pbxBackground.Location = new System.Drawing.Point(-1, -3);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(1094, 651);
            this.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBackground.TabIndex = 0;
            this.pbxBackground.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 694);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.floPhong);
            this.Controls.Add(this.palMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giày Dép";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.palMenu.ResumeLayout(false);
            this.palMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            this.floPhong.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProd)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSell)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStorge)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBill)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pixStatictis)).EndInit();
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMenu;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.FlowLayoutPanel floPhong;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxStorge;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.PictureBox pbxSell;
        private System.Windows.Forms.PictureBox pbxProd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStorge;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.PictureBox pbxBill;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.PictureBox pbxEmployee;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnStatictis;
        private System.Windows.Forms.PictureBox pixStatictis;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pbxBackground;
    }
}