using System;
using System.Windows.Forms;

namespace CashMag_Server
{
    public partial class Registra_Programma : Form
    {
        public Registra_Programma()
        {
            InitializeComponent();
        }

        lib.Licenza Software = new lib.Licenza();
        lib.InIManager Manager = new lib.InIManager(Database.Config.Setting_ini);
        String Eseguibile = System.Reflection.Assembly.GetEntryAssembly().Location;

        private void Licenza_Text_Click(object sender, EventArgs e)
        {
            if (Licenza_Text.Text == "Inserire Licenza") Licenza_Text.Text = String.Empty;
        }

        private void Registra()
        {
            if (Software.Controllo_Licenza(Licenza_Text.Text))
            {
                Manager.Write("Licenza", Licenza_Text.Text, "Software");
                Software.Create_RegistryKey("Licenza", Software.MD5Hash(Licenza_Text.Text));
                System.Diagnostics.Process.Start(Eseguibile);
                Application.Exit();
            }
        }
        private void Licenza_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Registra();
            }
        }

        private void Registra_Programma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Registra_Programma_Load(object sender, EventArgs e)
        {
            Licenza_Text.Text = Database.Config.Licenza;
            if (Database.Config.Licenza.IndexOf('-') == 4) Registra();
        }

        private void SiteLinkLab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://cashmag.altervista.org");
        }
    }
}
