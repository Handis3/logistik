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

    public partial class MahasiswaFrm : Form
    {
        MahasiswaCls mhs = new MahasiswaCls();
        public MahasiswaFrm()
        {
            InitializeComponent();
        }

        //method membersihkan tampilan
        void bersihkan()
        {
            nim_txt.Clear();
            nama_txt.Clear();
            laki_rdn.Checked = false;
            perempuan_rdn.Checked = false;
            alamat_txt.Clear();
            tgl_dtp.Text="";
            kode_cmb.Text="";
        }

        //mengisi data jurusan
       // void isiJurusan()
        //{
         //   DataTable data = new DataTable();
          //  data = jurusan.tampilSemua();

           // if (data.Rows.Count > 0)
           //{
             //  kode_cmb.Items.Clear();
             //   foreach (DataRow dt in data.Rows)
         //  {
                    
                //  kode_cmb.Items.Add(dt[1].ToString());
            //    }
         //  }

     //   }

        //method menampilkan data
        void tampilData()
        {
            
            if (carimhs_txt.Text.Trim()=="")
            {
                mahasiswa_GridView.DataSource = mhs.tampilSemuaGrid();
            }
            else
            {
                mahasiswa_GridView.DataSource = mhs.tampilSemuaGridd(carimhs_txt.Text);
            }
            belangBelang(mahasiswa_GridView);
            
        }

        //method belang-belang
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

        private void MahasiswaFrm_Load(object sender, EventArgs e)
        {
           // isiJurusan();
            tampilData();
            isiKode();

            
        }

        //button simpan
        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if(!mhs.cekKode(nim_txt.Text))
            {
                mhs.Id_pengiriman=nim_txt.Text;
                mhs.Nama_Barang=nama_txt.Text;
                if(laki_rdn.Checked==true)
                {
                    mhs.Status_Barang="ready";
                }
                else if(perempuan_rdn.Checked==true)
                {
                    mhs.Status_Barang="Empety";
                }
                mhs.Alamat=alamat_txt.Text;
                mhs.Tanggal_Pengiriman = ambilTanggal(tgl_dtp.Value);

               // mhs.Kode_Jurusan = jurusan.ambilKodeJurusanbyNama(kode_cmb.Text);
                mhs.simpan();

                MessageBox.Show("Tambah data berhasil.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihkan();
                tampilData();
                nim_txt.Focus();

            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
                if (mhs.cekKode(nim_txt.Text))
                {
                    if (MessageBox.Show("yakin akan diubah?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        mhs.Nama_Barang = nama_txt.Text;
                        if (laki_rdn.Checked == true)
                        {
                            mhs.Status_Barang = "Ready";
                        }
                        else if (perempuan_rdn.Checked == true)
                        {
                            mhs.Status_Barang = "Empety";
                        }
                        mhs.Alamat = alamat_txt.Text;
                        mhs.Tanggal_Pengiriman = ambilTanggal(tgl_dtp.Value);

                        //mhs.Kode_Barang = jurusan.ambilKodeJurusanbyNama(kode_cmb.Text);
                        mhs.ubah(nim_txt.Text);

                        MessageBox.Show("ubah data berhasil.", "ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilData();
                        nim_txt.Focus();
                    }

                }
            
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
                    if (MessageBox.Show("yakin akan dihapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    {
                        mhs.hapus(nim_txt.Text);

                        MessageBox.Show("hapus data berhasil.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        
                        nim_txt.Focus();
                    }

                }

        private void mahasiswa_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.mahasiswa_GridView.Rows[e.RowIndex];

            nim_txt.Text = baris.Cells[0].Value.ToString();
            nama_txt.Text = baris.Cells[1].Value.ToString();
            if(baris.Cells[2].Value.ToString()=="L")
            {
                laki_rdn.Checked=true;
            }
            else
            {
                perempuan_rdn.Checked=true;
            }
           
             alamat_txt.Text = baris.Cells[3].Value.ToString();
             tgl_dtp.Value = buatTanggal(baris.Cells[4].Value.ToString());
             kode_cmb.Text=baris.Cells[5].Value.ToString();

            
        }

        private void keluar_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            nim_txt.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void carimhs_txt_TextChanged(object sender, EventArgs e)
        {
            tampilData();
        }

        private void mahasiswa_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kode_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void isiKode()
        {
            kode_cmb.Items.Clear();
            kode_cmb.Items.Add("01");
            kode_cmb.Items.Add("02");
            kode_cmb.Items.Add("03");
            kode_cmb.Items.Add("04");
            kode_cmb.Items.Add("05");
        }

        string ambilTanggal(DateTime tgl)
        {
            string stgl = "";
            stgl = tgl.Year.ToString() + "/" + tgl.Month.ToString() + "/" + tgl.Day.ToString();

            return stgl;
        }

        DateTime buatTanggal(string tgl)
        {
            DateTime dtgl= new DateTime(Convert.ToInt32(tgl.Substring(6, 4)), Convert.ToInt32(tgl.Substring(3, 2)), Convert.ToInt32(tgl.Substring(0, 2)));

            return dtgl;
        }

        private void laki_rdn_CheckedChanged(object sender, EventArgs e)
        {

        }

        
       




            }
        }
    

