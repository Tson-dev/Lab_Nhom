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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblImport = new System.Windows.Forms.Label();
            this.cbxImport = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvTTPhieu = new System.Windows.Forms.DataGridView();
            this.btnAddBrand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(330, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ KHO HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoai,
            this.colGiaBan,
            this.colSoLuong,
            this.colThuongHieu});
            this.dgvProd.Location = new System.Drawing.Point(12, 180);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(960, 220);
            this.dgvProd.TabIndex = 1;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
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
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
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
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(12, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 20);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "Mã SP:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(90, 60);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(230, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 20);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Tên SP:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(310, 60);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 20);
            this.txtTenSP.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(530, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Giá bán:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(610, 60);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(750, 60);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(90, 20);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Số lượng tồn:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(850, 60);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(120, 20);
            this.txtStock.TabIndex = 9;
            // 
            // lblImport
            // 
            this.lblImport.Location = new System.Drawing.Point(12, 100);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(80, 20);
            this.lblImport.TabIndex = 8;
            this.lblImport.Text = "Nhập SL:";
            // 
            // cbxImport
            // 
            this.cbxImport.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50"});
            this.cbxImport.Location = new System.Drawing.Point(90, 100);
            this.cbxImport.Name = "cbxImport";
            this.cbxImport.Size = new System.Drawing.Size(80, 21);
            this.cbxImport.TabIndex = 7;
            // 
            // cbxBrand
            // 
            this.cbxBrand.Location = new System.Drawing.Point(310, 100);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(200, 21);
            this.cbxBrand.TabIndex = 6;
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(200, 100);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(110, 20);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Nhà cung cấp:";
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
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(770, 100);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 28);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "📥 Chọn";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(880, 100);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "💾 Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvTTPhieu
            // 
            this.dgvTTPhieu.AllowUserToAddRows = false;
            this.dgvTTPhieu.AllowUserToDeleteRows = false;
            this.dgvTTPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTPhieu.ColumnHeadersHeight = 29;
            this.dgvTTPhieu.Location = new System.Drawing.Point(12, 420);
            this.dgvTTPhieu.Name = "dgvTTPhieu";
            this.dgvTTPhieu.ReadOnly = true;
            this.dgvTTPhieu.RowHeadersWidth = 51;
            this.dgvTTPhieu.Size = new System.Drawing.Size(960, 200);
            this.dgvTTPhieu.TabIndex = 0;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(640, 100);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(120, 28);
            this.btnAddBrand.TabIndex = 3;
            this.btnAddBrand.Text = "➕ Thêm NCC";
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // frmKho
            // 
            this.ClientSize = new System.Drawing.Size(984, 640);
            this.Controls.Add(this.dgvTTPhieu);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.cbxImport);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.ComboBox cbxImport;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvTTPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuongHieu;
    }
}
