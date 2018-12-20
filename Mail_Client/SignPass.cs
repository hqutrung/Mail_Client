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
    public partial class SignPass : Form
    {
        string email;
        public SignPass(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = null;
            txtPass.isPassword = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPass.Text))
            {
                try
                {
                    MailMessage mess = new MailMessage();
                    mess.From = new MailAddress(email);
                    mess.To.Add(email);
                    mess.Subject = "Verification";
                    mess.Body = "You are logining Mail App with " + email;
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(email, txtPass.Text);
                    client.Send(mess);
                    new MainForm(email, txtPass.Text).Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your account or password is incorrect");
                    txtPass.Text = null;
                }
                
            }
            else
            {
                errorProvider1.SetError(txtPass, "Enter Password");
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://accounts.google.com/signin/recovery");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new SignEmail().Show();
            this.Hide();
        }
        Boolean flag; int x, y;
        private void SignPass_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void SignPass_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void SignPass_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

    }
}
