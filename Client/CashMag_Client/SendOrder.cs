using System;
using System.Windows.Forms;

namespace CashMag_Client
{
    public partial class SendOrder : Form
    {
        String ID_Ordinazione = null;
        String Costo_Prodotto = null;
        public SendOrder(String ID, String Prezzo)
        {
            ID_Ordinazione = ID;
            Costo_Prodotto = Prezzo;
            InitializeComponent();
        }
        public Boolean Sender { get; set; }
        Database.Engine db_engine = new Database.Engine();
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageForm msg = new MessageForm("Ordine inviato !");
            String Coperto = Coperto_Menu.Text == "Si" ? "1" : "0";
            if( db_engine.Execute("INSERT INTO Ordinazioni (ID_Ordinazione,Tavolo,Coperto,Totale,Stato) VALUES ('" + ID_Ordinazione + "','" + TavList.Text + "','" + Coperto + "','" + Costo_Prodotto + "','True');"))
            {
                Sender = true;
                msg.ShowDialog();
                this.Close();
            }
            else
            {
                MessageForm msg_error = new MessageForm("Errore Invio");
                msg_error.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TavList_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; }
        private void Coperto_Menu_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; }

        private void SendOrder_Load(object sender, EventArgs e)
        {
            try
            {
                int Numero_Tav = Int32.Parse(db_engine.return_rows("select * from sys where id='1';", 2));
                for (int i = 1; i <= Numero_Tav; i++)
                {
                    TavList.Items.Add("Tavolo " + i.ToString());
                }
            }catch
            {
                MessageForm errormsg = new MessageForm("Errore: Controlla la connessione internet");
            }
        }
    }
}
