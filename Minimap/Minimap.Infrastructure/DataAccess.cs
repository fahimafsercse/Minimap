using Minimap.Core.Entities;
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
        static SqlConnection conn =new  SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Dropbox\AtpProject\Minimap\Minimap\Database\Minimap.mdf;Integrated Security=True;Connect Timeout=30");

        static public SqlConnection Connection
        {
            get
            {
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

    /*
     * public class DataAccess
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Dropbox\AtpProject\Minimap\Minimap\Database\Minimap.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand cmd;

        public DataAccess()
        {
            connection.Open();
        }

        public void Add(AccountDetail accountDetail)
        {
            cmd = new SqlCommand("iNSERT INTO [AccountDetail] Values(@UserName, @Firstname, @Lastname, @Email, @Gender, @Usertype,@Joindate,@Totalmarker,@Totalchannel,@TotalSubscription,@Mobile)", connection);
            cmd.Parameters.AddWithValue("@UserName", accountDetail.Username);
            cmd.Parameters.AddWithValue("@Firstname", accountDetail.FirstName);
            cmd.Parameters.AddWithValue("@Lastname", accountDetail.LastName);
            cmd.Parameters.AddWithValue("@Email", accountDetail.Email);
            cmd.Parameters.AddWithValue("@Gender", accountDetail.Gender);
            cmd.Parameters.AddWithValue("@Usertype", accountDetail.UserTypeId);
            cmd.Parameters.AddWithValue("@Joindate", accountDetail.JoinDate);
            cmd.Parameters.AddWithValue("@TotalSubscription", accountDetail.TotalSubscription);
            cmd.Parameters.AddWithValue("@Totalchannel", accountDetail.TotalChaneel);
            cmd.Parameters.AddWithValue("@Totalmarker", accountDetail.TotalMarker);
            cmd.Parameters.AddWithValue("@Mobile", accountDetail.MobileNo);
            cmd.ExecuteNonQuery();
        }
    }*/








}

