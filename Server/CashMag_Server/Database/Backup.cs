using System;
using MySql.Data.MySqlClient;

namespace CashMag_Server.Database
{
    class Backup
    {
        public bool Save(String Path)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Config.Host))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(Path);
                            conn.Close();
                        }
                    }
                }
                return true;
            }catch
            {
                return false;
            }
        }

        public bool Restore(String Path)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Config.Host))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(Path);
                            conn.Close();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
