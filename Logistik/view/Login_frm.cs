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
    using model;
    public partial class Login_frm : Form
    {
        pengguna user = new pengguna();
        public Login_frm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar dari sistem?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user.cekLogin(user_txt.Text, pwd_txt.Text))
            {

                Home_frm home = new Home_frm();
                home.Show();
                this.Hide();
           } 
            else
            {
                MessageBox.Show("User belum terdaftar");
            }
        }

        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
