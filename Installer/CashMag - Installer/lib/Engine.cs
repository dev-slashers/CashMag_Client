using System;
using System.IO;
using System.Diagnostics;


namespace CashMag___Installer.lib
{
    class Engine
    {
        // Restituisce true se è presente una determinata stringa in un file
        public Boolean Controlla_TextFile(string Path, string Str)
        {
            try
            {
                using (StreamReader myini = new StreamReader(Path))
                {
                    int count;
                    string linea;
                    while ((linea = myini.ReadLine()) != null)
                    {
                        count = linea.IndexOf(Str);
                        if (count != -1)
                        {
                            return true;

                        }
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        
        public void Hidden_ExecuteConsole(String Path,String Argument)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = Path;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.Arguments = Argument;
            cmd.Start();
        }

        public void Open_TCP_Port(String Port)
        {
            string TCP = "firewall add portopening TCP " + Port + " \"MySql TCP CashMag\"";
            string UDP = "firewall add portopening UDP " + Port + " \"MySql UDP CashMag\"";
            String Path = Environment.ExpandEnvironmentVariables("%windir%\\System32") + "\\netsh.exe";

            //System.Diagnostics.Process.Start(Path, TCP).Start();
            //System.Diagnostics.Process.Start(Path, UDP).Start();

            Hidden_ExecuteConsole(Path, TCP);
            Hidden_ExecuteConsole(Path, UDP);
        }


        // Restituisce Il percorso del file my.ini
        public String Get_Myini()
        {
            String Dir = String.Empty;
            String MySql_Dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MySQL\";
            String[] FilePath = Directory.GetDirectories(MySql_Dir);
            foreach (String d in FilePath)
            {
                if (d.IndexOf("MySQL Server") != -1)
                {
                    Dir = d;
                    break;
                }
            }
            return Dir + @"\my.ini";
        }

        //Aggiunge collegamento al desktop
        public void CreateShortUrl(string linkName, string app)
        {
            String[] DirToCopy =
            {
                // Desktop Directory
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                // StartUp Menu Directory
                Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu)
            };

            foreach (String Dir in DirToCopy)
            {
                using (StreamWriter writer = new StreamWriter(Dir + "\\" + linkName + ".url"))
                {
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon);
                    writer.Flush();
                }
            }
        }

        // Aggiungere programma all'avvio
        public void Add_Startup(String Name, String Path)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\");
            key.SetValue(Name, Path);
            key.Close();
        }
    }
}
