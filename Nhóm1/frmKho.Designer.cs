namespace Nhóm1
{
    partial class frmKho
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataDSSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dataTTPhieu = new System.Windows.Forms.DataGridView();
            this.btnThemBrand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTTPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(330, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ KHO HÀNG";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataDSSanPham
            // 
            this.dataDSSanPham.AllowUserToAddRows = false;
            this.dataDSSanPham.AllowUserToDeleteRows = false;
            this.dataDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDSSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoai,
            this.colGiaBan,
            this.colSoLuong,
            this.colThuongHieu});
            this.dataDSSanPham.Location = new System.Drawing.Point(12, 180);
            this.dataDSSanPham.MultiSelect = false;
            this.dataDSSanPham.Name = "dataDSSanPham";
            this.dataDSSanPham.ReadOnly = true;
            this.dataDSSanPham.RowHeadersWidth = 51;
            this.dataDSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDSSanPham.Size = new System.Drawing.Size(960, 220);
            this.dataDSSanPham.TabIndex = 1;
            this.dataDSSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSSanPham_CellClick);
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "ID";
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "Tên sản phẩm";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.DataPropertyName = "Loại";
            this.colLoai.HeaderText = "Loại";
            this.colLoai.MinimumWidth = 6;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "Giá bán";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 6;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "Số lượng tồn";
            this.colSoLuong.HeaderText = "Số lượng tồn";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colThuongHieu
            // 
            this.colThuongHieu.DataPropertyName = "Thương hiệu";
            this.colThuongHieu.HeaderText = "Thương hiệu";
            this.colThuongHieu.MinimumWidth = 6;
            this.colThuongHieu.Name = "colThuongHieu";
            this.colThuongHieu.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 140);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(90, 60);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(120, 22);
            this.txtMaSP.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(230, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên SP:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(310, 60);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 22);
            this.txtTenSP.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(530, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(610, 60);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(120, 22);
            this.txtGiaBan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(750, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng tồn:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(850, 60);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(120, 22);
            this.txtSoLuongTon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhập SL:";
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50"});
            this.cbSoLuong.Location = new System.Drawing.Point(90, 100);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(80, 24);
            this.cbSoLuong.TabIndex = 7;
            // 
            // cbNCC
            // 
            this.cbNCC.Location = new System.Drawing.Point(310, 100);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(200, 24);
            this.cbNCC.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(200, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(530, 100);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 28);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "➕ Thêm SP";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(770, 100);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 28);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "📥 Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(880, 100);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 28);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "💾 Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dataTTPhieu
            // 
            this.dataTTPhieu.AllowUserToAddRows = false;
            this.dataTTPhieu.AllowUserToDeleteRows = false;
            this.dataTTPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTTPhieu.ColumnHeadersHeight = 29;
            this.dataTTPhieu.Location = new System.Drawing.Point(12, 420);
            this.dataTTPhieu.Name = "dataTTPhieu";
            this.dataTTPhieu.ReadOnly = true;
            this.dataTTPhieu.RowHeadersWidth = 51;
            this.dataTTPhieu.Size = new System.Drawing.Size(960, 200);
            this.dataTTPhieu.TabIndex = 0;
            // 
            // btnThemBrand
            // 
            this.btnThemBrand.Location = new System.Drawing.Point(640, 100);
            this.btnThemBrand.Name = "btnThemBrand";
            this.btnThemBrand.Size = new System.Drawing.Size(120, 28);
            this.btnThemBrand.TabIndex = 3;
            this.btnThemBrand.Text = "➕ Thêm NCC";
            this.btnThemBrand.Click += new System.EventHandler(this.btnThemBrand_Click);
            // 
            // frmKho
            // 
            this.ClientSize = new System.Drawing.Size(984, 640);
            this.Controls.Add(this.dataTTPhieu);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnThemBrand);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.cbSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataDSSanPham);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTTPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataDSSanPham;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnThemBrand;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dataTTPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuongHieu;
    }
}
