using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using logistik.config;
using System.Data;

namespace logistik.model
{
    using config;
    internal class DataCls
    {
         ServiceDb dbserver;
        string Query = "";
        DataTable temp;

        private string _id_client;
        private string _nama;
        private string _alamat;
        private string _no_telp;

        public DataCls()
        {
            dbserver = new ServiceDb();
            temp = new DataTable();
           

            _id_client = "";
            _nama = "";
            _alamat= "";
            _no_telp= "";
        
        }

        public string Id_Client
        {
            set { _id_client = value; }
            //get {return _kode_jurusan;}
        }
        public string Nama
        {
            set { _nama = value; }
        }
        public string Alamat
        {
            set { _alamat = value; }
        }
        public string No_Telp
        {
            set { _no_telp = value; }
        }
        public bool cekId(string id)
        {
            bool cek = false;
            Query = "select *from data where id_client='" + id + "'";
            temp = dbserver.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;

    }
        public void simpanData()
        {
            Query = "insert into data values ('" + _id_client + "','" + _nama + "','" + _alamat + "','" + _no_telp + "')";

            if (!(dbserver.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }
        public void ubahData(string kd)
        {
            Query = "update data set nama='" + _nama + "',alamat='" + _alamat + "',no_telp='" + _no_telp + "'" +
                 " where id_client='" + kd + "'";
            if (!(dbserver.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses ubah data gagal.");
            }
        }
        public void hapusData(string kd)
        {
            Query = "delete from data where id_client='" + kd + "'";

            if (!(dbserver.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus");
            }
        }
        public DataTable tampilSemua()
        {
            Query = "select* from data";

            return dbserver.eksekusiQuery(Query);
        }
        public DataTable tampilSemuaa(string nama)
        {
            Query = "select * from data where " + "nama like '%" + nama + "%'";

            return dbserver.eksekusiQuery(Query);
        }
        public string ambilKodeJurusanbyNama(string nama)
        {
            string kd = "";
            Query = "select id_client from data where nama='" + nama + "'";
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
            Query = "SELECT IFNULL(max(id_client),0)+1 AS kode from data"; //tanda + pd query berarti spasi 
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
            Query = "select nama from data where id_client='" + kode + "'";
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
