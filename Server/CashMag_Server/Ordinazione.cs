using System;
using System.Drawing;
using System.Windows.Forms;

namespace CashMag_Server
{
    public partial class Ordinazione : Form
    {
        String ID;
        ListView Lista;
        Button Tavolo_Button;
        Label Cassa;

        lib.Manager Manager = new lib.Manager();
        Database.Engine Engineering = new Database.Engine();

        public Ordinazione(ref Button Tavolo, ref ListView Lista,ref Label Cassa,String ID)
        {
            this.ID = ID;
            Tavolo_Button = Tavolo;
            this.Lista = Lista;
            this.Cassa = Cassa;
            InitializeComponent();
        }


        private float get_sum()
        {
            float Sum = 0.00f;
            try
            {
                for (int i = 0; i < ListSum.Items.Count; i++)
                {
                    Sum += float.Parse(ListSum.Items[i].SubItems[1].Text.Split('€')[0]);
                }
            }catch
            {
                Sum = 0;
            }
            return Sum;
        }

        private String Get_Product()
        {
            String Prodotti = String.Empty;
            for(int i = 0; i < ListSum.Items.Count; i++)
            {
                Prodotti += "|" +ListSum.Items[i].Text;
            }
            return Prodotti;
        }

        private void Ordinazione_Load(object sender, EventArgs e)
        {
            int Count_ID = 0;
            String Prodotto = String.Empty;
            String Prezzo = String.Empty;
            string Prodotti = Engineering.return_rows("select * from ordinazioni where id = '" + ID + "';", 1);

            foreach(string txt_id in Prodotti.Split('|'))
            {
                if(Count_ID >= 1)
                {
                    Prodotto = Engineering.return_rows("select Nome from prodotti where id = '" + txt_id + "';", 0);
                    Prezzo   = Engineering.return_rows("select Prezzo from prodotti where id = '" + txt_id + "';", 0) + "€";
                    if(Prodotto.Length >= 3 && Prezzo.Length >= 1)
                    {
                        ListSum.Items.Add(Prodotto);
                        ListSum.Items[Count_ID - 1].SubItems.Add(Prezzo);
                    }
                }
                Count_ID++;
            }

            if (Engineering.return_rows("select coperto from ordinazioni where id = '" + ID + "';", 0) == "1")
            {
                ListSum.Items.Add("Coperto");
                ListSum.Items[ListSum.Items.Count - 1].SubItems.Add(Engineering.return_rows("select Costo_Coperto from sys where id ='1';", 0) + "€");
            }
      

            GrupTavolo.Text = Tavolo_Button.Text;
            Lab_Sum.Text = "Totale Ordine: " + String.Format("{0:c}", get_sum());

        }

        private void Chiudi_Ordinazione_Click(object sender, EventArgs e)
        {
            String Data = DateTime.Now.ToString("dd/MM/yyyy h:mm");
            DialogResult msg = MessageBox.Show("Sicuro di voler liberare il tavolo?","Chiusura Tavolo",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if(msg == DialogResult.Yes)
            {
                Cassa.Text = Tavolo_Button.Text;
                Engineering.Execute("insert into storico (TimeData, Ordinazione, Totale) values ('"+Data+"','"+Get_Product()+"','"+ String.Format("{0:c}", get_sum()) + "');");
                Tavolo_Button.Name = string.Empty;
                Tavolo_Button.Text = "Vuoto";
                Tavolo_Button.BackColor = Color.Transparent;
                Manager.Migrate_list(ref ListSum, ref Lista);   
                this.Close();
            }else if (msg == DialogResult.No)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
