using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WowForum.Models;
using System.Web.Configuration;

namespace WowForum.SQLDAL
{
    public class UserDAL : IUserDAL
    {
        string databaseConnectionString = WebConfigurationManager.ConnectionStrings["wowsiteConnection"].ConnectionString;


        public void CreateUser(NewUserModel newUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("StoredProcname", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", newUser.Username);
                    cmd.Parameters.AddWithValue("@password", newUser.Password);
                    cmd.Parameters.AddWithValue("@email", newUser.Email);


                    var result = cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

//try
//{
//    string sql = $"insert into wowsite.dbo.UserInformation(Username, Password, Email) values (@username, @password, @email);";
//    using (SqlConnection conn = new SqlConnection(databaseConnectionString))
//    {
//        conn.Open();
//        SqlCommand cmd = new SqlCommand(sql, conn);
//        cmd.Parameters.AddWithValue("@username", newUser.Username);
//        cmd.Parameters.AddWithValue("@password", newUser.Password);
//        cmd.Parameters.AddWithValue("@email", newUser.Email);


//        int result = (int)cmd.ExecuteNonQuery();

//        return result;
//    }
//}