using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial_guia7.Properties;
using System.Configuration;

namespace parcial_guia7.DAL
{
    public  class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }

    }
}
