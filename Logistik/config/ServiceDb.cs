using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace logistik.config
{
    internal class ServiceDb : KonfigDb
    {
        MySqlConnection sqlcon;
        MySqlCommand sqlcom;
        MySqlDataAdapter sqldta;

        string lokasi = "server = localhost;port=3306;database=logistik;" +
                         "uid=root;pwd=";

        public ServiceDb() 
        {
            sqlcon = new MySqlConnection(lokasi);
            sqlcom = new MySqlCommand();
            sqldta = new MySqlDataAdapter();
        }

        private void bukaKoneksi()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                try
                {
                    sqlcon.Open();
                }  catch (Exception ex) { }
            }
        }

        private void tutupKoneksi()
        {
            sqlcon.Close();
        }


     

        public override int  eksekusiNonQuery(string query)
{
    int nilaiKembali = -1;
    try
    {
        bukaKoneksi();
        sqlcom.Connection = sqlcon;
        sqlcom.CommandText = query;
        nilaiKembali = sqlcom.ExecuteNonQuery();
    }
    catch (Exception ex) { }
    finally
    {
        tutupKoneksi();
    }
    return nilaiKembali;
}
        public override DataTable  eksekusiQuery(string query)
{
    DataTable nilaiKembali = new DataTable();
    try
    {
        bukaKoneksi();
        sqlcom.Connection = sqlcon;
        sqlcom.CommandText = query;
        sqldta.SelectCommand = sqlcom;
        sqldta.Fill(nilaiKembali);
    }
    catch (Exception ex) { }
    finally
    {
        tutupKoneksi();
    }
    return nilaiKembali;
}
    }
}
