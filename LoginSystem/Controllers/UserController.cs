using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginSystem.Models;
using LoginSystem.Database;

namespace LoginSystem.Controllers
{
    class UserController
    {
        public bool isAuthenticated;
        private SqlCommand Querry = new SqlCommand();

        public bool autenticate(string username, string Password)
        {
            Connection connection = new Connection();

            using (SqlConnection Sql = new SqlConnection(connection.getConnectionString("loginsystem")))
            {
                Querry.CommandText = ($"select * from Users where username = '{username}' and password = '{Password}'");

                try
                {
                    Querry.Connection = connection.startConnection(Sql);
                    SqlDataReader existUser = Querry.ExecuteReader();
                    if (existUser.HasRows)
                    {
                        return isAuthenticated = true;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }

            }

            return isAuthenticated;
        }
    }
}
