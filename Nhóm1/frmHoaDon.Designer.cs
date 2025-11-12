namespace Nhóm1
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.pbTaoPhieu = new System.Windows.Forms.PictureBox();
            this.pbTimKiem = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.labelBillList = new System.Windows.Forms.Label();
            this.labelBillDetail = new System.Windows.Forms.Label();
            this.cbLoaiHoaDon = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.pbTaoPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTaoPhieu
            // 
            this.pbTaoPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTaoPhieu.Image = ((System.Drawing.Image)(resources.GetObject("pbTaoPhieu.Image")));
            this.pbTaoPhieu.Location = new System.Drawing.Point(1372, 48);
            this.pbTaoPhieu.Name = "pbTaoPhieu";
            this.pbTaoPhieu.Size = new System.Drawing.Size(36, 29);
            this.pbTaoPhieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTaoPhieu.TabIndex = 13;
            this.pbTaoPhieu.TabStop = false;
            this.pbTaoPhieu.Click += new System.EventHandler(this.pbTaoPhieu_Click);
            // 
            // pbTimKiem
            // 
            this.pbTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("pbTimKiem.Image")));
            this.pbTimKiem.Location = new System.Drawing.Point(1304, 48);
            this.pbTimKiem.Name = "pbTimKiem";
            this.pbTimKiem.Size = new System.Drawing.Size(36, 29);
            this.pbTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTimKiem.TabIndex = 11;
            this.pbTimKiem.TabStop = false;
            this.pbTimKiem.Click += new System.EventHandler(this.pbTimKiem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(578, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(162, 41);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "HÓA ĐƠN";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFrom.Location = new System.Drawing.Point(311, 54);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(75, 23);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "Từ ngày:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTo.Location = new System.Drawing.Point(666, 54);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(87, 23);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "Đến ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 30);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker2.Location = new System.Drawing.Point(759, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 30);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // cbLoaiHoaDon
            // 
            this.cbLoaiHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiHoaDon.FormattingEnabled = true;
            this.cbLoaiHoaDon.Location = new System.Drawing.Point(1040, 51);
            this.cbLoaiHoaDon.Name = "cbLoaiHoaDon";
            this.cbLoaiHoaDon.Size = new System.Drawing.Size(240, 31);
            this.cbLoaiHoaDon.TabIndex = 22;
            this.cbLoaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHoaDon_SelectedIndexChanged);
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeight = 29;
            this.dgvBill.Location = new System.Drawing.Point(12, 105);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(1396, 250);
            this.dgvBill.TabIndex = 18;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.ColumnHeadersHeight = 29;
            this.dgvBillDetail.Location = new System.Drawing.Point(12, 400);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.RowTemplate.Height = 24;
            this.dgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetail.Size = new System.Drawing.Size(1396, 230);
            this.dgvBillDetail.TabIndex = 19;
            // 
            // labelBillList
            // 
            this.labelBillList.AutoSize = true;
            this.labelBillList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelBillList.Location = new System.Drawing.Point(12, 80);
            this.labelBillList.Name = "labelBillList";
            this.labelBillList.Size = new System.Drawing.Size(167, 23);
            this.labelBillList.TabIndex = 20;
            this.labelBillList.Text = "Danh sách hóa đơn:";
            // 
            // labelBillDetail
            // 
            this.labelBillDetail.AutoSize = true;
            this.labelBillDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelBillDetail.Location = new System.Drawing.Point(12, 375);
            this.labelBillDetail.Name = "labelBillDetail";
            this.labelBillDetail.Size = new System.Drawing.Size(160, 23);
            this.labelBillDetail.TabIndex = 21;
            this.labelBillDetail.Text = "Chi tiết hóa đơn #:";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 650);
            this.Controls.Add(this.cbLoaiHoaDon);
            this.Controls.Add(this.labelBillDetail);
            this.Controls.Add(this.labelBillList);
            this.Controls.Add(this.dgvBillDetail);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pbTaoPhieu);
            this.Controls.Add(this.pbTimKiem);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbTaoPhieu;
        private System.Windows.Forms.ComboBox cbLoaiHoaDon;
        private System.Windows.Forms.PictureBox pbTimKiem;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.Label labelBillList;
        private System.Windows.Forms.Label labelBillDetail;
    }
}
