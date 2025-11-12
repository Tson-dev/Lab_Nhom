namespace Nhóm1
{
    partial class frmPrintBill
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
            this.lblTilte = new System.Windows.Forms.Label();
            this.lblTotalTilte = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTilte.Location = new System.Drawing.Point(210, 7);
            this.lblTilte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(210, 25);
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // lblTotalTilte
            // 
            this.lblTotalTilte.AutoSize = true;
            this.lblTotalTilte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTilte.Location = new System.Drawing.Point(270, 292);
            this.lblTotalTilte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTilte.Name = "lblTotalTilte";
            this.lblTotalTilte.Size = new System.Drawing.Size(70, 19);
            this.lblTotalTilte.TabIndex = 1;
            this.lblTotalTilte.Text = "Tổng tiền:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 49);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Mã hóa đơn:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(375, 49);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Ngày lập:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(30, 73);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(58, 13);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Tài khoản:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(338, 292);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 19);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = ".";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(9, 98);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(570, 179);
            this.dgvDetail.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Location = new System.Drawing.Point(240, 325);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 32);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTotalTilte);
            this.Controls.Add(this.lblTilte);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrintBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Bill";
            this.Load += new System.EventHandler(this.frmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Label lblTotalTilte;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnPrint;
    }
}