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
        bool ok;
        
        public FormDN()
        {
            InitializeComponent();
        }
        public class Info
        {
            static public string email;
            static public string password;
        }
        void mail()
        {
             ok = true;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(txtEmail.Text);
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Verification";
                mail.Body = "LOGIN";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtPassword.Text);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                Info.email = txtEmail.Text;
                Info.password = txtPassword.Text;
                
            }

            catch (Exception e)
            {
                ok = false;
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác! Vui Lòng Nhập Lại!");
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                
            }
            if(ok ==true)
            {
                MainForm frm = new MainForm(this);
                frm.Show();
                this.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSave.Checked == true)
            {
                Properties.Settings.Default.Username = txtEmail.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
                mail();
            }

            else 
            {
                
                mail();

                txtEmail.Clear();
                txtPassword.Clear();
            }

            

        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmail.ForeColor = Color.FromArgb(45, 45, 45);
        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.FromArgb(45, 45, 45);
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
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text=="Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
           if(txtPassword.Text=="")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        
    }
}
