namespace Nhóm1
{
    partial class frmStatictis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tsFilter = new System.Windows.Forms.ToolStrip();
            this.tsFilter_sbtnFilter = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiLWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiL28D = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiL90D = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tsFilter.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // tsFilter
            // 
            this.tsFilter.Dock = System.Windows.Forms.DockStyle.None;
            this.tsFilter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFilter_sbtnFilter});
            this.tsFilter.Location = new System.Drawing.Point(132, 33);
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(136, 25);
            this.tsFilter.TabIndex = 4;
            this.tsFilter.Text = "toolStrip1";
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
            this.tsiLWeek.Click += new System.EventHandler(this.tsiLWeek_Click);
            // 
            // tsiL28D
            // 
            this.tsiL28D.Name = "tsiL28D";
            this.tsiL28D.Size = new System.Drawing.Size(138, 22);
            this.tsiL28D.Text = "Last 28 Days";
            this.tsiL28D.Click += new System.EventHandler(this.tsiL28D_Click);
            // 
            // tsiL90D
            // 
            this.tsiL90D.Name = "tsiL90D";
            this.tsiL90D.Size = new System.Drawing.Size(138, 22);
            this.tsiL90D.Text = "Last 90 Days";
            this.tsiL90D.Click += new System.EventHandler(this.tsiL90D_Click);
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
            this.tsiYear.Click += new System.EventHandler(this.tsiYear_Click);
            // 
            // tsiMonth
            // 
            this.tsiMonth.Name = "tsiMonth";
            this.tsiMonth.Size = new System.Drawing.Size(138, 22);
            this.tsiMonth.Text = "Month";
            this.tsiMonth.Click += new System.EventHandler(this.tsiMonth_Click);
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
            this.tsiCustom.Click += new System.EventHandler(this.tsiCustom_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(102, 75);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(167, 20);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(102, 110);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(167, 20);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnConfirm);
            this.gbxFilter.Controls.Add(this.lblTo);
            this.gbxFilter.Controls.Add(this.lblFrom);
            this.gbxFilter.Controls.Add(this.dtpFrom);
            this.gbxFilter.Controls.Add(this.tsFilter);
            this.gbxFilter.Controls.Add(this.dtpTo);
            this.gbxFilter.Location = new System.Drawing.Point(12, 26);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(302, 247);
            this.gbxFilter.TabIndex = 6;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(194, 193);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(17, 116);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(17, 81);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From";
            // 
            // chartStatistic
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend2);
            this.chartStatistic.Location = new System.Drawing.Point(339, 35);
            this.chartStatistic.Name = "chartStatistic";
            this.chartStatistic.Size = new System.Drawing.Size(393, 259);
            this.chartStatistic.TabIndex = 0;
            this.chartStatistic.Text = "chart1";
            // 
            // frmStatictis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 625);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.chartStatistic);
            this.Name = "frmStatictis";
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.tsFilter.ResumeLayout(false);
            this.tsFilter.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsFilter;
        private System.Windows.Forms.ToolStripSplitButton tsFilter_sbtnFilter;
        private System.Windows.Forms.ToolStripMenuItem tsiLWeek;
        private System.Windows.Forms.ToolStripMenuItem tsiL28D;
        private System.Windows.Forms.ToolStripMenuItem tsiL90D;
        private System.Windows.Forms.ToolStripSeparator tsiSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiYear;
        private System.Windows.Forms.ToolStripMenuItem tsiMonth;
        private System.Windows.Forms.ToolStripSeparator tsiSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsiCustom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
    }
}