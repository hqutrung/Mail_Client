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
    public partial class SignPassword : Form
    {
        public SignPassword()
        {
            InitializeComponent();
        }

        private void txt(object sender, EventArgs e)
        {

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            txt_password.isPassword = true;
        }
    }
}
