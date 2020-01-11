using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HK_Farms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void farm_Click(object sender, EventArgs e)
        {
            Farm farm = new Farm();
            this.Close();
            farm.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            employees1.Hide();
            inventory1.Hide();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Hide();
        }
        private void main_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Hide();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            employees1.Show();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Hide();
        }

        private void homeitems_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            homeItems1.Show();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Hide();
        }

        private void homerestoration_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            homeItems1.Hide();
            homeRestoration1.Show();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Hide();
        }

        private void utilitybills_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Show();
            expenses1.Hide();
            aboutUs1.Hide();
        }

        private void expenses_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Show();
            aboutUs1.Hide();
        }

        private void aboutus_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Show();
        }

        private void machinery_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Comming Soon.....", "Comming", 1000);
        }
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            employees1.Hide();
            inventory1.Show();
            homeItems1.Hide();
            homeRestoration1.Hide();
            utilityBills1.Hide();
            expenses1.Hide();
            aboutUs1.Hide();
        }

        private void politics_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Comming Soon.....", "Comming", 1000);
        }

        private void usersetting_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Comming Soon.....", "Comming", 1000);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
