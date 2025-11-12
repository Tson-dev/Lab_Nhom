namespace Nhóm1
{
    partial class frmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.palDangKy = new System.Windows.Forms.Panel();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.cbxHienThi = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxDangKy = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.palDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // palDangKy
            // 
            this.palDangKy.BackColor = System.Drawing.Color.AliceBlue;
            this.palDangKy.Controls.Add(this.txtXacNhan);
            this.palDangKy.Controls.Add(this.lblXacNhan);
            this.palDangKy.Controls.Add(this.cbxHienThi);
            this.palDangKy.Controls.Add(this.btnDangKy);
            this.palDangKy.Controls.Add(this.txtMatKhau);
            this.palDangKy.Controls.Add(this.lblMatKhau);
            this.palDangKy.Controls.Add(this.txtUsername);
            this.palDangKy.Controls.Add(this.lblUsername);
            this.palDangKy.Controls.Add(this.label1);
            this.palDangKy.Controls.Add(this.pbxDangKy);
            this.palDangKy.Location = new System.Drawing.Point(72, 53);
            this.palDangKy.Name = "palDangKy";
            this.palDangKy.Size = new System.Drawing.Size(651, 413);
            this.palDangKy.TabIndex = 1;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.Location = new System.Drawing.Point(333, 240);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '*';
            this.txtXacNhan.Size = new System.Drawing.Size(276, 25);
            this.txtXacNhan.TabIndex = 11;
            // 
            // lblXacNhan
            // 
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhan.Location = new System.Drawing.Point(329, 204);
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.Size = new System.Drawing.Size(152, 21);
            this.lblXacNhan.TabIndex = 10;
            this.lblXacNhan.Text = "Xác nhận mật khẩu";
            // 
            // cbxHienThi
            // 
            this.cbxHienThi.AutoSize = true;
            this.cbxHienThi.Location = new System.Drawing.Point(500, 277);
            this.cbxHienThi.Name = "cbxHienThi";
            this.cbxHienThi.Size = new System.Drawing.Size(109, 17);
            this.cbxHienThi.TabIndex = 7;
            this.cbxHienThi.Text = "Hiển thị mật khẩu";
            this.cbxHienThi.UseVisualStyleBackColor = true;
            this.cbxHienThi.CheckedChanged += new System.EventHandler(this.cbxHienThi_CheckedChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(343, 305);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(138, 38);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(333, 156);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(276, 25);
            this.txtMatKhau.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(329, 132);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(83, 21);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(333, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(329, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo tài khoản";
            // 
            // pbxDangKy
            // 
            this.pbxDangKy.Image = ((System.Drawing.Image)(resources.GetObject("pbxDangKy.Image")));
            this.pbxDangKy.Location = new System.Drawing.Point(61, 95);
            this.pbxDangKy.Name = "pbxDangKy";
            this.pbxDangKy.Size = new System.Drawing.Size(167, 162);
            this.pbxDangKy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDangKy.TabIndex = 0;
            this.pbxDangKy.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(757, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 24);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(794, 510);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.palDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.palDangKy.ResumeLayout(false);
            this.palDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palDangKy;
        private System.Windows.Forms.CheckBox cbxHienThi;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxDangKy;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.Label lblExit;
    }
}