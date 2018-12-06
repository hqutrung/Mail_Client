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
    public partial class MainForm : Form
    {
        string Email = FormDN.Info.email;
        string Password = FormDN.Info.password;
        Attachment attach = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Send(string from, string to, string subject, string message, Attachment file = null)
        {
            bool ok;
            try
            {
                ok = true;
                MailMessage mess = new MailMessage(from, to, subject, message);
                if (attach != null)
                {
                    mess.Attachments.Add(attach);
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(Email, Password);
                client.Send(mess);
            } catch (Exception e)
            {
                ok = false;
                MessageBox.Show("unsucessfully sent because:"+"\n" + e.ToString());

            }
            if (ok == true)
            {
                MessageBox.Show("Thư Đã Được Gửi!");
            }
           
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
                 attach = null;
                 if (txtTo == null)
                 {
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
                         Send(Email, email, txtSubject.Text, rtbBody.Text, attach);
                     }
                     sr.Close();
                 }
                 else Send(Email, txtTo.Text, txtSubject.Text, rtbBody.Text, attach);
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
