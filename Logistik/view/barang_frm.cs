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
    public partial class barang_frm : Form
    {
        model.BarangCls barang = new model.BarangCls();
        public barang_frm()
        {
            InitializeComponent();
        }
       
        void bersihkan()
        {
            id_brg.Text = barang.buatKode();
            nama_brg.Text = "";
            harga.Text = "";
            stok.Text = "";
        }
        void tampilData()
        {
            if (nama_brg.Text.Trim() == "")
            {
                dataGridView1.DataSource = barang.tampilSemua();
            }
            else
            {
                dataGridView1.DataSource = barang.tampilSemuaa(nama_brg.Text);
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
            if (barang.cekId(id_brg.Text))
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
            if (!barang.cekId(id_brg.Text))
            {
                barang.Id_Barang = id_brg.Text;
                barang.Nama_Barang = nama_brg.Text;
                barang.Harga = harga.Text;
                barang.Stok = stok.Text;
                barang.simpanData();

                MessageBox.Show("Data berhasil disimpan");
                bersihkan();
                id_brg.Focus();
                tampilData();
            }            
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (barang.cekId(id_brg.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dirubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    barang.Nama_Barang = nama_brg.Text;
                    barang.Harga = harga.Text;
                    barang.Stok = stok.Text;
                    barang.ubahData(id_brg.Text);

                    MessageBox.Show("Data berhasil diubah");
                    bersihkan();
                    id_brg.Focus();
                    tampilData();
                }
            }

            
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (barang.cekId(id_brg.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    barang.hapusData(id_brg.Text);

                    MessageBox.Show("Data berhasil dihapus");
                    bersihkan();
                    id_brg.Focus();
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

            id_brg.Text = baris.Cells["cid"].Value.ToString();
            nama_brg.Text = baris.Cells[1].Value.ToString();
            harga.Text = baris.Cells[2].Value.ToString();
            stok.Text = baris.Cells[3].Value.ToString();
        }
        
    }
}
