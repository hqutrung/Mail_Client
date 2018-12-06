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
        string show = "";
        bool ok;
        string Email = FormDN.Info.email;
        string Password = FormDN.Info.password;
        Attachment attach = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Send(string from, string to, string subject, string message, Attachment file = null)
        {
            
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
                

            }
            
        }
        private void btnSend_Click(object sender, EventArgs e)
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
                    Send(Email, email, txtSubject.Text, rtbBody.Text, attach);
                    if (!ok)
                    {
                        
                        
                            show += ("\n Thư gửi cho địa chỉ gmail " + email +" không thành công do địa chỉ gmail không có thực.");
                        
                    }
                    
                }
                sr.Close();
                if (show == "")
                    MessageBox.Show("đã gửi thành công.");
                else
                    MessageBox.Show(show);
            
           
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

        private void Close(object sender, FormClosedEventArgs e)
        {
            FormDN f = new FormDN();
            f.Show();
        }
    }
}
