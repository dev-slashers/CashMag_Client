using System;

namespace CashMag_Client.Database
{
    class Config
    {
        
        private static lib.Manager Manager = new lib.Manager();
        public static string Setting_ini = Environment.ExpandEnvironmentVariables(@"%AppData%\cashmag.ini");
        private static lib.InIManager Dati = new lib.InIManager(Setting_ini);

        public static int Quantita_Max = 100;
        private static string IP = Dati.Read("IP", "Network");
        private static string Port = Dati.Read("Port", "Network");
        private static string Database = Dati.Read("Name", "Database");
        private static string User = Dati.Read("Username", "Database");
        private static string Password = Manager.DecryptString(Dati.Read("Password", "Database"));

        public static string Host = "Server=" + IP + ";Database=" + Database + ";User Id=" + User + ";Password=" + Password + ";Port=" + Port + ";";
    }
}
