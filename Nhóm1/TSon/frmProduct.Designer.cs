namespace Nhóm1
{
    partial class frmProd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProd));
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cmsBrand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsBrand_tsiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBrand_tsiSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cmsBrand_tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pbxBrand = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.pbxPrice = new System.Windows.Forms.PictureBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.pbxSize = new System.Windows.Forms.PictureBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.cmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCategory_tsiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCategory_tsiSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCategory_tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoai = new System.Windows.Forms.Label();
            this.pbxType = new System.Windows.Forms.PictureBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.pbxAge = new System.Windows.Forms.PictureBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxName = new System.Windows.Forms.PictureBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.gbxFind = new System.Windows.Forms.GroupBox();
            this.rbtnType = new System.Windows.Forms.RadioButton();
            this.rbtnBrand = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmsInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFind = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_dgvProd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_dgvProd_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_dgvProd_tsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_dgvProd_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.cms_dgvProd_tsiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInfo_tsiMore = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInfo_Less = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFind_tsiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_dgvProd_tsiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxInfo.SuspendLayout();
            this.cmsBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSize)).BeginInit();
            this.cmsCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxName)).BeginInit();
            this.gbxFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.cmsInfo.SuspendLayout();
            this.cmsFind.SuspendLayout();
            this.cms_dgvProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.ContextMenuStrip = this.cmsInfo;
            this.gbxInfo.Controls.Add(this.radioButton1);
            this.gbxInfo.Controls.Add(this.rbtnFemale);
            this.gbxInfo.Controls.Add(this.rbtnMale);
            this.gbxInfo.Controls.Add(this.btnCancel);
            this.gbxInfo.Controls.Add(this.btnConfirm);
            this.gbxInfo.Controls.Add(this.cbNCC);
            this.gbxInfo.Controls.Add(this.lblBrand);
            this.gbxInfo.Controls.Add(this.pbxBrand);
            this.gbxInfo.Controls.Add(this.txtPrice);
            this.gbxInfo.Controls.Add(this.lblGiaBan);
            this.gbxInfo.Controls.Add(this.pbxPrice);
            this.gbxInfo.Controls.Add(this.nudSize);
            this.gbxInfo.Controls.Add(this.lblSize);
            this.gbxInfo.Controls.Add(this.pbxSize);
            this.gbxInfo.Controls.Add(this.cbLoai);
            this.gbxInfo.Controls.Add(this.lblLoai);
            this.gbxInfo.Controls.Add(this.pbxType);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.lblAge);
            this.gbxInfo.Controls.Add(this.pictureBox1);
            this.gbxInfo.Controls.Add(this.pbxAge);
            this.gbxInfo.Controls.Add(this.txtAge);
            this.gbxInfo.Controls.Add(this.txtName);
            this.gbxInfo.Controls.Add(this.lblName);
            this.gbxInfo.Controls.Add(this.pbxName);
            this.gbxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(12, 36);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(442, 521);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Information";
            // 
            // cbNCC
            // 
            this.cbNCC.ContextMenuStrip = this.cmsBrand;
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(132, 385);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(282, 28);
            this.cbNCC.TabIndex = 49;
            // 
            // cmsBrand
            // 
            this.cmsBrand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsBrand_tsiAdd,
            this.cmsBrand_tsiSeparator,
            this.cmsBrand_tsiOpen});
            this.cmsBrand.Name = "cmsBrand";
            this.cmsBrand.Size = new System.Drawing.Size(138, 54);
            // 
            // cmsBrand_tsiAdd
            // 
            this.cmsBrand_tsiAdd.Enabled = false;
            this.cmsBrand_tsiAdd.Name = "cmsBrand_tsiAdd";
            this.cmsBrand_tsiAdd.Size = new System.Drawing.Size(137, 22);
            this.cmsBrand_tsiAdd.Text = "Add";
            this.cmsBrand_tsiAdd.Visible = false;
            this.cmsBrand_tsiAdd.Click += new System.EventHandler(this.cmsBrand_tsiAdd_Click);
            // 
            // cmsBrand_tsiSeparator
            // 
            this.cmsBrand_tsiSeparator.Name = "cmsBrand_tsiSeparator";
            this.cmsBrand_tsiSeparator.Size = new System.Drawing.Size(134, 6);
            this.cmsBrand_tsiSeparator.Visible = false;
            // 
            // cmsBrand_tsiOpen
            // 
            this.cmsBrand_tsiOpen.Name = "cmsBrand_tsiOpen";
            this.cmsBrand_tsiOpen.Size = new System.Drawing.Size(137, 22);
            this.cmsBrand_tsiOpen.Text = "Open Brand";
            this.cmsBrand_tsiOpen.Click += new System.EventHandler(this.cmsBrand_tsiOpen_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(52, 388);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 20);
            this.lblBrand.TabIndex = 48;
            this.lblBrand.Text = "Brand";
            // 
            // pbxBrand
            // 
            this.pbxBrand.Image = ((System.Drawing.Image)(resources.GetObject("pbxBrand.Image")));
            this.pbxBrand.Location = new System.Drawing.Point(6, 378);
            this.pbxBrand.Name = "pbxBrand";
            this.pbxBrand.Size = new System.Drawing.Size(39, 37);
            this.pbxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBrand.TabIndex = 47;
            this.pbxBrand.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(132, 323);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(282, 26);
            this.txtPrice.TabIndex = 46;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(52, 326);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(44, 20);
            this.lblGiaBan.TabIndex = 45;
            this.lblGiaBan.Text = "Price";
            // 
            // pbxPrice
            // 
            this.pbxPrice.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrice.Image")));
            this.pbxPrice.Location = new System.Drawing.Point(6, 316);
            this.pbxPrice.Name = "pbxPrice";
            this.pbxPrice.Size = new System.Drawing.Size(39, 40);
            this.pbxPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPrice.TabIndex = 44;
            this.pbxPrice.TabStop = false;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(132, 260);
            this.nudSize.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(149, 26);
            this.nudSize.TabIndex = 40;
            this.nudSize.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(52, 261);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 39;
            this.lblSize.Text = "Size";
            // 
            // pbxSize
            // 
            this.pbxSize.Image = ((System.Drawing.Image)(resources.GetObject("pbxSize.Image")));
            this.pbxSize.Location = new System.Drawing.Point(6, 252);
            this.pbxSize.Name = "pbxSize";
            this.pbxSize.Size = new System.Drawing.Size(39, 38);
            this.pbxSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSize.TabIndex = 38;
            this.pbxSize.TabStop = false;
            // 
            // cbLoai
            // 
            this.cbLoai.ContextMenuStrip = this.cmsCategory;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(132, 201);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(282, 28);
            this.cbLoai.TabIndex = 37;
            // 
            // cmsCategory
            // 
            this.cmsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCategory_tsiAdd,
            this.cmsCategory_tsiSeparator,
            this.cmsCategory_tsiOpen});
            this.cmsCategory.Name = "cmsCategory";
            this.cmsCategory.Size = new System.Drawing.Size(155, 54);
            // 
            // cmsCategory_tsiAdd
            // 
            this.cmsCategory_tsiAdd.Name = "cmsCategory_tsiAdd";
            this.cmsCategory_tsiAdd.Size = new System.Drawing.Size(154, 22);
            this.cmsCategory_tsiAdd.Text = "Add";
            this.cmsCategory_tsiAdd.Click += new System.EventHandler(this.cmsCategory_tsiAdd_Click);
            // 
            // cmsCategory_tsiSeparator
            // 
            this.cmsCategory_tsiSeparator.Name = "cmsCategory_tsiSeparator";
            this.cmsCategory_tsiSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // cmsCategory_tsiOpen
            // 
            this.cmsCategory_tsiOpen.Name = "cmsCategory_tsiOpen";
            this.cmsCategory_tsiOpen.Size = new System.Drawing.Size(154, 22);
            this.cmsCategory_tsiOpen.Text = "Open Category";
            this.cmsCategory_tsiOpen.Click += new System.EventHandler(this.cmsCategory_tsiOpen_Click);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(51, 203);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(43, 20);
            this.lblLoai.TabIndex = 36;
            this.lblLoai.Text = "Type";
            // 
            // pbxType
            // 
            this.pbxType.Image = ((System.Drawing.Image)(resources.GetObject("pbxType.Image")));
            this.pbxType.Location = new System.Drawing.Point(6, 194);
            this.pbxType.Name = "pbxType";
            this.pbxType.Size = new System.Drawing.Size(39, 38);
            this.pbxType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxType.TabIndex = 35;
            this.pbxType.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(52, 146);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 33;
            this.lblAge.Text = "Age";
            // 
            // pbxAge
            // 
            this.pbxAge.Image = ((System.Drawing.Image)(resources.GetObject("pbxAge.Image")));
            this.pbxAge.Location = new System.Drawing.Point(6, 135);
            this.pbxAge.Name = "pbxAge";
            this.pbxAge.Size = new System.Drawing.Size(39, 40);
            this.pbxAge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAge.TabIndex = 32;
            this.pbxAge.TabStop = false;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 143);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(282, 26);
            this.txtAge.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 26);
            this.txtName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // pbxName
            // 
            this.pbxName.Image = ((System.Drawing.Image)(resources.GetObject("pbxName.Image")));
            this.pbxName.Location = new System.Drawing.Point(6, 37);
            this.pbxName.Name = "pbxName";
            this.pbxName.Size = new System.Drawing.Size(39, 32);
            this.pbxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxName.TabIndex = 20;
            this.pbxName.TabStop = false;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(405, 9);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(82, 24);
            this.lblProd.TabIndex = 1;
            this.lblProd.Text = "Product";
            // 
            // gbxFind
            // 
            this.gbxFind.ContextMenuStrip = this.cmsFind;
            this.gbxFind.Controls.Add(this.rbtnType);
            this.gbxFind.Controls.Add(this.rbtnBrand);
            this.gbxFind.Controls.Add(this.txtFind);
            this.gbxFind.Controls.Add(this.lblFind);
            this.gbxFind.Controls.Add(this.dgvProd);
            this.gbxFind.Controls.Add(this.btnFind);
            this.gbxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFind.Location = new System.Drawing.Point(460, 36);
            this.gbxFind.Name = "gbxFind";
            this.gbxFind.Size = new System.Drawing.Size(534, 521);
            this.gbxFind.TabIndex = 2;
            this.gbxFind.TabStop = false;
            this.gbxFind.Text = "Find";
            // 
            // rbtnType
            // 
            this.rbtnType.AutoSize = true;
            this.rbtnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnType.Location = new System.Drawing.Point(184, 81);
            this.rbtnType.Name = "rbtnType";
            this.rbtnType.Size = new System.Drawing.Size(61, 24);
            this.rbtnType.TabIndex = 62;
            this.rbtnType.Text = "Type";
            this.rbtnType.UseVisualStyleBackColor = true;
            // 
            // rbtnBrand
            // 
            this.rbtnBrand.AutoSize = true;
            this.rbtnBrand.Checked = true;
            this.rbtnBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBrand.Location = new System.Drawing.Point(68, 81);
            this.rbtnBrand.Name = "rbtnBrand";
            this.rbtnBrand.Size = new System.Drawing.Size(92, 24);
            this.rbtnBrand.TabIndex = 61;
            this.rbtnBrand.TabStop = true;
            this.rbtnBrand.Text = "By Brand";
            this.rbtnBrand.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(68, 40);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(268, 26);
            this.txtFind.TabIndex = 60;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(10, 43);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(40, 20);
            this.lblFind.TabIndex = 59;
            this.lblFind.Text = "Find";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColName,
            this.colBrand,
            this.ColType,
            this.colSize,
            this.colAge,
            this.colStock,
            this.colPrice});
            this.dgvProd.ContextMenuStrip = this.cms_dgvProd;
            this.dgvProd.Location = new System.Drawing.Point(6, 117);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.Size = new System.Drawing.Size(518, 398);
            this.dgvProd.TabIndex = 58;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "Prod Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.Width = 125;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "BrandName";
            this.colBrand.HeaderText = "Brand Name";
            this.colBrand.MinimumWidth = 6;
            this.colBrand.Name = "colBrand";
            this.colBrand.Width = 125;
            // 
            // ColType
            // 
            this.ColType.DataPropertyName = "Type";
            this.ColType.HeaderText = "Type";
            this.ColType.MinimumWidth = 6;
            this.ColType.Name = "ColType";
            this.ColType.Width = 125;
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "Size";
            this.colSize.HeaderText = "Size";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            this.colSize.Width = 125;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.Width = 125;
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "Stock";
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(396, 38);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 33);
            this.btnFind.TabIndex = 56;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmsInfo
            // 
            this.cmsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsInfo_tsiMore,
            this.cmsInfo_Less});
            this.cmsInfo.Name = "contextMenuStrip1";
            this.cmsInfo.Size = new System.Drawing.Size(127, 48);
            // 
            // cmsFind
            // 
            this.cmsFind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFind_tsiReset});
            this.cmsFind.Name = "contextMenuStrip2";
            this.cmsFind.Size = new System.Drawing.Size(103, 26);
            // 
            // cms_dgvProd
            // 
            this.cms_dgvProd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_dgvProd_tsiAdd,
            this.cms_dgvProd_Update,
            this.cms_dgvProd_tsiDelete,
            this.cms_dgvProd_Separator,
            this.cms_dgvProd_tsiReset});
            this.cms_dgvProd.Name = "cms_dgvProd";
            this.cms_dgvProd.Size = new System.Drawing.Size(113, 98);
            // 
            // cms_dgvProd_Update
            // 
            this.cms_dgvProd_Update.Name = "cms_dgvProd_Update";
            this.cms_dgvProd_Update.Size = new System.Drawing.Size(112, 22);
            this.cms_dgvProd_Update.Text = "Update";
            // 
            // cms_dgvProd_tsiDelete
            // 
            this.cms_dgvProd_tsiDelete.Name = "cms_dgvProd_tsiDelete";
            this.cms_dgvProd_tsiDelete.Size = new System.Drawing.Size(112, 22);
            this.cms_dgvProd_tsiDelete.Text = "Delete";
            // 
            // cms_dgvProd_Separator
            // 
            this.cms_dgvProd_Separator.Name = "cms_dgvProd_Separator";
            this.cms_dgvProd_Separator.Size = new System.Drawing.Size(109, 6);
            // 
            // cms_dgvProd_tsiReset
            // 
            this.cms_dgvProd_tsiReset.Name = "cms_dgvProd_tsiReset";
            this.cms_dgvProd_tsiReset.Size = new System.Drawing.Size(112, 22);
            this.cms_dgvProd_tsiReset.Text = "Reset";
            // 
            // cmsInfo_tsiMore
            // 
            this.cmsInfo_tsiMore.Name = "cmsInfo_tsiMore";
            this.cmsInfo_tsiMore.Size = new System.Drawing.Size(126, 22);
            this.cmsInfo_tsiMore.Text = "More info";
            // 
            // cmsInfo_Less
            // 
            this.cmsInfo_Less.Name = "cmsInfo_Less";
            this.cmsInfo_Less.Size = new System.Drawing.Size(126, 22);
            this.cmsInfo_Less.Text = "Less info";
            // 
            // cmsFind_tsiReset
            // 
            this.cmsFind_tsiReset.Name = "cmsFind_tsiReset";
            this.cmsFind_tsiReset.Size = new System.Drawing.Size(102, 22);
            this.cmsFind_tsiReset.Text = "Reset";
            // 
            // cms_dgvProd_tsiAdd
            // 
            this.cms_dgvProd_tsiAdd.Name = "cms_dgvProd_tsiAdd";
            this.cms_dgvProd_tsiAdd.Size = new System.Drawing.Size(112, 22);
            this.cms_dgvProd_tsiAdd.Text = "Add";
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(199, 449);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(98, 33);
            this.btnConfirm.TabIndex = 53;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Age";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(132, 93);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(61, 24);
            this.rbtnMale.TabIndex = 54;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(210, 93);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(80, 24);
            this.rbtnFemale.TabIndex = 54;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(306, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 24);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Unisex";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(316, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 33);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 590);
            this.Controls.Add(this.gbxFind);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.gbxInfo);
            this.Name = "frmProd";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.cmsBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSize)).EndInit();
            this.cmsCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxName)).EndInit();
            this.gbxFind.ResumeLayout(false);
            this.gbxFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.cmsInfo.ResumeLayout(false);
            this.cmsFind.ResumeLayout(false);
            this.cms_dgvProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.PictureBox pbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox pbxSize;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.PictureBox pbxType;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.PictureBox pbxPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox pbxBrand;
        private System.Windows.Forms.GroupBox gbxFind;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.RadioButton rbtnType;
        private System.Windows.Forms.RadioButton rbtnBrand;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ContextMenuStrip cmsBrand;
        private System.Windows.Forms.ToolStripMenuItem cmsBrand_tsiAdd;
        private System.Windows.Forms.ToolStripSeparator cmsBrand_tsiSeparator;
        private System.Windows.Forms.ToolStripMenuItem cmsBrand_tsiOpen;
        private System.Windows.Forms.ContextMenuStrip cmsCategory;
        private System.Windows.Forms.ToolStripMenuItem cmsCategory_tsiAdd;
        private System.Windows.Forms.ToolStripSeparator cmsCategory_tsiSeparator;
        private System.Windows.Forms.ToolStripMenuItem cmsCategory_tsiOpen;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.ContextMenuStrip cmsInfo;
        private System.Windows.Forms.ContextMenuStrip cmsFind;
        private System.Windows.Forms.ToolStripMenuItem cmsInfo_tsiMore;
        private System.Windows.Forms.ToolStripMenuItem cmsInfo_Less;
        private System.Windows.Forms.ToolStripMenuItem cmsFind_tsiReset;
        private System.Windows.Forms.ContextMenuStrip cms_dgvProd;
        private System.Windows.Forms.ToolStripMenuItem cms_dgvProd_Update;
        private System.Windows.Forms.ToolStripMenuItem cms_dgvProd_tsiDelete;
        private System.Windows.Forms.ToolStripSeparator cms_dgvProd_Separator;
        private System.Windows.Forms.ToolStripMenuItem cms_dgvProd_tsiReset;
        private System.Windows.Forms.ToolStripMenuItem cms_dgvProd_tsiAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCancel;
    }
}