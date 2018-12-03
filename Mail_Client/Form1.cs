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
        Attachment attach = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Send(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(txtEmail.Text, txtPassword.Text);
            client.Send(mess);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(txtFile.Text);
                    attach = new Attachment(txtFile.Text);
                }
                catch { }
                StreamReader sr = new StreamReader(txtTo.Text);
                string email;

                while ((email = sr.ReadLine()) != null)
                {
                    Send(txtEmail.Text, email, txtSubject.Text, rtbBody.Text, attach);
                }
                sr.Close();
            }
              );
            thread.Start();
        }


        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }
        private void btnMailList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTo.Text = dialog.FileName;
            }
        }

    }
}
