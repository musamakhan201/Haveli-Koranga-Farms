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
    public partial class Employees : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DIKMUE;Initial Catalog=HKFarms;Persist Security Info=True;User ID=sa;Password=123");
        public Employees()
        {
            InitializeComponent();
        }

        private void date_onValueChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void CheckFields()
        {
            try
            {
                if (name.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(name, "Enter Name");
                    name.LineFocusedColor = System.Drawing.Color.Red;
                    name.Focus();
                }

                else if (fname.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(fname, "Enter Father Name");
                    fname.LineFocusedColor = System.Drawing.Color.Red;
                    fname.Focus();
                }

                else if (cnic.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(cnic, "Enter CNIC");
                    cnic.LineFocusedColor = System.Drawing.Color.Red;
                    cnic.Focus();
                }

                else if (cnic.Text.Length != 13)
                {
                    errorProvider1.SetError(cnic, "Format Should be 3610241204111");
                    cnic.LineFocusedColor = System.Drawing.Color.Red;
                    cnic.Focus();
                }

                else if (phone.Text.Trim()==string.Empty)
                {
                    errorProvider1.SetError(phone, "Enter Phone Number");
                    phone.LineFocusedColor = System.Drawing.Color.Red;
                    phone.Focus();
                }

                else if (phone.Text.Length != 11)
                {
                    errorProvider1.SetError(phone, "Wrong Phone Number");
                    phone.LineFocusedColor = System.Drawing.Color.Red;
                    phone.Focus();
                }

                else if (type.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(type, "Enter Employee Type");
                    type.LineFocusedColor = System.Drawing.Color.Red;
                    type.Focus();
                }

                else if (salary.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(salary, "Enter Employee Salary");
                    salary.LineFocusedColor = System.Drawing.Color.Red;
                    salary.Focus();
                }

                else
                {
                    addEmployee();
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void addEmployee()
        {
            connection.Open();
            string sql= "INSERT INTO [dbo].[Employees]([Employee ID],[Employee Name],[Father Name],[CNIC],[Phone#],[Employee Type],[Salary] ,[Hire Date]) VALUES('" + idno.Text + "', '" + name.Text + "','" + fname.Text + "','" + cnic.Text + "','" + phone.Text + "','" + type.Text + "','" + salary.Text + "','" + hdate.Value.Date + "')";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Employee Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearFields();
            connection.Close();
            refreshGridData();
            AutoID();
        }

        private void refreshGridData()
        {
            connection.Open();
            string sq = ("select * from Employees order by [Employee ID]");
            SqlDataAdapter sda = new SqlDataAdapter(sq, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid1.DataSource = dt;
            connection.Close();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            AutoID();
            refreshGridData();
        }

        private void AutoID()
        {
            string id;
            connection.Open();
            SqlCommand s = new SqlCommand("select [Employee ID] from Employees order by [Employee ID] Desc", connection);
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

        private void update_Click(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            try
            {
                if (name.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(name, "Enter Name");
                    name.LineFocusedColor = System.Drawing.Color.Red;
                    name.Focus();
                }

                else if (fname.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(fname, "Enter Father Name");
                    fname.LineFocusedColor = System.Drawing.Color.Red;
                    fname.Focus();
                }

                else if (cnic.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(cnic, "Enter CNIC");
                    cnic.LineFocusedColor = System.Drawing.Color.Red;
                    cnic.Focus();
                }

                else if (cnic.Text.Length != 13)
                {
                    errorProvider1.SetError(cnic, "Format Should be 3610241204111");
                    cnic.LineFocusedColor = System.Drawing.Color.Red;
                    cnic.Focus();
                }

                else if (phone.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(phone, "Enter Phone Number");
                    phone.LineFocusedColor = System.Drawing.Color.Red;
                    phone.Focus();
                }

                else if (phone.Text.Length != 11)
                {
                    errorProvider1.SetError(phone, "Wrong Phone Number");
                    phone.LineFocusedColor = System.Drawing.Color.Red;
                    phone.Focus();
                }

                else if (type.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(type, "Enter Employee Type");
                    type.LineFocusedColor = System.Drawing.Color.Red;
                    type.Focus();
                }

                else if (salary.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(salary, "Enter Employee Salary");
                    salary.LineFocusedColor = System.Drawing.Color.Red;
                    salary.Focus();
                }

                else
                {
                    updateData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void updateData()
        {
            connection.Open();
            string sql = "UPDATE [dbo].[Employees] SET [Employee ID]='" + idno.Text + "',[Employee Name]='" + name.Text + "',[Father Name]='" + fname.Text + "',[CNIC]='" + cnic.Text + "',[Phone#]='" + phone.Text + "',[Employee Type]='" + type.Text + "',[Salary]='" + salary.Text + "' ,[Hire Date]='" + hdate.Value.Date + "' WHERE [Employee ID]='" + idno.Text+"'";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Employee Data Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearFields();
            connection.Close();
            refreshGridData();
            AutoID();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            clearFields();
            AutoID();
        }

        private void clearFields()
        {
            name.Text = "";
            fname.Text = "";
            phone.Text = "";
            cnic.Text = "";
            phone.Text = "";
            type.Text = "";
            salary.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "DELETE FROM [dbo].[Employees] WHERE [Employee ID]='" + idno.Text + "'";
            SqlCommand comd = new SqlCommand(sql, connection);
            comd.ExecuteNonQuery();
            MessageBox.Show("Employee Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearFields();
            connection.Close();
            refreshGridData();
            AutoID();
        }

        private void DataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGrid1.Rows[e.RowIndex];
                idno.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                fname.Text = row.Cells[2].Value.ToString();
                cnic.Text = row.Cells[3].Value.ToString();
                phone.Text = row.Cells[4].Value.ToString();
                type.Text = row.Cells[5].Value.ToString();
                salary.Text = row.Cells[6].Value.ToString();
                hdate.Text = row.Cells[7].Value.ToString();

            }
        }

        private void cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
