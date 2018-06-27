using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using Facs.Modelli;

namespace Facs
{

    public class facUsers
    {
        public static string cnnStr = "Server=tcp:prjwork.database.windows.net,1433;Initial Catalog=ProjectWorkHotel;Persist Security Info=False;User ID=yourfather;Password=PRJwork1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static Users UserExists(string username, string password)
        {
            Users usr = new Users();

            SqlConnection conn = new SqlConnection(cnnStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username = @Username AND password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    usr.ID = Guid.Parse(result[0].ToString());
                    usr.Role = int.Parse(result[6].ToString());
                    usr.CheckedOut = bool.Parse(result[5].ToString());
                }

            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return usr;
        }
    }

        public static UtenteGuest GetCamera(string Username, string Password)
        {
            UtenteGuest res = new UtenteGuest();
            object floorId = null;
            SqlConnection conn = new SqlConnection(cnnStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Camera From Users WHERE username = @username AND password = @password"
                                                , conn);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    res.Stanza = int.Parse(result[0].ToString());
                }

                SqlCommand cmd2 = new SqlCommand("SELECT ID_Piano,Temeperatura,Porta from Rooms Where ID = @RoomId", conn);
                cmd2.Parameters.AddWithValue("@RoomId", res.Stanza);
                result.Close();
                SqlDataReader result2 = cmd2.ExecuteReader();
                while (result2.Read())
                {
                    floorId = result2[0];
                    res.Temperatura = decimal.Parse(result2[1].ToString());
                    res.StatoPorta = bool.Parse(result2[2].ToString());

                }
                SqlCommand cmd3 = new SqlCommand("  SELECT Piano from Floors Where ID = @FloorId", conn);
                cmd3.Parameters.AddWithValue("@FloorId", floorId);
                result2.Close();
                SqlDataReader result3 = cmd3.ExecuteReader();
                while (result3.Read())
                {
                    res.Piano = int.Parse(result3[0].ToString());
                }
                result3.Close();

            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public static void SetPortaCamera(UtenteGuest utente)
        {
            SqlConnection conn = new SqlConnection(cnnStr);

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Rooms SET Porta = @stato WHERE ID = @roomID", conn);
                cmd.Parameters.AddWithValue("@stato", utente.StatoPorta);
                cmd.Parameters.AddWithValue("@roomID", utente.Stanza);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch 
            {

                return;
            }

        }

        public static void SetTemperatura(UtenteGuest utente)
        {
            SqlConnection conn = new SqlConnection(cnnStr);

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Rooms SET Temeperatura = @temp WHERE ID = @roomID", conn);
                cmd.Parameters.AddWithValue("@temp", utente.Temperatura);
                cmd.Parameters.AddWithValue("@roomID", utente.Stanza);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {

                return;
            }
        }
    }
}
