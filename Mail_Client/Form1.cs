using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;
using System.IO;
using System.Threading;
namespace Mail_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(txtTo.Text);
                mail.From = new MailAddress(txtEmail.Text);
                mail.Subject = txtSubject.Text;
                mail.Body = rtbBody.Text;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtPassword.Text); 
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail Sent", "Success", MessageBoxButtons.OK);
                txtSubject.Text = null;
                txtTo.Text = null;
                rtbBody.Text = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in sendEmail:" + ex.Message);
            }
        }
    }
}
