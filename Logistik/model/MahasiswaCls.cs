using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace logistik.model
{
    using config;
    class MahasiswaCls
    {
        private string _id_pengiriman;
        private string _nama_barang;
        private string _status_barang;
        private string _alamat;
        private string _tanggal_pengiriman;
        private string _kode_barang;

        private ServiceDb dbserver;
        private DataTable dtTable;
        private string Query;

        public MahasiswaCls()
        {
            _id_pengiriman= "";
            _nama_barang= "";
            _status_barang= "";
            _alamat= "";
            _tanggal_pengiriman= "";
            _kode_barang= "";

            dbserver = new ServiceDb();
            dtTable = new DataTable();
            Query = "";
        }

        public string Id_pengiriman 
        {
            set { _id_pengiriman= value;}
        }

        public string Nama_Barang 
        {
            set { _nama_barang = value;}
        }

        public string Status_Barang 
        {
            set { _status_barang = value;}
        }

        public string Alamat
        {
            set { _alamat = value;}
        }

        public string Tanggal_Pengiriman
        {
            set { _tanggal_pengiriman = value;}
        }

        public string Kode_Barang
        {
            set { _kode_barang = value;}
        }

        public bool cekKode (string nim)
        {
            bool cek = false;
            Query= "select * from pengiriman where id_pengiriman='" + _id_pengiriman + "'";
            dtTable=dbserver.eksekusiQuery(Query);

            if(dtTable.Rows.Count > 0)
            {
                cek = true;
            }
                return cek;           
        }

        //method simpan data
        public void simpan()
        {
            Query= "insert into pengiriman values ('" + _id_pengiriman + "','" + _nama_barang + "','" + _status_barang + "','" + _alamat + "','" + _tanggal_pengiriman + "','" + _kode_barang + "')";
            if(!(dbserver.eksekusiNonQuery(Query)> 0) )
            {
            
                throw new Exception("Data gagal simpan");
            }
        }
       
        //method ubah data
        public void ubah(string id_pengiriman)
        {
            Query= "update pengiriman set nama_barang='" + _nama_barang + "',status_barang='" + _status_barang + "',alamat='" + _alamat + "',tanggal_pengiriman='" + _tanggal_pengiriman + "',kode_barang='" + _kode_barang + "'"+
                 " where id_pengiriman='"+ _id_pengiriman +"'" ;
            if(!(dbserver.eksekusiNonQuery(Query)>0) )
            {
                throw new Exception("Proses ubah data gagal.");
            }
        }

        //method hapus data
        public void hapus(string id_pengiriman)
        {
            Query= "delete from pengiriman where id_pengiriman='" + _id_pengiriman + "'";
            if(!(dbserver.eksekusiNonQuery(Query)>0))
            {
                throw new Exception("Proses hapus data gagal.");
            }
        }

        //method tampilkan semua data
        public DataTable tampilSemua()
        {
            Query= "select * from pengiriman";

            return dbserver.eksekusiQuery(Query);
        }

        //utk menampilkan kode_jurusan=nama_jurusan
        public DataTable tampilSemuaGrid()
        {

            Query = "select from pengiriman where status_barang";

            return dbserver.eksekusiQuery(Query);
        }

        //untuk fungsi pencarian
        public DataTable tampilSemuaGridd(string nama)
        {
            Query = "select a.id_pengiriman,a.nama_barang,a.status_barang,a.alamat,a.tanggal_pengiriman,b.nama_barang" +
                " from pengiriman a,pengiriman b where a.kode_barang=b.kode_barang and " +
                "a.nama_barang like '%" + nama +"%'";

            return dbserver.eksekusiQuery(Query);
        }



        


    }
}
