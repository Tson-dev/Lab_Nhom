namespace Nhóm1
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.palSignIn = new System.Windows.Forms.Panel();
            this.cbHienPass = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbxSignIn = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.palSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // palSignIn
            // 
            this.palSignIn.BackColor = System.Drawing.Color.AliceBlue;
            this.palSignIn.Controls.Add(this.cbHienPass);
            this.palSignIn.Controls.Add(this.btnSignIn);
            this.palSignIn.Controls.Add(this.txtPassword);
            this.palSignIn.Controls.Add(this.lblMatKhau);
            this.palSignIn.Controls.Add(this.txtUsername);
            this.palSignIn.Controls.Add(this.lblDangNhap);
            this.palSignIn.Controls.Add(this.lblWelcome);
            this.palSignIn.Controls.Add(this.pbxSignIn);
            this.palSignIn.Location = new System.Drawing.Point(80, 58);
            this.palSignIn.Name = "palSignIn";
            this.palSignIn.Size = new System.Drawing.Size(651, 376);
            this.palSignIn.TabIndex = 0;
            // 
            // cbHienPass
            // 
            this.cbHienPass.AutoSize = true;
            this.cbHienPass.Location = new System.Drawing.Point(500, 240);
            this.cbHienPass.Name = "cbHienPass";
            this.cbHienPass.Size = new System.Drawing.Size(109, 17);
            this.cbHienPass.TabIndex = 7;
            this.cbHienPass.Text = "Hiển thị mật khẩu";
            this.cbHienPass.UseVisualStyleBackColor = true;
            this.cbHienPass.CheckedChanged += new System.EventHandler(this.cbHienMk_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(333, 262);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(138, 38);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(333, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(276, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(329, 179);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(83, 21);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(333, 119);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.Location = new System.Drawing.Point(329, 95);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(129, 21);
            this.lblDangNhap.TabIndex = 2;
            this.lblDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblWelcome.Location = new System.Drawing.Point(414, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(121, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // pbxSignIn
            // 
            this.pbxSignIn.Image = ((System.Drawing.Image)(resources.GetObject("pbxSignIn.Image")));
            this.pbxSignIn.Location = new System.Drawing.Point(61, 95);
            this.pbxSignIn.Name = "pbxSignIn";
            this.pbxSignIn.Size = new System.Drawing.Size(167, 162);
            this.pbxSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSignIn.TabIndex = 0;
            this.pbxSignIn.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(789, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 24);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(826, 488);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.palSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.palSignIn.ResumeLayout(false);
            this.palSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palSignIn;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbxSignIn;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.CheckBox cbHienPass;
    }
}

