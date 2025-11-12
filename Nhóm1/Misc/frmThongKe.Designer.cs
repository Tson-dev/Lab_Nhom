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
            this.chartStatictis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxTotal = new System.Windows.Forms.GroupBox();
            this.lblEarn = new System.Windows.Forms.Label();
            this.lblImport = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblTotalEarn = new System.Windows.Forms.Label();
            this.lblTongNhap = new System.Windows.Forms.Label();
            this.lblTotalExport = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsFilter_sbtnFilter = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiLWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiL28D = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiL90D = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.btnStatictis = new System.Windows.Forms.Button();
            this.tsFilter = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatictis)).BeginInit();
            this.gbxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.tsFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStatictis
            // 
            this.chartStatictis.BackColor = System.Drawing.Color.AliceBlue;
            this.chartStatictis.BorderlineColor = System.Drawing.Color.Gray;
            this.chartStatictis.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.Name = "ChartArea1";
            this.chartStatictis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatictis.Legends.Add(legend1);
            this.chartStatictis.Location = new System.Drawing.Point(26, 63);
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
            this.gbxTotal.Location = new System.Drawing.Point(26, 455);
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
            this.dgvProd.Location = new System.Drawing.Point(745, 35);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.Size = new System.Drawing.Size(342, 530);
            this.dgvProd.TabIndex = 4;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(133, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(136, 25);
            this.miniToolStrip.TabIndex = 4;
            // 
            // tsFilter_sbtnFilter
            // 
            this.tsFilter_sbtnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFilter_sbtnFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLWeek,
            this.tsiL28D,
            this.tsiL90D,
            this.tsiSeparator1,
            this.tsiYear,
            this.tsiMonth,
            this.tsiSeparator2,
            this.tsiCustom});
            this.tsFilter_sbtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFilter_sbtnFilter.Name = "tsFilter_sbtnFilter";
            this.tsFilter_sbtnFilter.Size = new System.Drawing.Size(133, 22);
            this.tsFilter_sbtnFilter.Text = "toolStripSplitButton1";
            // 
            // tsiLWeek
            // 
            this.tsiLWeek.Name = "tsiLWeek";
            this.tsiLWeek.Size = new System.Drawing.Size(138, 22);
            this.tsiLWeek.Text = "Last Week";
            // 
            // tsiL28D
            // 
            this.tsiL28D.Name = "tsiL28D";
            this.tsiL28D.Size = new System.Drawing.Size(138, 22);
            this.tsiL28D.Text = "Last 28 Days";
            // 
            // tsiL90D
            // 
            this.tsiL90D.Name = "tsiL90D";
            this.tsiL90D.Size = new System.Drawing.Size(138, 22);
            this.tsiL90D.Text = "Last 90 Days";
            // 
            // tsiSeparator1
            // 
            this.tsiSeparator1.Name = "tsiSeparator1";
            this.tsiSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // tsiYear
            // 
            this.tsiYear.Name = "tsiYear";
            this.tsiYear.Size = new System.Drawing.Size(138, 22);
            this.tsiYear.Text = "Year";
            // 
            // tsiMonth
            // 
            this.tsiMonth.Name = "tsiMonth";
            this.tsiMonth.Size = new System.Drawing.Size(138, 22);
            this.tsiMonth.Text = "Month";
            // 
            // tsiSeparator2
            // 
            this.tsiSeparator2.Name = "tsiSeparator2";
            this.tsiSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // tsiCustom
            // 
            this.tsiCustom.Name = "tsiCustom";
            this.tsiCustom.Size = new System.Drawing.Size(138, 22);
            this.tsiCustom.Text = "Custom";
            // 
            // cbxYear
            // 
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(26, 26);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 24);
            this.cbxYear.TabIndex = 0;
            // 
            // btnStatictis
            // 
            this.btnStatictis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatictis.Location = new System.Drawing.Point(171, 23);
            this.btnStatictis.Name = "btnStatictis";
            this.btnStatictis.Size = new System.Drawing.Size(105, 27);
            this.btnStatictis.TabIndex = 1;
            this.btnStatictis.Text = "Thống kê";
            this.btnStatictis.UseVisualStyleBackColor = true;
            this.btnStatictis.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tsFilter
            // 
            this.tsFilter.Dock = System.Windows.Forms.DockStyle.None;
            this.tsFilter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFilter_sbtnFilter});
            this.tsFilter.Location = new System.Drawing.Point(31, 21);
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(136, 25);
            this.tsFilter.TabIndex = 4;
            this.tsFilter.Text = "toolStrip1";
            // 
            // frmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(1099, 578);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.btnStatictis);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.chartStatictis);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatictis)).EndInit();
            this.gbxTotal.ResumeLayout(false);
            this.gbxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.tsFilter.ResumeLayout(false);
            this.tsFilter.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatictis;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.Label lblTotalExport;
        private System.Windows.Forms.Label lblTongNhap;
        private System.Windows.Forms.Label lblTotalEarn;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label lblEarn;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripSplitButton tsFilter_sbtnFilter;
        private System.Windows.Forms.ToolStripMenuItem tsiLWeek;
        private System.Windows.Forms.ToolStripMenuItem tsiL28D;
        private System.Windows.Forms.ToolStripMenuItem tsiL90D;
        private System.Windows.Forms.ToolStripSeparator tsiSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiYear;
        private System.Windows.Forms.ToolStripMenuItem tsiMonth;
        private System.Windows.Forms.ToolStripSeparator tsiSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsiCustom;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Button btnStatictis;
        private System.Windows.Forms.ToolStrip tsFilter;
    }
}
