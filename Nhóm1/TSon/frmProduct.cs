using Nhóm1.TSon;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1
{
    public partial class frmProd : Form
    {
        int mode = 0;
        public frmProd()
        {
            InitializeComponent();
        }
        #region Event
        #region Info
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                if (mode == 1)
                {
                    if (InsertUpdateDelete(mode) > 0)
                    {
                        MessageBox.Show("Insert sucess");
                    }
                }
                else if (mode == 2)
                {
                    if (InsertUpdateDelete(mode) > 0)
                    {
                        MessageBox.Show("Update sucess");
                    }
                }
                btnCancel.PerformClick();
            }
            else
                MessageBox.Show("Wrong info.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cms_dgvProd_tsiDeselect.PerformClick();
            gbxInfo.Enabled = false;
            gbxFind.Enabled = true;
            this.mode = 0;
        }

        private void cmsType_tsiAdd_Click(object sender, EventArgs e)
        {
            //Form form = new Form()
            //{
            //    Width = 400,
            //    Height = 150,
            //    FormBorderStyle = FormBorderStyle.FixedDialog,
            //    Text = "Add Type",
            //    StartPosition = FormStartPosition.CenterScreen
            //};
            //Label textLabel = new Label() { Left = 20, Top = 20, Text = "Type", AutoSize = true };
            //TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };

            //Button okButton = new Button() { Text = "OK", Left = 200, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            //Button cancelButton = new Button() { Text = "Cancel", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

            //okButton.Click += (sender, e) => { form.Close(); };
            //cancelButton.Click += (sender, e) => { form.Close(); };

            //form.Controls.Add(textLabel);
            //form.Controls.Add(textBox);
            //form.Controls.Add(okButton);
            //form.Controls.Add(cancelButton);

            //form.AcceptButton = okButton;
            //form.CancelButton = cancelButton;


        }

        private void cmsType_tsiOpen_Click(object sender, EventArgs e)
        {
            frmType frmType = new frmType();
            frmType.ShowDialog(this);
        }

        private void cmsBrand_tsiAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmsBrand_tsiOpen_Click(object sender, EventArgs e)
        {
            frmBrand frmBrand = new frmBrand();
            frmBrand.ShowDialog(this);
        }

        private void cmsInfo_tsiMore_Click(object sender, EventArgs e)
        {

        }

        private void cmsInfo_Less_Click(object sender, EventArgs e)
        {

        }
        #endregion Info
        #region Find
        private void txtFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.Text == "Enter keyword")
            {
                txtFind.Text = string.Empty;
                txtFind.ForeColor = Color.Black;
            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                txtFind.Text = "Enter keyword";
                txtFind.ForeColor = Color.Gray;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFind.Text))
            {
                if (txtFind.Text == "Enter keyword")
                {
                    LoadDGVProd();
                    return;
                }
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    if (rbtnBrand.Checked)
                    {
                        cmd.CommandText = $@"
                                            select i.ID,
                                                i.[Name],
                                                case i.Gender
                                                    when 0 then 'Unisex'
                                                    when 1 then 'Male'
                                                    when 2 then 'Female'
                                                end as Gender,
                                                i.Age, i.Size, 
                                                t.[Name] as TypeName,
                                                i.Price,
                                                i.Stock,
                                                b.[Name] as BrandName
                                            from item i
                                            inner join Brand b on i.BrandID = b.ID
                                            inner join [Type] t on t.ID = i.TypeID
                                            where i.Actived = 1 and b.[Name] = N'{txtFind.Text}';";
                    }
                    if (rbtnType.Checked)
                    {
                        cmd.CommandText = $@"
                                            select
                                                i.ID,
                                                i.[Name],
                                                case i.Gender
                                                    when 0 then 'Unisex'
                                                    when 1 then 'Male'
                                                    when 2 then 'Female'
                                                end as Gender,
                                                i.Age,
                                                i.Size,
                                                t.[Name] as TypeName,
                                                i.Price,
                                                i.Stock,
                                                b.[Name] as BrandName
                                            from item i
                                            inner join Brand b on i.BrandID = b.ID
                                            inner join [Type] t on t.ID = i.TypeID
                                            where i.Actived = 1and t.[Name] = N'{txtFind.Text};";
                    }
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Product");
                    da.Fill(dt);
                    dgvProd.DataSource = dt;
                }
            }
        }

        private void cms_dgvProd_tsiAdd_Click(object sender, EventArgs e)
        {
            if (dgvProd.CurrentRow == null)
            {
                ResetInfo();
                mode = 1;
                gbxInfo.Enabled = true;
                gbxFind.Enabled = false;
            }
        }

        private void cms_dgvProd_Update_Click(object sender, EventArgs e)
        {
            if(dgvProd.CurrentRow != null)
            {
                mode = 2;
                gbxInfo.Enabled = true;
                gbxFind.Enabled = false;
            }
        }

        private void cms_dgvProd_tsiDelete_Click(object sender, EventArgs e)
        {
            this.mode = 3;
            if (InsertUpdateDelete(mode) > 0)
            {
                MessageBox.Show("success Delete");
            }
            else
            {
                MessageBox.Show("Falied Delete");
            }
            cms_dgvProd_tsiReset.PerformClick();
        }

        private void cms_dgvProd_tsiReset_Click(object sender, EventArgs e)
        {
            LoadDGVProd();
            LoadType();
            LoadBrand();
            ResetInfo();
            cmsFind_tsiReset.PerformClick();
        }

        private void cmsFind_tsiReset_Click(object sender, EventArgs e)
        {
            txtFind_Leave(sender, e);
        }
        #endregion Find

        private void frmProduct_Load(object sender, EventArgs e)
        {
            txtFind_Leave(sender, e);
            this.gbxInfo.Enabled = false;
            LoadDGVProd();
            LoadBrand();
            LoadType();
            cms_dgvProd_tsiDeselect.PerformClick();
        }
        private void KeyPressNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        #endregion Event
        #region Method
        private void LoadDGVProd()
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(@"
                    select
                        i.ID,
                        i.[Name],
                        case i.Gender
                            when 0 then 'Unisex'
                            when 1 then 'Male'
                            when 2 then 'Female'
                        end as Gender,
                        i.Age,
                        i.Size,
                        t.[Name] as TypeName,
                        i.Price, i.Stock,
                        b.[Name] as BrandName
                    from item i
                    inner join Brand b on i.BrandID = b.ID
                    inner join [Type] t on t.ID = i.TypeID
                    where i.Actived = 1;",
                    conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Product");
                da.Fill(dt);
                dgvProd.DataSource = dt;
                cms_dgvProd_tsiDeselect.PerformClick();
            }
        }
        private void EnableInfoControl(bool status)
        {
            this.txtName.Enabled = status;
            this.rbtnMale.Enabled = status;
            this.rbtnFemale.Enabled = status;
            this.rbtnUni.Enabled = status;
            this.txtAge.Enabled = status;
            this.cbxType.Enabled = status;
            this.nudSize.Enabled = status;
            this.txtPrice.Enabled = status;
            this.cbxBrand.Enabled = status;

            this.btnConfirm.Enabled = status;
            this.btnCancel.Enabled = status;
        }
        private void RowToControl(DataGridViewRow row)
        {
            txtName.Text = row.Cells["colName"].Value.ToString();
            switch ((string)row.Cells["colGender"].Value)
            {
                case "Unisex":
                    rbtnUni.Checked = true;
                    break;
                case "Male":
                    rbtnMale.Checked = true;
                    break;
                case "Female":
                    rbtnFemale.Checked = true;
                    break;
                default:
                    break;
            }
            txtAge.Text = row.Cells["colAge"].Value.ToString();
            cbxType.SelectedIndex = cbxType.Items.IndexOf(row.Cells["colType"].Value.ToString());
            nudSize.Value = (int)row.Cells["colSize"].Value;
            txtPrice.Text = row.Cells["colPrice"].Value.ToString();
            cbxBrand.SelectedIndex = cbxBrand.Items.IndexOf(row.Cells["colBrand"].Value.ToString());
        }
        #endregion Method

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProd.CurrentRow != null && dgvProd.Rows.Count - 1 > dgvProd.CurrentRow.Index)
            {
                cms_dgvProd_tsiAdd.Enabled = false;
                cms_dgvProd_tsiAdd.Visible = false;

                cms_dgvProd_tsiUpdate.Enabled = true;
                cms_dgvProd_tsiUpdate.Visible = true;

                cms_dgvProd_tsiDeselect.Enabled = true;
                cms_dgvProd_tsiDeselect.Visible = true;

                RowToControl(dgvProd.CurrentRow);
            }
        }
        private void LoadType()
        {
            cbxType.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select Name from [Type]", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                    cbxType.Items.Add(row[0].ToString());
            }
        }
        private void LoadBrand()
        {
            cbxBrand.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select Name from Brand", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                    cbxBrand.Items.Add(row[0].ToString());
            }
        }

        private void cms_dgvProd_tsiDeselect_Click(object sender, EventArgs e)
        {
            dgvProd.ClearSelection();
            dgvProd.CurrentCell = null;
            ResetInfo();
        }
        private void ResetInfo()
        {
            txtName.Text = string.Empty;
            rbtnMale.Checked = true;
            txtAge.Text = string.Empty;
            cbxType.SelectedIndex = -1;
            nudSize.Value = nudSize.Minimum;
            txtPrice.Text = string.Empty;
            cbxBrand.SelectedIndex = -1;
        }
        private int InsertUpdateDelete(int mode)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                int gender = 0, type, brand;

                conn.Open();

                cmd.CommandText = $"Select ID from Type where Name = N'{cbxType.SelectedItem}'";
                type = (int)cmd.ExecuteScalar();
                cmd.CommandText = $"Select ID from Brand where Name = N'{cbxBrand.SelectedItem}'";
                brand = (int)cmd.ExecuteScalar();

                if (rbtnMale.Checked)
                    gender = 1;
                else if (rbtnFemale.Checked)
                    gender = 2;
                else if (rbtnUni.Checked)
                    gender = 0;

                switch (mode)
                {

                    case 1:
                        cmd.CommandText =
                            string.Format("insert into [Item] ([Name], Gender, Age, [TypeID], Size, Price, Stock, BrandID) values (N'{0}',{1},N'{2}',{3},{4},{5},{6},{7})",
                                txtName.Text,
                                gender,
                                txtAge.Text,
                                type,
                                (int)nudSize.Value,
                                txtPrice.Text,
                                0,
                                brand
                            );
                        break;
                    case 2:
                        cmd.CommandText =
                            string.Format("update [Item] set [Name] = N'{0}', Gender = {1}, Age = N'{2}', [TypeID] = {3}, Size = {4}, Price = {5}, Stock = {6}, BrandID = {7} where ID = {8}",
                                txtName.Text,
                                gender,
                                txtAge.Text,
                                type,
                                (int)nudSize.Value,
                                txtPrice.Text,
                                dgvProd.SelectedRows[0].Cells["colStock"].Value.ToString(),
                                brand,
                                dgvProd.SelectedRows[0].Cells["colID"].Value.ToString()
                            );
                        break;
                    case 3:
                        cmd.CommandText = "update [Item] set Actived = 0 where ID = " + dgvProd.SelectedRows[0].Cells["colID"].Value.ToString();
                        break;
                    default:
                        return 0;
                }

                int result = cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
                return result;
            }
        }
        private bool CheckValue()
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
                if (!string.IsNullOrWhiteSpace(txtAge.Text))
                    if (cbxType.SelectedIndex > -1)
                        if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                            if (cbxBrand.SelectedIndex > -1)
                                return true;
            return false;
        }

        private void dgvProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows.Count == 0)
            {
                cms_dgvProd_tsiAdd.Enabled = true;
                cms_dgvProd_tsiAdd.Visible = true;

                cms_dgvProd_tsiUpdate.Enabled = false;
                cms_dgvProd_tsiUpdate.Visible = false;

                cms_dgvProd_tsiDeselect.Enabled = false;
                cms_dgvProd_tsiDeselect.Visible = false;

                ResetInfo();
            }
        }
    }
}
