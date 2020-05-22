using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace CashMag_Server
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        lib.Licenza licenza = new lib.Licenza();

        private string get_UserMail()
        {
            try
            {
                using (WebClient c = new WebClient())
                {
                    String json = c.DownloadString(Database.Config.Server_Token + licenza.MD5Hash(Database.Config.Licenza));
                    return licenza.json_read(json, "Email");
                }
            }catch
            {
                return "Connessione Assente";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/salvatore-turboli-78b29015b/");
        }

        private void About_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread load = new Thread(() => {
                Versione.Text = "Versione: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                UserRegister.Text = "Registrato a " + get_UserMail();
            });
            load.Start();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://cashmag.altervista.org");
        }
    }
}
