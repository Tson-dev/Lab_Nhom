namespace Nhóm1
{
    partial class frmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gBDSNhanVien = new System.Windows.Forms.GroupBox();
            this.dataDSNV = new System.Windows.Forms.DataGridView();
            this.gBTimKiem = new System.Windows.Forms.GroupBox();
            this.rdID = new System.Windows.Forms.RadioButton();
            this.rdTimTheoTen = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.RichTextBox();
            this.lblLoaiNV = new System.Windows.Forms.Label();
            this.cbLoaiNV = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenVN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSNV)).BeginInit();
            this.gBTimKiem.SuspendLayout();
            this.gbThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBDSNhanVien
            // 
            this.gBDSNhanVien.Controls.Add(this.dataDSNV);
            this.gBDSNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gBDSNhanVien.Location = new System.Drawing.Point(359, 134);
            this.gBDSNhanVien.Name = "gBDSNhanVien";
            this.gBDSNhanVien.Size = new System.Drawing.Size(1089, 586);
            this.gBDSNhanVien.TabIndex = 1;
            this.gBDSNhanVien.TabStop = false;
            this.gBDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // dataDSNV
            // 
            this.dataDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Gender,
            this.BirthDate,
            this.Phone,
            this.Email,
            this.Address,
            this.RoleName});
            this.dataDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDSNV.Location = new System.Drawing.Point(3, 26);
            this.dataDSNV.Name = "dataDSNV";
            this.dataDSNV.ReadOnly = true;
            this.dataDSNV.RowHeadersWidth = 51;
            this.dataDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDSNV.Size = new System.Drawing.Size(1083, 557);
            this.dataDSNV.TabIndex = 0;
            this.dataDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSNV_CellClick);
            // 
            // gBTimKiem
            // 
            this.gBTimKiem.Controls.Add(this.rdID);
            this.gBTimKiem.Controls.Add(this.rdTimTheoTen);
            this.gBTimKiem.Controls.Add(this.txtTimKiem);
            this.gBTimKiem.Controls.Add(this.btnLamMoi1);
            this.gBTimKiem.Controls.Add(this.btnTimKiem);
            this.gBTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gBTimKiem.Location = new System.Drawing.Point(351, 2);
            this.gBTimKiem.Name = "gBTimKiem";
            this.gBTimKiem.Size = new System.Drawing.Size(778, 124);
            this.gBTimKiem.TabIndex = 17;
            this.gBTimKiem.TabStop = false;
            this.gBTimKiem.Text = "Tìm kiếm";
            // 
            // rdID
            // 
            this.rdID.AutoSize = true;
            this.rdID.Checked = true;
            this.rdID.Location = new System.Drawing.Point(448, 38);
            this.rdID.Name = "rdID";
            this.rdID.Size = new System.Drawing.Size(110, 29);
            this.rdID.TabIndex = 28;
            this.rdID.TabStop = true;
            this.rdID.Text = "Theo ID";
            this.rdID.UseVisualStyleBackColor = true;
            // 
            // rdTimTheoTen
            // 
            this.rdTimTheoTen.AutoSize = true;
            this.rdTimTheoTen.Location = new System.Drawing.Point(448, 80);
            this.rdTimTheoTen.Name = "rdTimTheoTen";
            this.rdTimTheoTen.Size = new System.Drawing.Size(153, 29);
            this.rdTimTheoTen.TabIndex = 27;
            this.rdTimTheoTen.Text = "Tìm theo tên";
            this.rdTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(434, 30);
            this.txtTimKiem.TabIndex = 26;
            // 
            // btnLamMoi1
            // 
            this.btnLamMoi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi1.Location = new System.Drawing.Point(618, 12);
            this.btnLamMoi1.Name = "btnLamMoi1";
            this.btnLamMoi1.Size = new System.Drawing.Size(160, 37);
            this.btnLamMoi1.TabIndex = 24;
            this.btnLamMoi1.Text = "Làm mới";
            this.btnLamMoi1.UseVisualStyleBackColor = true;
            this.btnLamMoi1.Click += new System.EventHandler(this.btnLamMoi1_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(282, 76);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 37);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbThongTinNV
            // 
            this.gbThongTinNV.Controls.Add(this.txtSDT);
            this.gbThongTinNV.Controls.Add(this.txtAddr);
            this.gbThongTinNV.Controls.Add(this.lblLoaiNV);
            this.gbThongTinNV.Controls.Add(this.cbLoaiNV);
            this.gbThongTinNV.Controls.Add(this.btnLamMoi);
            this.gbThongTinNV.Controls.Add(this.btnXoa);
            this.gbThongTinNV.Controls.Add(this.btnSua);
            this.gbThongTinNV.Controls.Add(this.txtEmail);
            this.gbThongTinNV.Controls.Add(this.cbGioiTinh);
            this.gbThongTinNV.Controls.Add(this.lblSDT);
            this.gbThongTinNV.Controls.Add(this.dateNgaySinh);
            this.gbThongTinNV.Controls.Add(this.lblNgaySinh);
            this.gbThongTinNV.Controls.Add(this.lblGioiTinh);
            this.gbThongTinNV.Controls.Add(this.txtTenNV);
            this.gbThongTinNV.Controls.Add(this.label3);
            this.gbThongTinNV.Controls.Add(this.label2);
            this.gbThongTinNV.Controls.Add(this.lblTenVN);
            this.gbThongTinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbThongTinNV.Location = new System.Drawing.Point(3, 2);
            this.gbThongTinNV.Name = "gbThongTinNV";
            this.gbThongTinNV.Size = new System.Drawing.Size(342, 718);
            this.gbThongTinNV.TabIndex = 18;
            this.gbThongTinNV.TabStop = false;
            this.gbThongTinNV.Text = "Thông tin nhân viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(10, 318);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(323, 30);
            this.txtSDT.TabIndex = 48;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(10, 442);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(323, 96);
            this.txtAddr.TabIndex = 47;
            this.txtAddr.Text = "";
            // 
            // lblLoaiNV
            // 
            this.lblLoaiNV.AutoSize = true;
            this.lblLoaiNV.Location = new System.Drawing.Point(9, 162);
            this.lblLoaiNV.Name = "lblLoaiNV";
            this.lblLoaiNV.Size = new System.Drawing.Size(92, 25);
            this.lblLoaiNV.TabIndex = 45;
            this.lblLoaiNV.Text = "Chức vụ";
            // 
            // cbLoaiNV
            // 
            this.cbLoaiNV.Items.AddRange(new object[] {
            "ADMIN",
            "Thu ngân",
            "Nhân viên"});
            this.cbLoaiNV.Location = new System.Drawing.Point(10, 188);
            this.cbLoaiNV.Name = "cbLoaiNV";
            this.cbLoaiNV.Size = new System.Drawing.Size(323, 33);
            this.cbLoaiNV.TabIndex = 44;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Location = new System.Drawing.Point(87, 606);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(161, 46);
            this.btnLamMoi.TabIndex = 42;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(174, 554);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 46);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(7, 554);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(161, 46);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 380);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 30);
            this.txtEmail.TabIndex = 38;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(10, 126);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(323, 33);
            this.cbGioiTinh.TabIndex = 35;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(9, 292);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(139, 25);
            this.lblSDT.TabIndex = 33;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(10, 254);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(323, 30);
            this.dateNgaySinh.TabIndex = 32;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(9, 225);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(108, 25);
            this.lblNgaySinh.TabIndex = 30;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(7, 98);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(91, 25);
            this.lblGioiTinh.TabIndex = 28;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(10, 65);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(323, 30);
            this.txtTenNV.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Email";
            // 
            // lblTenVN
            // 
            this.lblTenVN.AutoSize = true;
            this.lblTenVN.Location = new System.Drawing.Point(9, 42);
            this.lblTenVN.Name = "lblTenVN";
            this.lblTenVN.Size = new System.Drawing.Size(150, 25);
            this.lblTenVN.TabIndex = 25;
            this.lblTenVN.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(0, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 0;
            // 
            // btnThemNV
            // 
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Location = new System.Drawing.Point(1153, 14);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(295, 113);
            this.btnThemNV.TabIndex = 39;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 75F;
            this.ID.HeaderText = "Mã NV";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 150F;
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "RoleName";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 725);
            this.Controls.Add(this.gbThongTinNV);
            this.Controls.Add(this.gBTimKiem);
            this.Controls.Add(this.gBDSNhanVien);
            this.Controls.Add(this.btnThemNV);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.gBDSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSNV)).EndInit();
            this.gBTimKiem.ResumeLayout(false);
            this.gBTimKiem.PerformLayout();
            this.gbThongTinNV.ResumeLayout(false);
            this.gbThongTinNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBDSNhanVien;
        private System.Windows.Forms.DataGridView dataDSNV;
        private System.Windows.Forms.GroupBox gBTimKiem;
        private System.Windows.Forms.Button btnLamMoi1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbThongTinNV;
        private System.Windows.Forms.Label lblLoaiNV;
        private System.Windows.Forms.ComboBox cbLoaiNV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenVN;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.RadioButton rdID;
        private System.Windows.Forms.RadioButton rdTimTheoTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RichTextBox txtAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}
