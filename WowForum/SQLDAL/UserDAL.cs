using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WowForum.Models;
using System.Web.Configuration;
using WowForum.Models.LoginModels;
using WowForum.Models.APIReturnModels;

namespace WowForum.SQLDAL
{
    public class UserDAL : IUserDAL
    {
        string databaseConnectionString = WebConfigurationManager.ConnectionStrings["wowsiteConnection"].ConnectionString;


        public void CreateUserNoChar(NewUserModel newUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateNoChar", conn);
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
        public void CreateUserWithChar(NewUserModel newUser, CharacterInfoAPIModel characterInfo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateWithChar", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", newUser.Username);
                    cmd.Parameters.AddWithValue("@password", newUser.Password);
                    cmd.Parameters.AddWithValue("@email", newUser.Email);
                    cmd.Parameters.AddWithValue("@email", characterInfo.gender);
                    cmd.Parameters.AddWithValue("@email", characterInfo.faction);
                    cmd.Parameters.AddWithValue("@email", characterInfo.Class);
                    cmd.Parameters.AddWithValue("@email", characterInfo.race);


                    var result = cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public StoredUser GetUser(string username, string password)
        {
            StoredUser user = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(databaseConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateNoChar", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    var result = cmd.ExecuteReader();

                    while (result.Read())
                    {
                        user = new StoredUser
                        {
                            UserName = Convert.ToString(result["UserName"]),
                            Password = Convert.ToString(result["Password"]),
                            Email = Convert.ToString(result["Email"]),
                            Gender = Convert.ToString(result["Gender"]),
                            Faction = Convert.ToString(result["Faction"]),
                            Class = Convert.ToString(result["Class"]),
                            Race = Convert.ToString(result["Race"])
                        };
                    }

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return user;
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