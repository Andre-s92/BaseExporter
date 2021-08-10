using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseExporter.Data
{
    class Connection
    {
    }
    public static class data_conecction
    {
        static SqlConnection conn = null;
        public static SqlConnection GetSqlConnection()
        {
            if (conn == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
                conn = new SqlConnection(connectionString);


            }
            return conn;
        }
    }
}
