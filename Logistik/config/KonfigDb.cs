using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace logistik.config
{
    abstract class KonfigDb
    {
        //untuk menangani instruksi insert, update, delete
        public abstract int eksekusiNonQuery(string query);

        //untuk menanganii instruksi select
        public abstract DataTable eksekusiQuery(string query);


        public KonfigDb()
        {
            // TODO: Complete member initialization
        }
    }
}
