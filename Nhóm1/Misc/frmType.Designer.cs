namespace Nhóm1.TSon
{
    partial class frmType
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
            this.lvwCategory = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsiDeselect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmsType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCategory
            // 
            this.lvwCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName});
            this.lvwCategory.ContextMenuStrip = this.cmsType;
            this.lvwCategory.FullRowSelect = true;
            this.lvwCategory.GridLines = true;
            this.lvwCategory.HideSelection = false;
            this.lvwCategory.Location = new System.Drawing.Point(12, 12);
            this.lvwCategory.MultiSelect = false;
            this.lvwCategory.Name = "lvwCategory";
            this.lvwCategory.Size = new System.Drawing.Size(184, 159);
            this.lvwCategory.TabIndex = 1;
            this.lvwCategory.UseCompatibleStateImageBehavior = false;
            this.lvwCategory.View = System.Windows.Forms.View.Details;
            this.lvwCategory.SelectedIndexChanged += new System.EventHandler(this.lvwCategory_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 120;
            // 
            // cmsType
            // 
            this.cmsType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAdd,
            this.tsiUpdate,
            this.tsiDelete,
            this.tsiSeparator,
            this.tsiDeselect,
            this.tsiReload});
            this.cmsType.Name = "cmsType";
            this.cmsType.Size = new System.Drawing.Size(119, 120);
            // 
            // tsiAdd
            // 
            this.tsiAdd.Name = "tsiAdd";
            this.tsiAdd.Size = new System.Drawing.Size(118, 22);
            this.tsiAdd.Text = "Add";
            this.tsiAdd.Click += new System.EventHandler(this.tsiAdd_Click);
            // 
            // tsiUpdate
            // 
            this.tsiUpdate.Name = "tsiUpdate";
            this.tsiUpdate.Size = new System.Drawing.Size(118, 22);
            this.tsiUpdate.Text = "Update";
            this.tsiUpdate.Click += new System.EventHandler(this.tsiUpdate_Click);
            // 
            // tsiDelete
            // 
            this.tsiDelete.Name = "tsiDelete";
            this.tsiDelete.Size = new System.Drawing.Size(118, 22);
            this.tsiDelete.Text = "Delete";
            this.tsiDelete.Click += new System.EventHandler(this.tsiDelete_Click);
            // 
            // tsiSeparator
            // 
            this.tsiSeparator.Name = "tsiSeparator";
            this.tsiSeparator.Size = new System.Drawing.Size(115, 6);
            // 
            // tsiDeselect
            // 
            this.tsiDeselect.Name = "tsiDeselect";
            this.tsiDeselect.Size = new System.Drawing.Size(118, 22);
            this.tsiDeselect.Text = "Deselect";
            this.tsiDeselect.Click += new System.EventHandler(this.tsiDeselect_Click);
            // 
            // tsiReload
            // 
            this.tsiReload.Name = "tsiReload";
            this.tsiReload.Size = new System.Drawing.Size(118, 22);
            this.tsiReload.Text = "Reload";
            this.tsiReload.Click += new System.EventHandler(this.tsiReload_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 227);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 193);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 261);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lvwCategory);
            this.Name = "frmType";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.cmsType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwCategory;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ContextMenuStrip cmsType;
        private System.Windows.Forms.ToolStripMenuItem tsiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsiDelete;
        private System.Windows.Forms.ToolStripSeparator tsiSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsiDeselect;
        private System.Windows.Forms.ToolStripMenuItem tsiReload;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblName;
    }
}