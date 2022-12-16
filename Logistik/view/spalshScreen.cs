using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace logistik.view
{
    public partial class spalshScreen : Form
    {
        int waktu = 0;
        public spalshScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waktu == 3)
            {
                Login_frm login = new Login_frm();
                login.Show();
                this.Hide();
            }
            waktu++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
