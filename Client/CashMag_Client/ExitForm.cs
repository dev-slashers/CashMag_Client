using System;
using System.Windows.Forms;

namespace CashMag_Client
{
    public partial class Uscita : Form
    {
        public Uscita()
        {
            InitializeComponent();
        }


        lib.Manager manager = new lib.Manager();
        Database.Engine Engineering = new Database.Engine();



        private void Exit()
        {
            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                string pass = Engineering.return_rows("SELECT UserPass FROM sys where id = '1';", 0);
                if (pass == manager.EnryptString(textBox1.Text))
                {
                    lib.Taskbar.Show();
                    Application.Exit();
                }
                else
                {
                    MessageForm frm = new MessageForm("Password Errata !");
                    frm.ShowDialog();
                    textBox1.Text = String.Empty;
                }
            }else
            {
                MessageForm Error = new MessageForm("Applicativo non connesso");
            }

        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] Arr = { Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 };
            foreach(Keys k in Arr)
            {
                if (e.KeyCode == k)
                {
                    textBox1.Text += k.ToString().Replace("NumPad", String.Empty);
                }else
                {
                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.Enter) Exit();
            //if (e.KeyCode == Keys.Escape && Force_Exit == true) Application.Exit();
        }
    }
}


