using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace logistik.config
{
    internal class layananDb : KonfigDb
    {
        MySqlConnection sqlCon;
        MySqlCommand sqlCom;
        MySqlDataAdapter sqlDta;

        String server = "server=localhost;port=3306;database=logistik;" +
            "uid=root;pwd=";
        public layananDb()
        {
            sqlCon = new MySqlConnection(server);
            sqlCom = new MySqlCommand();
            sqlDta = new MySqlDataAdapter();
        }
        void bukaKoneksi()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                try
                {
                    sqlCon.Open();
                }
                catch (Exception e) { }
            }
        }
        void tutupKoneksi()
        {
            sqlCon.Close();
        }
        public override int eksekusiNonQuery(string query)
        {
            int nilaiKembalian = -1;
            try
            {
                bukaKoneksi();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                nilaiKembalian = sqlCom.ExecuteNonQuery();
            }
            catch (Exception e) { }

            finally
            {
                tutupKoneksi();
            }
            return nilaiKembalian;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable nilaiKembalian = new DataTable();
            try
            {
                bukaKoneksi();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                sqlDta.SelectCommand = sqlCom;

                sqlDta.Fill(nilaiKembalian);
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }
            return nilaiKembalian;
        }
    }
}
