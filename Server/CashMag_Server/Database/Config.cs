using System;

namespace CashMag_Server.Database
{
    class Config
    {
        public static string Setting_ini = Environment.ExpandEnvironmentVariables(@"%AppData%\cashmag.ini");
        private static lib.Manager Manager = new lib.Manager();
        private static lib.InIManager Dati = new lib.InIManager(Setting_ini);

        public  static int       Numero_Max_Tavoli                      = 150;   
        private static string    IP                                     = Dati.Read("IP", "Network");
        private static string    Port                                   = Dati.Read("Port", "Network");
        private static string    Database                               = Dati.Read("Name", "Database");
        private static string    User                                   = Dati.Read("Username", "Database");
        public  static string    UserInfo                               = "?workstation=" + Environment.MachineName + "&pcuser=" + Environment.UserName;
        public  static string    Server_Token                           = "http://cashmag.altervista.org/get.php" + UserInfo + "&token=";
        public  static string    Password                               = Manager.DecryptString(Dati.Read("Password", "Database"));
        public  static string    Licenza                                = Dati.Read("Licenza", "Software");
        public  static string    Host                                   = "Server=" + IP + ";Database=" + Database + ";User Id=" + User + ";Password=" + Password + ";Port=" + Port + ";";

        
        public static string install_db =
            "CREATE TABLE Ordinazioni (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, ID_Ordinazione TEXT NOT NULL, Tavolo TEXT NOT NULL, Coperto TEXT NOT NULL, Totale TEXT NOT NULL, Stato  TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Prodotti (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, Nome TEXT NOT NULL,Prezzo TEXT NOT NULL, Categoria TEXT NOT NULL,Disponibile TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Categoria (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, Nome TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Sys (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, UserPass TEXT NOT NULL,Numero_Tavoli INT NOT NULL,Campanello TEXT NOT NULL,Costo_Coperto TEXT NOT NULL,Insert_Items TEXT NOT NULL,FormSize TEXT NOT NULL,PRIMARY KEY (ID));" +
            "CREATE TABLE Storico (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, TimeData TEXT NOT NULL, Ordinazione TEXT NOT NULL, Totale TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Scontrino (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, Attivita TEXT NOT NULL, Indirizzo TEXT NOT NULL, Piva TEXT NOT NULL, Tel TEXT NOT NULL, Footer TEXT NOT NULL ,PRIMARY KEY (ID));" +
            "INSERT INTO Scontrino (Attivita,Indirizzo,Piva,Tel,Footer) VALUES ('< Nome Attività >','< Indirizzo >','< Piva >','< Telefono >','Grazie Per Averci Scelto');" +
            "INSERT INTO Sys (UserPass,Numero_Tavoli,Campanello, Costo_Coperto,Insert_Items,FormSize) VALUES ('MTIzNA==','50','False','2,00','False','False');" + //Default pass 1234 (Base64)
            "CREATE USER 'root'@'%' IDENTIFIED BY '" + Password + "';" +
            "GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' WITH GRANT OPTION;" +
            "FLUSH PRIVILEGES;";
    }
}

