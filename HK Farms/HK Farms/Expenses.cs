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
    public partial class Expenses : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DIKMUE;Initial Catalog=HKFarms;Persist Security Info=True;User ID=sa;Password=123");
        public Expenses()
        {
            InitializeComponent();
        }


        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void validate()
        {
            try
            {
                if (etype.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(etype, "Enter Expense Type");
                    etype.Focus();
                }
                else if (details.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(details, "Enter Expense Details");
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
            string sql = "INSERT INTO [dbo].[Expenses]([Expense ID],[Expense Type],[Details],[Amount],[Paid Date],[Current Date]) VALUES('" + idno.Text + "', '" + etype.Text + "','" + details.Text + "','" + amount.Text + "','" + date.Value.Date + "','" + idate.Text + "')";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Expense Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            etype.Text = "";
            details.Text = "";
            amount.Text = "";
            AutoID();
            refreshGridData();
        }
        private void refreshGridData()
        {
            connection.Open();
            string sq = ("select * from Expenses order by [Expense ID]");
            SqlDataAdapter sda = new SqlDataAdapter(sq, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid1.DataSource = dt;
            connection.Close();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            idate.Text = DateTime.Today.ToString("MM/dd/yyyy");
            refreshGridData();
            AutoID();
        }
        private void AutoID()
        {
            string id;
            connection.Open();
            SqlCommand s = new SqlCommand("select [Expense ID] from [dbo].[Expenses] order by [Expense ID] Desc", connection);
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

        private void submit_Click(object sender, EventArgs e)
        {
            validate();
        }
    }
}
