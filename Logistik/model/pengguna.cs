using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace logistik.model
{
    using config;
    internal class pengguna
    {
        layananDb dbServer;
        DataTable temp;
        string Query = "";

        private string _uid;
        private string _pwd;
        private string _level;
        private string _nama_pengguna;

        public pengguna()
        {
            _uid = "";
            _pwd = "";
            _level = "";
            _nama_pengguna = "";

            dbServer = new layananDb();
            temp = new DataTable();
        }

        public string UID
        {
            set { _uid = value; }
        }
        public string PWD
        {
            set { _pwd = value; }
        }
        public string Level
        {
            set { _level = value; }
        }
        public string Nama_Pengguna
        {
            set { _nama_pengguna = value; }
        }

        public bool cekLogin(string uid, string pwd)
        {
            bool cek = false;
            Query = "select * from pengguna where username='" +
                uid + "' and password='" + pwd + "'";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public string tampilNamabyUid(string uid, string pwd)
        {
            string nama = "";

            Query = "select * from pengguna where " +
                "username='" + uid + "'and password='" +
                pwd + "'";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nama = data[3].ToString();
                }
            }

            return nama;
        }

        public string tampilLevelByUid(string uid, string pwd)
        {
            string level = "";
            Query = "select * from pengguna where " + "username='" + uid + "' and password='" + pwd + "'";
            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    level = data[2].ToString();
                }
            }
            return level;
        }
    }
}
