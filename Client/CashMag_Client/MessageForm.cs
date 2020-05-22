using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMag_Client
{
    public partial class MessageForm : Form
    {
        String Msg = null;
        public MessageForm(String TextHere)
        {
            Msg = TextHere;
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            label1.Text = Msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Spegnere la macchina?") System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
