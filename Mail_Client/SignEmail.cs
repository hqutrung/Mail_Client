using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Client
{
    public partial class SignEmail : Form
    {
        public SignEmail()
        {
            InitializeComponent();
        }

        private void SignEmail_Load(object sender, EventArgs e)
        {
            lbl_email.Visible = false;

        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            lbl_email.Visible = true;
        }
    }
}
