using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WowForum.Models;

namespace WowForum.SQLDAL
{
    public class UserDAL
    {
        string databaseConnectionString = @"Data Source=PCPALOOZA-MKII\SQLEXPRESS;Initial Catalog = wowsite; Integrated Security = True";


        public int CreateUser(NewUserModel newUser)
        {
            try
            {
                string sql = $"insert into wowsite.dbo.UserInformation(Username, Password, Email) values (@username, @password, @email);";
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", newUser.Username);
                    cmd.Parameters.AddWithValue("@password", newUser.Password);
                    cmd.Parameters.AddWithValue("@email", newUser.Email);


                    int result = (int)cmd.ExecuteNonQuery();

                    return result;
                }
            }
            catch (SqlException ex)
            {
                // logger.Error($"Error creating user w un/pw {newUser.Username}, {newUser.Password}", ex);
                throw;
            }
        }
    }
}