using System;

namespace CashMag___Installer
{
    class Config
    {
        private static lib.Hash Crypt = new lib.Hash();
        public  static string Setting_ini = Environment.ExpandEnvironmentVariables(@"%AppData%\cashmag.ini");
        public static string  MySQL_Installer = Environment.ExpandEnvironmentVariables(@"%AppData%\cashmag\mysql.msi");
        private static lib.Manager Dati = new lib.Manager(Setting_ini);

        
        public static string Hostname       = Dati.Read("IP", "Network");
        public static string Port           = Dati.Read("Port", "Network");
        public static string Database       = Dati.Read("Name", "Database");
        public static string User           = Dati.Read("Username", "Database");
        public static string Password       = Crypt.DecryptString(Dati.Read("Password", "Database"));
        public static string Server         = "http://cashmag.altervista.org/get.php?token=";
        public static string Connect_Host   = "Server=" + Hostname + ";Database=" + Database + ";User Id=" + User + ";Password=" + Password + ";Port=" + Port + ";";
    }
}
