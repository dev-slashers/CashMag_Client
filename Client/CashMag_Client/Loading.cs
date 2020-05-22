using System;
using System.Windows.Forms;

namespace CashMag_Client
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int count = 0;
        int MaxCount = Int32.Parse(DateTime.Now.ToString("MM"));

        private void Loading_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            if(!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageForm exit = new MessageForm("Dispositivo non connesso");
                exit.ShowDialog();
                lib.Taskbar.Show();                
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == MaxCount) Application.Exit();
        }
    }
}
