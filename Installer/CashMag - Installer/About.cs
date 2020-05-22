using System;
using System.Net;
using System.Windows.Forms;

namespace CashMag___Installer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        lib.Hash hash = new lib.Hash();

        private void About_Load(object sender, EventArgs e)
        {
            label2.Text = "Versione:  " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            UtenteLab.Text = String.Empty;
            download_link.Text = String.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/salvatore-turboli-78b29015b/");
        }


        private void CheckLicenza_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                WebClient client = new WebClient();
                String json_output = client.DownloadString(Config.Server + hash.MD5Hash(CheckLicenza.Text));
                String Download = Config.Server.Replace("get.php?token=", "download.php?id=") + hash.json_read(json_output, "Download_Key");

                UtenteLab.Text = "Utente:  " + hash.json_read(json_output, "Email");
                download_link.Text = Download;
            }
        }

        private void CheckLicenza_Click(object sender, EventArgs e)
        {
            if (CheckLicenza.Text == "Inserisci licenza") CheckLicenza.Text = string.Empty;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://cashmag.altervista.org");
        }
    }
}
