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

namespace Mail_Client
{
    public partial class Form1 : Form
    {
        static Form1 f;

        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(txtEmail.Text, txtRecipient.Text);
            message.Subject = txtSubject.Text;
            message.Body = txtBody.Text;

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(txtEmail.Text, txtPassword.Text);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }

            txtRecipient.Text = null;
            txtSubject.Text = null;
            txtBody = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartReceiving();
        }

        private void StartReceiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993, txtEmail.Text, txtPassword.Text, AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        MessageBox.Show("Sever does not support IMAP IDLE");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                    while (true) ;
                }
            });
        }
        static void OnNewMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New massage received!");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                f.rtxtReceive.AppendText("From: " + m.From + "\n" +
                                         "Subject: " + m.Subject + "\n" +
                                         "Body: " + m.Body + "\n");
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtAttachment.Text = openFileDialog1.FileName.ToString();
            }
        }
    }
}
