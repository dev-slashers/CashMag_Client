using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace CashMag___Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string InstallPath = Environment.ExpandEnvironmentVariables("%windir%").ToLower().Replace("windows", "cashmag");

        lib.Hash Base64         =   new lib.Hash();
        lib.Engine Engineering  =   new lib.Engine();
        NetWorking networking   =   new NetWorking();
        lib.Manager Man         =   new lib.Manager(Config.Setting_ini);
        String MySqlData        =   InstallPath + @"\MySql.Data.dll";
        String MySqlBackup      =   InstallPath + @"\MySqlBackup.dll";
        String Ribbon           =   InstallPath + @"\System.Windows.Forms.Ribbon.dll";
        String Gestionale       =   InstallPath + @"\cashmag.exe";
    

        private void Form1_Load(object sender, EventArgs e)
        {
            IP_Text.Text = networking.GetLocalIPAddress();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            String New_IP = string.Empty;
            Submit_btn.Enabled = false;
            groupBox4.Enabled = false;
            Find_Server();
        }


        private void Create_Setting()
        {
            if (host_txt.Text != null && Port_txt.Text != null && Database_txt.Text != null && Username_txt.Text != null && Password_txt.Text != null)
            {
                Man.Write("IP", host_txt.Text, "Network");
                Man.Write("Port", Port_txt.Text, "Network");
                Man.Write("Name", Database_txt.Text, "Database");
                Man.Write("Username", Username_txt.Text, "Database");
                Man.Write("Password", Base64.EncryptString(Password_txt.Text), "Database");
            }
            else
            {
                MessageBox.Show("Controllare tutti i campi", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Make()
        {
            // Crea Directory installazione software
            if (!Directory.Exists(InstallPath)) Directory.CreateDirectory(InstallPath);

            //Esporto MySql.Data.dll
            if (!File.Exists(MySqlData)) File.WriteAllBytes(MySqlData, Properties.Resources.MySql_Data);

            //Esporto MySqlBackup.dll
            if (radioButton1.Checked && !File.Exists(MySqlBackup)) File.WriteAllBytes(MySqlBackup, Properties.Resources.MySqlBackup);

            //Esporto System.Windows.Forms.Ribbon.dll
            if (radioButton1.Checked && !File.Exists(Ribbon)) File.WriteAllBytes(Ribbon, Properties.Resources.System_Windows_Forms_Ribbon);
 
            //Esporto il gestionale Server
            if (!File.Exists(Gestionale) && radioButton1.Checked) File.WriteAllBytes(Gestionale, Properties.Resources.CashMag_Server);

            //Esporto il gestiona e Client
            if (!File.Exists(Gestionale) && radioButton2.Checked) File.WriteAllBytes(Gestionale, Properties.Resources.CashMag_Client);


            //Aggiungo Collegamento al Desktop
            Engineering.CreateShortUrl("CashMag", Gestionale);

            // Creo il file setting
            Create_Setting();
        }

        private void Install()
        {
            StatusBar.Value = 0;
            Submit_btn.Enabled = false;
            String Attivita = String.Empty;
            String Gateway = networking.GetGatewayAddress();
            //String Attivita = BarRadioButton.Checked ? "Bar" : "Pub";
            
            if (BarRadioButton.Checked)  { Attivita = "Bar";  }
            if (PubRadioButton.Checked)  { Attivita = "Pub";  }
            if (VoidradioButton.Checked) { Attivita = "Void"; }

            String Host = "Server=" + host_txt.Text + ";Database=" + Database_txt.Text + ";User Id=" + Username_txt.Text + ";Password=" + Password_txt.Text + ";Port=" + Port_txt.Text + ";";

            Thread Install_Server = new Thread(() => {
                //Creo il Database
                if (!networking.create_schema("create schema " + Database_txt.Text + ";", Host)) Console.WriteLine("Errore Creazione Schema");
                StatusBar.Value = 10;

                // Inserisco le query
                if (!networking.Execute(networking.install(Password_txt.Text), Host)) Console.WriteLine("Errore Creazione user");
                StatusBar.Value = 20;

                //Setto IP
                if (!networking.setIP(IP_Text.Text)) Console.WriteLine("Errore Settaggio IP");
                StatusBar.Value = 30;

                //Setto Gateway
                if (!networking.setGateway(Gateway)) Console.WriteLine("Errore Settaggio GateWay");
                StatusBar.Value = 40;

                //Setto DNS di Google
                networking.SetDNS("8.8.8.8", "8.8.4.4");
                StatusBar.Value = 50;

                //genera file setting.ini
                Create_Setting();
                StatusBar.Value = 60;

                //Open Firewall Port
                Engineering.Open_TCP_Port(Port_txt.Text);
                StatusBar.Value = 70;

                //Aggiungo Programma All'avvio
                if (StartupCheckBox.Checked == true) Engineering.Add_Startup("cashmag", Gestionale);
                StatusBar.Value = 80;

                //Aggiungo Stringa al file my.ini
                if (File.Exists(Engineering.Get_Myini()) && Engineering.Controlla_TextFile(Engineering.Get_Myini(), "bind-address = 0.0.0.0"))
                {
                    using (StreamWriter sw = File.AppendText(Engineering.Get_Myini()))
                    {
                        sw.WriteLine("bind-address = 0.0.0.0");
                    }
                }

                //Esporto i file di installazione, Librerie,Client/Server e Setting.ini
                Make();
                StatusBar.Value = 90;

                //Ripristino il Database //Da errore Caricamento dll
                if (!networking.Restore(Host, Attivita)) Console.WriteLine("Errore Restore Database");
                StatusBar.Value = 100;
                Submit_btn.Enabled = true;
            });


            if (radioButton2.Checked)
            {
                Make();
                StatusBar.Value = 100;
                Submit_btn.Enabled = true;
            }
            else if (radioButton1.Checked)
            {
                Install_Server.Start();
            }
        }
        
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Install();
            }else
            {
                MessageBox.Show("Applicativo non connesso alla rete", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Port_txt_KeyDown(object sender, KeyEventArgs e) {e.SuppressKeyPress = true;}


        private void Find_Server()
        {
            Thread Find = new Thread(() => {
                String IP = String.Empty;
                String IP_Mask = String.Empty;

                for (int i = 0; i < networking.GetLocalIPAddress().Split('.').Length - 1; i++) IP_Mask += networking.GetLocalIPAddress().Split('.')[i] + ".";

                for (int i = 1; i < 254; i++)
                {
                    IP = IP_Mask + i;
                    if (networking.Check_Port(IP, 3300))
                    {
                        host_txt.Text = IP;
                        break;
                    }
                }
                Submit_btn.Enabled = true;
            });
            Find.Start();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Submit_btn.Enabled == false) e.Cancel = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            host_txt.Text = "localhost";
        }

        

        private void opzioniAvanzateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Me = this;
            if (!opzioniAvanzateToolStripMenuItem.Checked)
            {
                Me.Width = 918;
                opzioniAvanzateToolStripMenuItem.Checked = true;
            }else
            {
                Me.Width = 338;
                opzioniAvanzateToolStripMenuItem.Checked = false;
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Submit_btn.Enabled == true)
            {
                Application.Exit();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About info = new About();
            info.ShowDialog();
        }

        private void accountUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("netplwiz");
        }


        private void modificaMyiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(Engineering.Get_Myini())) System.Diagnostics.Process.Start(Engineering.Get_Myini());
        }

        private void mySQLInstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(Config.MySQL_Installer))
            {
                System.Diagnostics.Process.Start(Config.MySQL_Installer);
                this.WindowState = FormWindowState.Minimized;
            }else
            {
                MessageBox.Show("Installer non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

