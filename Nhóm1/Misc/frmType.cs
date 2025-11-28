using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAccess;

namespace Nhóm1.TSon
{
    public partial class frmType : Form
    {
        int mode = 0;
        public frmType()
        {
            InitializeComponent();
            this.Height = 210;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadType();
        }
        private void LoadType()
        {
            using(SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from [Type]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                TypeToList(dt);
            }
        }
        private void TypeToList(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["Name"].ToString());

                lvwCategory.Items.Add(item);
            }
        }

        private void tsiAdd_Click(object sender, EventArgs e)
        {
            this.mode = 1;
            ResizeForm(0);
            EnableControl(true);
            lvwCategory.Enabled = false;
        }

        private void tsiUpdate_Click(object sender, EventArgs e)
        {
            this.mode = 2;
            ResizeForm(0);
            EnableControl(true);
            lvwCategory.Enabled = false;
            this.txtName.Text = lvwCategory.SelectedItems[0].SubItems[1].Text;
        }

        private void tsiDelete_Click(object sender, EventArgs e)
        {
            this.mode = 3;
            if (MessageBox.Show("Are you sure to Delete", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (InsertUpdateDelete(mode) > 0)
                {
                    MessageBox.Show("Delete success");
                }
                else
                {
                    MessageBox.Show("delete failed");
                }
                btnCancel.PerformClick();
            }
        }
        private int InsertUpdateDelete(int mode)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                switch (mode)
                {
                    case 1:
                        cmd.CommandText = $"Insert Into [Type]  ([Name]) values (N'{txtName.Text}')";
                        break;
                    case 2:
                        cmd.CommandText = $"Update [Type] set [Name] = @Name where ID = @ID";
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = txtName.Text;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(lvwCategory.SelectedItems[0].SubItems[0].Text.ToString());
                        break;
                    case 3:
                        cmd.CommandText = $"Delete [Type] where ID = " + Convert.ToInt32(lvwCategory.SelectedItems[0].SubItems[0].Text.ToString());
                        break;
                    default:
                        return 0;
                }
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }
        private void tsiDeselect_Click(object sender, EventArgs e)
        {
            this.lvwCategory.SelectedItems.Clear();
        }

        private void tsiReload_Click(object sender, EventArgs e)
        {
            this.lvwCategory.Items.Clear();
            LoadType();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (InsertUpdateDelete(mode) > 0)
                {
                    if (mode == 1)
                    {
                        MessageBox.Show("Success Adding");
                    }
                    else if (mode == 2)
                    {
                        MessageBox.Show("Succes Updating");
                    }
                    btnCancel.PerformClick();
                }
                else
                    MessageBox.Show("Something gone wrong");
            }
            else
                MessageBox.Show("Wrong Name");
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableControl(false);
            ResizeForm(1);
            ClearText();
            tsiDeselect.PerformClick();
            mode = 0;
            lvwCategory.Enabled = true;
            tsiReload.PerformClick();
        }
        private void ClearText()
        {
            txtName.Text = string.Empty;
        }
        private void ResizeForm(int mode)
        {
            if (mode == 0)
                while (this.Height < 300) this.Height += 2;
            else if (mode == 1)
                while (this.Height > 210) this.Height -= 2;
        }
        private void EnableControl(bool status)
        {
            lblName.Enabled = status;
            lblName.Visible = status;

            txtName.Enabled = status;
            txtName.Visible = status;

            btnConfirm.Enabled = status;
            btnConfirm.Visible = status;

            btnCancel.Enabled = status;
            btnCancel.Visible = status;
        }
        private void EnableContext(bool status)
        {
            tsiAdd.Enabled = status;
            tsiAdd.Visible = status;

            tsiUpdate.Enabled = status;
            tsiUpdate.Visible = status;

            tsiDelete.Enabled = status;
            tsiDelete.Visible = status;

            tsiDeselect.Enabled = status;
            tsiDeselect.Visible = status;
        }
        private void lvwCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwCategory.SelectedItems.Count > 0)
            {
                EnableContext(true);

                tsiAdd.Enabled = false;
                tsiAdd.Visible = false;
            }
            else
            {
                EnableContext(false);

                tsiAdd.Enabled = true;
                tsiAdd.Visible = true;
            }
        }
    }
}