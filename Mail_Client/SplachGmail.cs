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
    public partial class SplachGmail : Form
    {
        public SplachGmail()
        {
            InitializeComponent();
        }
        int n = 1;
        private void SplachGmail_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n==7)
            {
                timer1.Stop();
                this.Hide();
                new SignEmail(null).Show();
            }
            n++;
        }
    }
}
