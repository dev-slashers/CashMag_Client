using System;
using System.Windows.Forms;

namespace CashMag_Client
{
    public partial class CheckOrder : Form
    {

        public string ID_Order { get; set; }
        public string Costo_Prodotto { get; set; }

        String Input_ID = null;
        String Input_Bezos = null;
        Database.Engine eng = new Database.Engine();
        public CheckOrder(String ID, String Prezzo)
        {
            Input_ID = ID;
            Input_Bezos = Prezzo;
            InitializeComponent();
        }

   
        private void CheckOrder_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            for (int i = 1; i <= Database.Config.Quantita_Max; i++)
            {
                QuantList.Items.Add(i.ToString());
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= Int32.Parse(QuantList.Text); i++)
            {
                ID_Order += "|" + Input_ID;
                Costo_Prodotto += "|" + Input_Bezos;
            }
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuantList_KeyDown(object sender, KeyEventArgs e) {e.SuppressKeyPress = true;}

        private void AddButton_Click(object sender, EventArgs e)
        {
            int Value = Int32.Parse(QuantList.Text);
            if(Value < Database.Config.Quantita_Max)
            {
                QuantList.Text = (Value+1).ToString();
            }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            int Value = Int32.Parse(QuantList.Text);
            if(Value > 1)
            {
                QuantList.Text = (Value-1).ToString();
            }
        }
    }
}
