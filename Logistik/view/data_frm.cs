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
    public partial class data_frm : Form
    {
        model.DataCls data = new model.DataCls();
        public data_frm()
        {
            InitializeComponent();
        }
       
        void bersihkan()
        {
            id_client.Text = data.buatKode();
            nama.Text = "";
            alamat.Text = "";
            no_telp.Text = "";
        }
        void tampilData()
        {
            if (nama.Text.Trim() == "")
            {
                dataGridView1.DataSource = data.tampilSemua();
            }
            else
            {
                dataGridView1.DataSource = data.tampilSemuaa(nama.Text);
            }

            belangBelang(dataGridView1);

        }
        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cek_btn_Click(object sender, EventArgs e)
        {
            if (data.cekId(id_client.Text))
            {
                MessageBox.Show("Data sudah ada.");
            }
            else
            {
                MessageBox.Show("Data belum ada.");
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!data.cekId(id_client.Text))
            {
                data.Id_Client = id_client.Text;
                data.Nama = nama.Text;
                data.Alamat = alamat.Text;
                data.No_Telp = no_telp.Text;
                data.simpanData();

                MessageBox.Show("Data berhasil disimpan");
                bersihkan();
                id_client.Focus();
                tampilData();
            }            
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (data.cekId(id_client.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dirubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    data.Id_Client = id_client.Text;
                    data.Nama = nama.Text;
                    data.No_Telp = no_telp.Text;
                    data.ubahData(id_client.Text);

                    MessageBox.Show("Data berhasil diubah");
                    bersihkan();
                    id_client.Focus();
                    tampilData();
                }
            }

            
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (data.cekId(id_client.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    data.hapusData(id_client.Text);

                    MessageBox.Show("Data berhasil dihapus");
                    bersihkan();
                    id_client.Focus();
                    tampilData();
                }
            }
        }

        private void barang_frm_Load(object sender, EventArgs e)
        {
            tampilData();
            bersihkan();
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            belangBelang(dataGridView1);
        }
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dataGridView1.Rows[e.RowIndex];

            id_client.Text = baris.Cells["cid"].Value.ToString();
            nama.Text = baris.Cells[1].Value.ToString();
            alamat.Text = baris.Cells[2].Value.ToString();
            no_telp.Text = baris.Cells[3].Value.ToString();
        }

        private void harga_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
