using System;
using System.Net;
using System.Linq;
using System.Management;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;


namespace CashMag___Installer
{
    class NetWorking
    {

        /*****************************NETWORK***********************/
        public string GetLocalIPAddress()
        {
            String host = "127.0.01";
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    host = addr.ToString();
                }
            }
            return host;
        }

        public string GetGatewayAddress()
        {
            String Gateway = "0.0.0.0";
            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        if (d.Address.ToString().Split('.').Length != 4) continue;
                        Gateway = d.Address.ToString();
                    }
                }
            }

            return Gateway;
        }


        public Boolean setGateway(string gateway)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setGateway;
                        ManagementBaseObject newGateway =
                            objMO.GetMethodParameters("SetGateways");

                        newGateway["DefaultIPGateway"] = new string[] { gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                        return true;
                    }
                    
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean setIP(string ip_address)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP =
                            objMO.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { ip_address };
                        newIP["SubnetMask"] = new string[] { "255.255.255.0" };
                        setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }

            }
            return true;
        }


        private NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

            return Nic;
        }

        public void SetDNS(String Predefinito, String Alternativo)
        {
            string[] Dns = { Predefinito, Alternativo};
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }


        public void UnsetDNS()
        {
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }




        public bool Check_Port(String IP, int Port)
        {
            TcpClient TcpScan = new TcpClient();
            if (!TcpScan.ConnectAsync(IP, Port).Wait(800))
            {
                return false;
            }else
            {
                return true;
            }
        }


        public bool create_schema(string schema_query,string host)
        {
            String Connection = string.Empty;
            foreach (string s in host.Split(';'))
            {
                if (s.IndexOf("Database") != -1) continue;
                Connection += ";" + s;
            }
            MySqlConnection conn = new MySqlConnection(Connection.Substring(1));
            try
            {
                MySqlCommand cmd = new MySqlCommand(schema_query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                
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

        public bool Execute(String Query,String host)
        {
            MySqlConnection conn = new MySqlConnection(host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();  
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


        public bool Restore(String Host,String Attivita)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Host))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            if(Attivita == "Bar")
                            {
                                mb.ImportFromString(Properties.Resources.Bar);
                            }
                            else if(Attivita == "Pub")
                            {
                                mb.ImportFromString(Properties.Resources.Pub);
                            }
                            else if(Attivita == "Void")
                            {
                                mb.ImportFromString(Properties.Resources.VOID_DB);
                            }
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

        public string install(String Password)
        {
            return
            "CREATE TABLE Ordinazioni (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, ID_Ordinazione TEXT NOT NULL, Tavolo TEXT NOT NULL, Coperto TEXT NOT NULL, Totale TEXT NOT NULL, Stato  TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Prodotti (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, Nome TEXT NOT NULL,Prezzo TEXT NOT NULL, Categoria TEXT NOT NULL,Disponibile TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Categoria (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, Nome TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Sys (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, UserPass TEXT NOT NULL,Numero_Tavoli INT NOT NULL,Campanello TEXT NOT NULL,Costo_Coperto TEXT NOT NULL,Insert_Items TEXT NOT NULL,FormSize TEXT NOT NULL,PRIMARY KEY (ID));" +
            "CREATE TABLE Storico (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, TimeData TEXT NOT NULL, Ordinazione TEXT NOT NULL, Totale TEXT NOT NULL, PRIMARY KEY (ID));" +
            "CREATE TABLE Scontrino (ID INT UNSIGNED AUTO_INCREMENT NOT NULL, Attivita TEXT NOT NULL, Indirizzo TEXT NOT NULL, Piva TEXT NOT NULL, Tel TEXT NOT NULL, Footer TEXT NOT NULL ,PRIMARY KEY (ID));" +
            "INSERT INTO Scontrino (Attivita,Indirizzo,Piva,Tel,Footer) VALUES ('< Nome Attività >','< Indirizzo >','< Piva >','< Telefono >','Grazie Per Averci Scelto');" +
            "INSERT INTO Sys (UserPass,Numero_Tavoli,Campanello, Costo_Coperto,Insert_Items,FormSize) VALUES ('MTIzNA==','50','False','2,00','False','False');" + //Default pass 1234 (Base64)
            "CREATE USER 'root'@'%' IDENTIFIED BY '"+Password+"';" +
            "GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' WITH GRANT OPTION;" +
            "FLUSH PRIVILEGES;";
        }
    }
}
