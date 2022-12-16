using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using logistik.config;
using System.Data;

namespace logistik.model
{
    using config;
    internal class BarangCls
    {
         ServiceDb dbserver;
        string Query = "";
        DataTable temp;

        private string _id_barang;
        private string _nama_barang;
        private string _harga;
        private string _stok;

        public BarangCls()
        {
            dbserver = new ServiceDb();
            temp = new DataTable();
           

            _id_barang = "";
            _nama_barang = "";
            _harga= "";
            _stok= "";
        
        }

        public string Id_Barang
        {
            set { _id_barang = value; }
            //get {return _kode_jurusan;}
        }
        public string Nama_Barang
        {
            set { _nama_barang = value; }
        }
        public string Harga
        {
            set { _harga = value; }
        }
        public string Stok
        {
            set { _stok = value; }
        }
        public bool cekId(string id)
        {
            bool cek = false;
            Query = "select *from barang where id_barang='" + id + "'";
            temp = dbserver.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;

    }
        public void simpanData()
        {
            Query = "insert into barang values ('" + _id_barang + "','" + _nama_barang + "','" + _harga + "','" + _stok + "')";

            if (!(dbserver.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }
        public void ubahData(string kd)
        {
            Query = "update barang set nama_barang='" + _nama_barang + "',harga='" + _harga + "',stok='" + _stok + "'" +
                 " where id_barang='" + kd + "'";
            if (!(dbserver.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses ubah data gagal.");
            }
        }
        public void hapusData(string kd)
        {
            Query = "delete from barang where id_barang='" + kd + "'";

            if (!(dbserver.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus");
            }
        }
        public DataTable tampilSemua()
        {
            Query = "select* from barang";

            return dbserver.eksekusiQuery(Query);
        }
        public DataTable tampilSemuaa(string nama)
        {
            Query = "select * from barang where " + "nama_barang like '%" + nama + "%'";

            return dbserver.eksekusiQuery(Query);
        }
        public string ambilKodeJurusanbyNama(string nama)
        {
            string kd = "";
            Query = "select id_barang from barang where nama_barang='" + nama + "'";
            temp = dbserver.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow dt in temp.Rows)
                {
                    kd = dt[0].ToString();
                }
            }
            return kd;
        }
        public string buatKode()
        {
            string kode = "";
            int indek = 0;
            Query = "SELECT IFNULL(max(id_barang),0)+1 AS kode from barang"; //tanda + pd query berarti spasi 
            temp = dbserver.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    indek = Convert.ToInt32(data[0]);
                }

                if (indek > 0 && indek < 10)
                {
                    kode = "0" + indek.ToString();
                }
                else if (indek >= 10 && indek < 100)
                {
                    kode = indek.ToString();
                }
            }
            return kode;
        }
        public string tampilNamaByKode(string kode)
        {
            string nama = "";
            Query = "select nama_barang from barang where id_barang='" + kode + "'";
            temp = dbserver.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nama = data[0].ToString();
                }
            }
            return nama;
        }

}
}
