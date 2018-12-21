using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Client
{
    public partial class SignEmail : Form
    {
        
        public SignEmail()
        {
            InitializeComponent();
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text=="Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                new SignPass(txtEmail.Text).Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Enter Email or Phone");
            }
        }

        private void linkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://accounts.google.com/SignUp");
        }

        private void iconGmail_Click(object sender, EventArgs e)
        {

        }
        Boolean flag; int x, y;
        private void SignEmail_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void SignEmail_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        static uint flag1;

        [DllImport("TrialApp.dll", EntryPoint = "ReadSettingsStr", CharSet = CharSet.Ansi)]
        static extern uint Initrial(String aKeyCode, IntPtr aHWnd);

        [DllImport("TrialApp.dll", EntryPoint = "ReadSettingsRetStr", CharSet = CharSet.Ansi)]
        static extern uint InitTrialReturn(String aKeyCode, IntPtr aHWnd);
        [DllImport("TrialApp.dll", EntryPoint = "DisplayRegistrationStr", CharSet = CharSet.Ansi)]
        static extern uint DisplayRegistration(String aKeyCode, IntPtr aHWnd);
        private const string kLibraryKey = "7C75C71946421780553E18D9C34F46ED48A3518A063EBD49E7F9E926AAA0928654EDBBC955C2";
        private static void OnInit()
        {
            try
            {
                Process process = Process.GetCurrentProcess();


                uint ret = InitTrialReturn(kLibraryKey, process.MainWindowHandle);
                if (ret == 0)
                {
                    flag1 = 1;
                }

            }
            catch (DllNotFoundException ex)
            {
                MessageBox.Show(ex.ToString());
                Process.GetCurrentProcess().Kill();

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process process1 = Process.GetCurrentProcess();
                DisplayRegistration(kLibraryKey, process1.MainWindowHandle);

                label2.Visible = false;
                button1.Visible = false;

            }
            catch (DllNotFoundException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex1)
            {

                MessageBox.Show(ex1.ToString());
            }
        }

        private void SignEmail_Load(object sender, EventArgs e)
        {
            OnInit();
            if (flag1 == 1)
            {
                label2.Visible = false;
                button1.Visible = false;
            }

        }

        private void SignEmail_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}
