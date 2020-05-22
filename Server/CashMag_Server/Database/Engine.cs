using System;
using MySql.Data.MySqlClient;

namespace CashMag_Server.Database
{
    class Engine
    {
        public bool Execute(String Query)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Config.Host);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string return_rows(String Query,int index)
        {
            String Rows = String.Empty;
            MySqlConnection Conn = new MySqlConnection(Config.Host);
            try
            { 
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                Conn.Open();
                MySqlDataReader read = Command.ExecuteReader();
                while(read.Read())
                {
                    Rows = read.GetString(index);
                }
                
            }catch
            {
                Rows = null;
            }finally
            {
                Conn.Close();
            }
            return Rows;
        }

        public Boolean Check_Connection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Config.Host);
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
