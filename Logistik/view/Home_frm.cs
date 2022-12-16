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
    public partial class Home_frm : Form
    {
        public Home_frm()
        {
            InitializeComponent();
        }

        //private void juruToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form1 jurusan = new Form1();
         //   jurusan.ShowDialog();
        //}

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_frm login = new Login_frm();
            login.Show();
            this.Close();
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void juruToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barang_frm barang = new barang_frm();
            barang.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel7.Controls.Count == 0)
            {
                barang_frm barang = new barang_frm();
                barang.TopLevel = false;
                panel7.Controls.Add(barang);
                barang.ShowDialog();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel7.Controls.Count == 0)
            {
                MahasiswaFrm kirim = new MahasiswaFrm();
                kirim.TopLevel = false;
                panel7.Controls.Add(kirim);
                kirim.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_frm login = new Login_frm();
            login.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel7.Controls.Count == 0)
            {
                data_frm data = new data_frm();
                data.TopLevel = false;
                panel7.Controls.Add(data);
                data.ShowDialog();
            }
        }

        //private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           // MahasiswaFrm mahasiswa = new MahasiswaFrm();
          //  mahasiswa.ShowDialog();
       // }

    }
}
