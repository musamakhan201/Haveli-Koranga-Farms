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
    public partial class Inventory : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DIKMUE;Initial Catalog=HKFarms;Persist Security Info=True;User ID=sa;Password=123");
        public Inventory()
        {
            InitializeComponent();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void credit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void debit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            idate.Text = DateTime.Today.ToString("MM/dd/yyyy");
            AutoID();
            refresh();
        }

        private void refresh()
        {
            connection.Open();
            SqlCommand s = new SqlCommand("select [Dealer Name] from [dbo].[Dealers] order by [Dealer ID] Desc", connection);
            SqlDataAdapter adpt = new SqlDataAdapter(s);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                dealer.Items.Add(dr["Dealer Name"].ToString());
            }
            connection.Close();
        }

        private void AutoID()
        {
            string id;
            string idg;
            connection.Open();
            SqlCommand s = new SqlCommand("select [Dealer ID] from [dbo].[Dealers] order by [Dealer ID] Desc", connection);
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
            SqlCommand sq = new SqlCommand("select [Item ID] from [dbo].[InventoryItems] order by [Item ID] Desc", connection);
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
            lblid.Text = idg.ToString();
            sdr1.Close();
            connection.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            validate();
        }
            private void validate()
            {
                try
                {
                    if (dname.Text.Trim() == string.Empty)
                    {
                        errorProvider1.SetError(dname, "Enter Dealer Name");
                        dname.Focus();
                    }
                    else if (phone.Text.Trim() == string.Empty|| phone.Text.Length != 11)
                    {
                        errorProvider1.SetError(phone, "Enter Correct Phone");
                        phone.Focus();
                    }
                    else if (cname.Text.Trim() == string.Empty)
                    {
                        errorProvider1.SetError(cname, "Enter Company Name");
                        cname.Focus();
                    }
                    else if (items.Text.Trim() == string.Empty)
                    {
                        errorProvider1.SetError(items, "Enter Item Dealer Deals");
                        items.Focus();
                    }
                    else if (address.Text.Trim() == string.Empty)
                    {
                        errorProvider1.SetError(address, "Enter Company Address");
                        address.Focus();
                    }
                else if (credit.Text.Trim() == string.Empty)
                {
                    credit.Text = "0";
                }
                else if (debit.Text.Trim() == string.Empty)
                {
                    debit.Text = "0";
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
           void insertData()
            {
                connection.Open();
                string sql = "INSERT INTO [dbo].[Dealers]([Dealer ID],[Dealer Name],[Phone],[Company Name],[Items Sale],[Company Address],[Credit],[Debit],[Add Date]) VALUES('" + idno.Text + "', '" + dname.Text + "','" + phone.Text + "','" + cname.Text + "','" + items.Text + "','" + address.Text + "','" + credit.Text + "','" + debit.Text + "','" + date.Value.Date + "')";
                SqlCommand comd = new SqlCommand(sql, connection);
                comd.ExecuteNonQuery();
                MessageBox.Show("Dealer Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                dname.Text = "";
                phone.Text = "";
                cname.Text = "";
                items.Text = "";
                address.Text = "";
                AutoID();
            }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void tprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void credita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void debita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
    }
