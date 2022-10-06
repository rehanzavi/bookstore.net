using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WebApplication1.Models
{
    public class UserSqpImp : IUserRepository
    {
        SqlConnection conn;
        SqlCommand comm;

        public UserSqpImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString);
            comm = new SqlCommand();
        }
        public Users AddUser(Users user)
        {
            comm.CommandText = "insert into Users values( '" + user.Name + "', '" + user.Email + "', '" + user.Password + "', '" + user.Phone + "', '" +user.Address + "')";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public void DeleteUser(int id)
        {
            comm.CommandText = "Delete from Users where Id=" + id;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        public List<Users> GetAllUser()
        {
            List<Users> list = new List<Users>();
            comm.CommandText = "select * from Users";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string pwd = reader["Password"].ToString();
                string name = reader["Name"].ToString();
                string email = reader["Email"].ToString();
                int phone = Convert.ToInt32(reader["Phone"]);
                string address = reader["Address"].ToString();
                list.Add(new Users(id, name, pwd, email, phone, address));
            }
            conn.Close();
            return list; ;
        }

    }
}