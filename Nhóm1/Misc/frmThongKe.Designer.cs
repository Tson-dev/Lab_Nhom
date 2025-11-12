namespace Nhóm1
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.btnStatictis = new System.Windows.Forms.Button();
            this.chartStatictis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxTotal = new System.Windows.Forms.GroupBox();
            this.lblEarn = new System.Windows.Forms.Label();
            this.lblImport = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblTotalEarn = new System.Windows.Forms.Label();
            this.lblTongNhap = new System.Windows.Forms.Label();
            this.lblTotalExport = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatictis)).BeginInit();
            this.gbxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxYear
            // 
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(28, 22);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 24);
            this.cbxYear.TabIndex = 0;
            // 
            // btnStatictis
            // 
            this.btnStatictis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatictis.Location = new System.Drawing.Point(165, 22);
            this.btnStatictis.Name = "btnStatictis";
            this.btnStatictis.Size = new System.Drawing.Size(105, 27);
            this.btnStatictis.TabIndex = 1;
            this.btnStatictis.Text = "Thống kê";
            this.btnStatictis.UseVisualStyleBackColor = true;
            this.btnStatictis.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // chartStatictis
            // 
            this.chartStatictis.BackColor = System.Drawing.Color.AliceBlue;
            this.chartStatictis.BorderlineColor = System.Drawing.Color.Gray;
            this.chartStatictis.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartStatictis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatictis.Legends.Add(legend1);
            this.chartStatictis.Location = new System.Drawing.Point(28, 65);
            this.chartStatictis.Name = "chartStatictis";
            this.chartStatictis.Size = new System.Drawing.Size(713, 386);
            this.chartStatictis.TabIndex = 2;
            this.chartStatictis.Text = "chart1";
            // 
            // gbxTotal
            // 
            this.gbxTotal.Controls.Add(this.lblEarn);
            this.gbxTotal.Controls.Add(this.lblImport);
            this.gbxTotal.Controls.Add(this.lblExport);
            this.gbxTotal.Controls.Add(this.lblTotalEarn);
            this.gbxTotal.Controls.Add(this.lblTongNhap);
            this.gbxTotal.Controls.Add(this.lblTotalExport);
            this.gbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbxTotal.Location = new System.Drawing.Point(28, 457);
            this.gbxTotal.Name = "gbxTotal";
            this.gbxTotal.Size = new System.Drawing.Size(713, 110);
            this.gbxTotal.TabIndex = 3;
            this.gbxTotal.TabStop = false;
            this.gbxTotal.Text = "Tổng hợp";
            // 
            // lblEarn
            // 
            this.lblEarn.AutoSize = true;
            this.lblEarn.Location = new System.Drawing.Point(30, 76);
            this.lblEarn.Name = "lblEarn";
            this.lblEarn.Size = new System.Drawing.Size(71, 17);
            this.lblEarn.TabIndex = 5;
            this.lblEarn.Text = "Lợi nhuận";
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(30, 52);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(159, 17);
            this.lblImport.TabIndex = 4;
            this.lblImport.Text = "Tổng nhập hàng (nhập)";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(30, 28);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(149, 17);
            this.lblExport.TabIndex = 3;
            this.lblExport.Text = "Tổng doanh thu (xuất)";
            // 
            // lblTotalEarn
            // 
            this.lblTotalEarn.AutoSize = true;
            this.lblTotalEarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalEarn.Location = new System.Drawing.Point(218, 76);
            this.lblTotalEarn.Name = "lblTotalEarn";
            this.lblTotalEarn.Size = new System.Drawing.Size(54, 17);
            this.lblTotalEarn.TabIndex = 2;
            this.lblTotalEarn.Text = "0 VNĐ";
            // 
            // lblTongNhap
            // 
            this.lblTongNhap.AutoSize = true;
            this.lblTongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongNhap.Location = new System.Drawing.Point(218, 52);
            this.lblTongNhap.Name = "lblTongNhap";
            this.lblTongNhap.Size = new System.Drawing.Size(54, 17);
            this.lblTongNhap.TabIndex = 1;
            this.lblTongNhap.Text = "0 VNĐ";
            // 
            // lblTotalExport
            // 
            this.lblTotalExport.AutoSize = true;
            this.lblTotalExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalExport.Location = new System.Drawing.Point(218, 28);
            this.lblTotalExport.Name = "lblTotalExport";
            this.lblTotalExport.Size = new System.Drawing.Size(54, 17);
            this.lblTotalExport.TabIndex = 0;
            this.lblTotalExport.Text = "0 VNĐ";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeight = 29;
            this.dgvProd.Location = new System.Drawing.Point(747, 22);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.Size = new System.Drawing.Size(342, 545);
            this.dgvProd.TabIndex = 4;
            // 
            // frmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.chartStatictis);
            this.Controls.Add(this.btnStatictis);
            this.Controls.Add(this.cbxYear);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatictis)).EndInit();
            this.gbxTotal.ResumeLayout(false);
            this.gbxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Button btnStatictis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatictis;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.Label lblTotalExport;
        private System.Windows.Forms.Label lblTongNhap;
        private System.Windows.Forms.Label lblTotalEarn;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label lblEarn;
        private System.Windows.Forms.DataGridView dgvProd;
    }
}
