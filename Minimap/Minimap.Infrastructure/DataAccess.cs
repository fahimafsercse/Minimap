using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
//using System.Data;

namespace Minimap.Infrastructure
{
    public static class DataAccess
    {
        static SqlConnection conn;

        static public SqlConnection Connection
        {
            get
            {
                conn = new SqlConnection(Minimap.Infrastructure.Properties.Settings.Default.minimapConnectionString);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }

    }
}