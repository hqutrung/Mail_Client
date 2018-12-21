
﻿using System;
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
        Form FormLogin;
        bool ok;
        Attachment attach = null;


        string pass,email;
        MailMessage mail = new MailMessage();
        SmtpClient stm = new SmtpClient("smtp.gmail.com", 587);
        public MainForm(string email,string pass)
        {
            InitializeComponent();
            this.pass = pass;
            this.email = email;
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
                client.Credentials = new NetworkCredential(email, pass);
                client.Send(mess);
            } catch (Exception e)
            {
                ok = false;
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMailList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTo.Text = dialog.FileName;
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
            Send(email, txtTo.Text, txtSubject.Text, rtbBody.Text, attach);
            if(ok)
            {
                MessageBox.Show("Mail is sent!", "Success");
            }
            else MessageBox.Show("Error!", "Error");

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new SignEmail(email).Show();
            this.Hide();
        }
        Boolean flag; int x, y;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
