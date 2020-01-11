using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HK_Farms
{
    public partial class HomeItems : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DIKMUE;Initial Catalog=HKFarms;Persist Security Info=True;User ID=sa;Password=123");
        public HomeItems()
        {
            InitializeComponent();
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void petrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void rtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void HomeItems_Load(object sender, EventArgs e)
        {
            idate.Text = DateTime.Today.ToString("MM/dd/yyyy");
            gen_date.Text = DateTime.Today.ToString("MM/dd/yyyy");
            refreshGridData();
            AutoID();
        }
        private void AutoID()
        {
            string id;
            string idg;
            connection.Open();
            SqlCommand s = new SqlCommand("select [Item ID] from [dbo].[HomeItems] order by [Item ID] Desc", connection);
            SqlDataReader sdr = s.ExecuteReader();
            if (sdr.Read())
            {
                int i = int.Parse(sdr[0].ToString()) + 1;
                id = i.ToString("0");
            }
            else if (Convert.IsDBNull(sdr))
            {
                id = "1";
            }
            else
            {
                id = "1";
            }
            idno.Text = id.ToString();
            sdr.Close();
            SqlCommand sq = new SqlCommand("select [Usage ID] from [dbo].[GeneratorUse] order by [Usage ID] Desc", connection);
            SqlDataReader sdr1 = sq.ExecuteReader();
            if (sdr1.Read())
            {
                int i = int.Parse(sdr1[0].ToString()) + 1;
                idg = i.ToString("0");
            }
            else if (Convert.IsDBNull(sdr1))
            {
                idg = "1";
            }
            else
            {
                idg = "1";
            }
            id_gen.Text = idg.ToString();
            sdr1.Close();
            connection.Close();
        }
        private void refreshGridData()
        {
            connection.Open();
            string sq = ("select * from HomeItems order by [Item ID]");
            SqlDataAdapter sda = new SqlDataAdapter(sq, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid1.DataSource = dt;
            connection.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            validate();
        }
        private void validate()
        {
            try
            {
                if (item.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(item, "Enter Item Name");
                    item.Focus();
                }
                else if (details.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(details, "Enter Item Details");
                    details.Focus();
                }
                else if (amount.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(amount, "Enter Amount");
                    amount.Focus();
                }
                else
                {
                    insertData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
        private void insertData()
        {
            connection.Open();
            string sql = "INSERT INTO [dbo].[HomeItems]([Item ID],[Item Name],[Details],[Amount],[Paid Date],[Current Date]) VALUES('" + idno.Text + "', '" + item.Text + "','" + details.Text + "','" + amount.Text + "','" + date.Value.Date + "','" + idate.Text + "')";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Home Item Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            item.Text = "";
            details.Text = "";
            amount.Text = "";
            AutoID();
            refreshGridData();
        }

        private void submit_generator_Click(object sender, EventArgs e)
        {
            checkValidation();
        }

        private void checkValidation()
        {
            try
            {
                if (whom.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(whom, "Enter Enter For Whom Generator Was Running");
                    whom.Focus();
                }
                else if (details_gen.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(details_gen, "Enter Usage Details");
                    details_gen.Focus();
                }
                else if (rtime.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(rtime, "Enter Running Time");
                    rtime.Focus();
                }
                else if (petrol.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(petrol, "Enter Petrol Use");
                    petrol.Focus();
                }
                else
                {
                    insertDataGen();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void insertDataGen()
        {
            connection.Open();
            string sql = "INSERT INTO [dbo].[GeneratorUse]([Usage ID],[For Whom],[Details],[Running Time],[Petrol Use],[Paid Date],[Current Date]) VALUES('" + id_gen.Text + "', '" + whom.Text + "','" + details_gen.Text + "','" + rtime.Text + "','" + petrol.Text + "','" + date_gen.Value.Date + "','" + gen_date.Text + "')";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Generator Usage Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            whom.Text = "";
            details_gen.Text = "";
            rtime.Text = "";
            petrol.Text = "";
            AutoID();
            refreshGridData();
        }

        private void history_onItemSelected(object sender, EventArgs e)
        {
            if (history.selectedIndex==0)
            {
                refreshGridData();
            }
            else
            {
                connection.Open();
                string sq = ("select * from GeneratorUse order by [Usage ID]");
                SqlDataAdapter sda = new SqlDataAdapter(sq, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGrid1.DataSource = dt;
                connection.Close();
            }
        }
    }
}
