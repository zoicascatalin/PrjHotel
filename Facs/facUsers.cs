using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace Facs
{

    public class facUsers
    {
        public static string cnnStr = "Server=tcp:prjwork.database.windows.net,1433;Initial Catalog=ProjectWorkHotel;Persist Security Info=False;User ID=*****;Password=******;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        public static bool UserExists(string username, string password)
        {
            bool existingUser = false;



            SqlConnection conn = new SqlConnection(cnnStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username = @Username AND password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var result = cmd.ExecuteReader();
                if (result.HasRows)
                {
                    existingUser = true;
                }
                
            }
            catch
            {
                return existingUser;
            }
            finally
            {
                conn.Close();
            }
            return existingUser;
        }
    }
}
