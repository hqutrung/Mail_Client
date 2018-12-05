using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Client
{
    public partial class FormDN : Form
    {
        public FormDN()
        {
            InitializeComponent();
        }

        void mail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("quangkhang20899@gmail.com");
                mail.To.Add("quangkhang20899@gmail.com");
                mail.Subject = "Verification";
                mail.Body = "LOGIN";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }

            catch (Exception e)
            {
                MessageBox.Show("You have entered an invalid username or password");
            }
        }
        private void Send( )
        {
            bool ok;
            try
            {
                ok = true;
                string from = textBox1.Text;
                string to = "quangkhang20899@gmail.com";
                string subject = "Verification";
                string message = "Login";
                MailMessage mess = new MailMessage(from, to, subject, message);
                
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(textBox1.Text, textBox2.Text);
                client.Send(mess);
               
            }
            catch (Exception e)
            {
                ok = false;
                MessageBox.Show("You have entered an invalid username or password");
               
            }
           if(ok==true)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }


        }
        private void FormDN_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.un == "" && Properties.Settings.Default.pass == "")
            {
                textBox1.Text = "username";
                textBox2.Text = "password";
            }
            else
            {
                textBox1.Text = Properties.Settings.Default.un;
                textBox2.Text = Properties.Settings.Default.pass;
                textBox2.PasswordChar = '*';
            }
        }

        

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.un = textBox1.Text;
                Properties.Settings.Default.pass = textBox2.Text;
                Properties.Settings.Default.Save();

                Send();
            }

            else if (checkBox1.Checked == false)
            {
                Send();
            }

            else if (textBox1.Text == Properties.Settings.Default.un && textBox2.Text == Properties.Settings.Default.pass)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }

        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.FromArgb(45, 45, 45);
        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            textBox2.ForeColor = Color.FromArgb(45, 45, 45);
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            FormDN f = new FormDN();
            f.Show();

        }
    }
}
