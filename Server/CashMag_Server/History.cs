using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CashMag_Server
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        lib.Manager Manager = new lib.Manager();
        Database.Engine Engine = new Database.Engine();

        private void load_product(string query = "select * from storico;")
        {
            int ID = 0;
            Storico_Lista.Items.Clear();
            MySqlConnection Conn = new MySqlConnection(Database.Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                Conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Storico_Lista.Items.Add(read.GetString(1));
                    Storico_Lista.Items[ID].SubItems.Add(read.GetString(2).Replace("|", ",").Substring(1,(read.GetString(2).Length - 1)));
                    Storico_Lista.Items[ID].SubItems.Add(read.GetString(3));
                    Storico_Lista.Items[ID].SubItems.Add(read.GetString(0));
                    ID += 1;
                }
            }
            catch { }
            finally
            {
                Conn.Close();
            }

        }

        private float get_sum()
        {
            float Sum = 0.00f;
            for (int i = 0; i < Storico_Lista.Items.Count; i++)
            {
                Sum += float.Parse(Storico_Lista.Items[i].SubItems[2].Text.Split('€')[1]);
            }
            return Sum;
        }

        private void load()
        {
            String Data = DateTime.Now.ToString("dd/MM/yyyy");
            load_product();
            Riepilogo_Text.Text = Data + " | Totale Incasso:" + String.Format("{0:c}", get_sum());
        }


        private void History_Load(object sender, EventArgs e)
        {
            load();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Storico_Lista.SelectedItems.Count != 0)
            {
                string ID = Storico_Lista.SelectedItems[0].SubItems[3].Text;
                Engine.Execute("delete from storico where id = '"+ID+"';");
                load();
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "Cerca...") txt_search.Text = String.Empty;
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                load_product("select * from storico where TimeData like '%"+txt_search.Text+"%';");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private String Format_Text(String Str, int MaxLenght)
        {
            String Text = Str.Replace(",Coperto", String.Empty);
            if(Text.Length > MaxLenght)
            {
                return Text.Substring(0, MaxLenght) + "...";
            }else
            {
                return Text;
            }
        }
        private void PrintHistory_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            int leading = 1; 
            int leftMargin = 25;
            int topMargin = 20;
            

            StringFormat FmtCenter  =   new StringFormat()      { Alignment = StringAlignment.Near};

            Font Intestazione = new Font("Arial Narrow", 15f, FontStyle.Bold);

            using (Font font = new Font("Arial Narrow", 12f))
            {
                int Pad = 30;
                int MaxLenght = 50;
                int Footer = 0;
                String Prodotto = String.Empty;
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + leading;
                String Riga = "Data".PadRight(30) + "Costo".PadRight(20) + "Descrizione";
                e.Graphics.DrawString(Riga, Intestazione, Brushes.Black, leftMargin,10, FmtCenter);
                for (int i = 0; i < Storico_Lista.Items.Count; i++)
                {
                    Prodotto = Format_Text(Storico_Lista.Items[i].SubItems[1].Text.ToString(), MaxLenght);
                    Riga = Storico_Lista.Items[i].Text.ToString().PadRight(Pad) + Storico_Lista.Items[i].SubItems[2].Text.ToString().PadRight(Pad) + Prodotto ;
                    e.Graphics.DrawString(Riga, font, Brushes.Black, leftMargin, topMargin + h * i, FmtCenter);
                    Footer = i;
                }

                e.Graphics.DrawString(Riepilogo_Text.Text.Split('|')[1], Intestazione, Brushes.Black, leftMargin, topMargin + h * (Footer + 2), FmtCenter);

            }

        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintHistory.Print();
        }

        private void eliminaStoricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Manager.CheckFormOpen("Impostazioni Amministratore"))
            {
                Login_Password login = new Login_Password();
                login.ShowDialog();
            }
        }
    }
}
