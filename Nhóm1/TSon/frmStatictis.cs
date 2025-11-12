using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAccess;

namespace Nhóm1
{
    public partial class frmStatictis : Form
    {
        DateTime from = DateTime.MinValue;
        DateTime to = DateTime.Now;
        int mode = -1;// 0 = day, 1 = month, 2 = year, 3 = custom
        public frmStatictis()
        {
            InitializeComponent();
        }
        private void frmStatistic_Load(object sender, EventArgs e)
        {
            Series series = new Series("Money");
            series.ChartType = SeriesChartType.Area;
            series.Points.AddXY("September", 100);
            series.Points.AddXY("October", 120);
            series.Points.AddXY("November", 130);

            chartStatistic.Series.Add(series);

            tsiLWeek.PerformClick();
        }

        private void tsiLWeek_Click(object sender, EventArgs e)
        {
            tsFilter_sbtnFilter.Text = tsiLWeek.Text;
            EnableControl(false);
            ResetDTP();
            this.dtpFrom.Value = DateTime.Now.AddDays(-9);
            this.from = this.dtpFrom.Value;
            this.mode = 0;

        }

        private void tsiL28D_Click(object sender, EventArgs e)
        {
            tsFilter_sbtnFilter.Text = tsiL28D.Text;
            EnableControl(false);
            ResetDTP();
            this.dtpFrom.Value = DateTime.Now.AddDays(-28);
            this.from = this.dtpFrom.Value;
            this.mode = 0;
        }

        private void tsiL90D_Click(object sender, EventArgs e)
        {
            tsFilter_sbtnFilter.Text = tsiL90D.Text;
            EnableControl(false);
            ResetDTP();
            this.dtpFrom.Value = DateTime.Now.AddDays(-90);
            this.from = this.dtpFrom.Value;
        }

        private void tsiYear_Click(object sender, EventArgs e)
        {
            tsFilter_sbtnFilter.Text = tsiYear.Text;
            this.mode = 3;

            this.dtpTo.Enabled = false;
            this.dtpTo.Visible = false;
            this.lblTo.Visible = false;

            this.lblFrom.Text = "Year";
        }

        private void tsiMonth_Click(object sender, EventArgs e)
        {
            tsFilter_sbtnFilter.Text = tsiMonth.Text;
            this.mode = 2;

            this.dtpTo.Enabled = false;
            this.dtpTo.Visible = false;
            this.lblTo.Visible = false;

            this.lblFrom.Text = "Month";
        }

        private void tsiCustom_Click(object sender, EventArgs e)
        {
            tsFilter_sbtnFilter.Text = tsiCustom.Text;
            this.mode = 4;

            this.dtpTo.Enabled = true;
            this.dtpTo.Visible = true;
            this.lblTo.Visible = true;

            this.lblFrom.Text = "From";
        }
        private void EnableControl(bool status)
        {
            this.dtpFrom.Enabled = status;
            this.dtpFrom.Visible = status;
            this.dtpFrom.Visible = status;

            this.dtpTo.Enabled = status;
            this.dtpTo.Visible = status;
            this.lblTo.Visible = status;
        }
        private DataTable SelectFromTo(DateTime from, DateTime to)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"Select Total, [Date] from Bill where [Date] between {from} and {to} order by [Date]";
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("SelectFromTo");
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        //private DataTable SelectDate(DateTime date)
        //{
        //    using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("GetBillByDate", conn);
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable("Bill");
        //        adapter.Fill(dt);
        //        conn.Close();
        //        return dt;
        //    }
        //}
        private DataTable SelectDays(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBillByDate", conn);
                cmd.Parameters.Add("@day", SqlDbType.Int).Value = date.Day;
                cmd.Parameters.Add("@month", SqlDbType.Int).Value = date.Month;
                cmd.Parameters.Add("@year", SqlDbType.Int).Value = date.Year;
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("BillByDay");
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        private DataTable SelectMonth(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBillByDate", conn);
                cmd.Parameters.Add("@month", SqlDbType.Int);
                cmd.Parameters.Add("@month", SqlDbType.Int).Value = date.Month;
                cmd.Parameters.Add("@year", SqlDbType.Int).Value = date.Year;
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("BillByMonth");
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        private DataTable SelectYear(int year)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBillByDate", conn);
                cmd.Parameters.Add("@month", SqlDbType.Int);
                cmd.Parameters.Add("@month", SqlDbType.Int);
                cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("BillByYear");
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        private bool checkDate(DateTime a, DateTime b)
        {
            return a.CompareTo(b) <= 0;
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!checkDate(dtpFrom.Value, dtpTo.Value))
            {
                MessageBox.Show("Date From must early than To");
                dtpFrom.Value = this.from;
                dtpTo.Value = this.to;
            }
            else
            {
                this.from = dtpFrom.Value;
                this.to = dtpTo.Value;
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (!checkDate(dtpFrom.Value, dtpTo.Value))
            {
                MessageBox.Show("Date From must later than To");
                dtpFrom.Value = this.from;
                dtpTo.Value = this.to;
            }
            else
            {
                this.from = dtpFrom.Value;
                this.to = dtpTo.Value;
            }
        }
        private void ResetDTP()
        {
            this.from = DateTime.MinValue;
            this.to = DateTime.Now;
            this.dtpFrom.Value = this.from;
            this.dtpTo.Value = this.to;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataTable dt;
            switch (mode)
            {
                case 0:
                case 4:
                    {
                        dt = SelectFromTo(from, to);
                        break;
                    }

                case 1:
                    {
                        dt = SelectMonth(from);
                        break;
                    }

                case 2:
                    {
                        dt = SelectYear(from.Year);
                        break;
                    }
                default:
                    return;
            }
            TableToChart(dt);


            this.mode = -1;
        }
        private void TableToChart(DataTable dt)
        {
            if (mode == 0)
            {
                
            }
            else if (mode == 1)
            {

            }
            else if (mode == 2)
            {

            }
            else if (mode == 3)
            {

            }
            else if (mode == 4)
            {

            }
        }
    }
}
