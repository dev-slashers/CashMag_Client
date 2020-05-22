using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CashMag_Client.Database
{
    class Engine
    {
        MessageForm msg_errore = new MessageForm("Errore Comunicazione Database");

        public void load_menu(ref ListView lts, String Query = "SELECT * FROM prodotti;")
        {
            MySqlConnection Connessione = new MySqlConnection(Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, Connessione);
                Connessione.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                int ID = 0; lts.Items.Clear();
                while (read.Read())
                {
                    if (read.GetString(4) == "No") continue;
                    lts.Items.Add(read.GetString(1));
                    lts.Items[ID].SubItems.Add(read.GetString(2) + "€");
                    lts.Items[ID].SubItems.Add(read.GetString(0));
                    ID += 1;
                }

            }
            catch
            {
                msg_errore.ShowDialog();
            }
            finally
            {
                Connessione.Close();
            }
        }

        public String return_rows(String Query, int index)
        {
            String Result = String.Empty;
            MySqlConnection Connessione = new MySqlConnection(Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, Connessione);
                Connessione.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while(read.Read())
                {
                    Result = read.GetString(index);
                }
            }catch
            {
                Result = null;
            }finally
            {
                Connessione.Close();
            }
            return Result;
        }



        public void load_category(ref ComboBox cmb, String Query = "SELECT * FROM categoria;")
        {
            MySqlConnection Connessione = new MySqlConnection(Database.Config.Host);
            cmb.Items.Clear();
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, Connessione);
                Connessione.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                int ID = 0;
                cmb.Items.Add("Tutto");
                while (read.Read())
                {
                    cmb.Items.Add(read.GetString(1));
                    ID += 1;
                }
               
            }catch
            {
                msg_errore.ShowDialog();
            }finally
            {
                Connessione.Close();
            }
        }


        public Boolean Check_Connection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Database.Config.Host);
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean Execute(string Query)
        {
            MySqlConnection conn = new MySqlConnection(Database.Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }finally
            {
                conn.Close();
            }
        }
    }
}
