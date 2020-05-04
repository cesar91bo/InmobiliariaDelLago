using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DataAcces
{
    public class UserDao: ConexionSql
    {
        public bool Login(string user, string pass)
        {
            var contrasena = HashearPassword(pass);
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.CommandText = "select * from Usuarios where NombreUser = @user and PassUser = @contrasena";                  
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static byte[] HashearPassword(string password) { return SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(password)); }
    }
}
