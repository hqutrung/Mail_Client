using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Client
{
    public partial class SignEmail : Form
    {
        bool ok;
        
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
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmail.Visible = false;
            }
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

        private void SignEmail_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}
