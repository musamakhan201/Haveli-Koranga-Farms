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
    public partial class UtilityBills : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DIKMUE;Initial Catalog=HKFarms;Persist Security Info=True;User ID=sa;Password=123");
        public UtilityBills()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void validate()
        {
            try
            {
                if (bills.selectedIndex==0)
                {
                    errorProvider1.SetError(bills, "Select Bill");
                    bills.Focus();
                }
                else if (month.selectedIndex == 0)
                {
                    errorProvider1.SetError(month, "Select Month");
                    month.Focus();
                }
                else if (amount.Text.Trim()==string.Empty)
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
            string sql = "INSERT INTO [dbo].[UtilityBills]([Bill ID],[Bill Name],[Bill Month],Fine,Amount,[Paid Date],InsertDate) VALUES('" + idno.Text + "', '" + bills.selectedValue + "','" + month.selectedValue + "','" + fine.selectedValue + "','" + amount.Text + "','" +date.Value.Date + "','"+idate.Text+"')";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Bill Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bills.selectedIndex = 0;
            month.selectedIndex = 0;
            amount.Text = "";
            connection.Close();
            refreshGridData();
            AutoID();
        }

        private void UtilityBills_Load(object sender, EventArgs e)
        {
            idate.Text = DateTime.Today.ToString("MM/dd/yyyy");
            AutoID();
            refreshGridData();
        }
        private void AutoID()
        {
            string id;
            connection.Open();
            SqlCommand s = new SqlCommand("select [Bill ID] from [dbo].[UtilityBills] order by [Bill ID] Desc", connection);
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
            connection.Close();
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void refreshGridData()
        {
            connection.Open();
            string sq = ("select * from UtilityBills order by [Bill ID]");
            SqlDataAdapter sda = new SqlDataAdapter(sq, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid1.DataSource = dt;
            connection.Close();
        }
    }
}
