using System;
using System.Windows.Forms;

namespace CashMag_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Loading load_form = new Loading();
        lib.Manager manager = new lib.Manager();
        String ID_Ordinazione = String.Empty;
        String Costo_Prodotto = String.Empty;
        Database.Engine db_engine = new Database.Engine();

      
       
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Uscita exit = new Uscita();
            exit.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lib.Taskbar.Hide();
            manager.KillProcess();
            this.TopMost = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_Ordinazione.IndexOf('|') != -1 && Costo_Prodotto.IndexOf('|') != -1)
                {
                    SendOrder send = new SendOrder(ID_Ordinazione, Costo_Prodotto);
                    send.TopMost = true;
                    send.ShowDialog();
                    if (send.Sender) { ID_Ordinazione = string.Empty; Costo_Prodotto = String.Empty; }
                }
                else
                {
                    MessageForm msg = new MessageForm("Elenco Vuoto");
                    msg.ShowDialog();
                }
            }catch
            {
                MessageForm msg = new MessageForm("Errore: Controlla la connessione internet");
                msg.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageForm msg = new MessageForm("Reset Completo");
            ID_Ordinazione = string.Empty; Costo_Prodotto = String.Empty;
            msg.ShowDialog();
        }

        private void SortBox_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; }

        private void NewOrder_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Result = SortBox.Text != "" ? "Where Categoria = '" + SortBox.Text + "';" : ";";
            if (SortBox.Text == "Tutto")
            {
                db_engine.load_menu(ref ListMenu, "select * from prodotti");
            }else
            {
                
                db_engine.load_menu(ref ListMenu, "SELECT * FROM prodotti " + Result);
            }
        }

        private void NewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Query = NewOrder.Text == "Si" ? " ORDER BY ID DESC;" : ";";
            db_engine.load_menu(ref ListMenu, "SELECT * FROM prodotti " + Query);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageForm Shutdown = new MessageForm("Spegnere la macchina?");
            Shutdown.ShowDialog();
        }

        private void ListMenu_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count != 0)
            {
                CheckOrder check = new CheckOrder(ListMenu.SelectedItems[0].SubItems[2].Text, ListMenu.SelectedItems[0].SubItems[1].Text.Split('€')[0]);
                check.ShowDialog();
                ID_Ordinazione += check.ID_Order;
                Costo_Prodotto += check.Costo_Prodotto;
            }
        }

        private void Load_main_Tick(object sender, EventArgs e)
        {
            load_form.Show();
            if (db_engine.Check_Connection())
            {
                db_engine.load_menu(ref ListMenu);
                db_engine.load_category(ref SortBox);
                load_form.Close();
                this.Opacity = 100;
                Load_main.Enabled = false;
                CheckInternetConnection.Enabled = true;
            }
        }

        private void check_notify_Tick(object sender, EventArgs e)
        {
            if (db_engine.return_rows("select * from sys where id= '1'",3) == "True")
            {
                db_engine.Execute("update sys set Campanello = 'False' where id = '1';");
                manager.Notifica_Ordinazione();
            }
        }

        private void check_new_items_Tick(object sender, EventArgs e)
        {
            if(db_engine.return_rows("select Insert_Items from sys where id = '1';",0) == "True")
            {
                db_engine.load_menu(ref ListMenu);
                db_engine.load_category(ref SortBox);
                db_engine.Execute("update sys set Insert_Items = 'False' where id = '1';");
            }
        }

        private void CheckInternetConnection_Tick(object sender, EventArgs e)
        {
            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                toolStripMenuItem5.Image = Properties.Resources.connect;
                SortBox.Enabled = true;
                NewOrder.Enabled = true;
                check_notify.Enabled = true;
                check_new_items.Enabled = true;
                toolStripMenuItem1.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                toolStripMenuItem3.Enabled = true;
            }
            else
            {
                toolStripMenuItem5.Image = Properties.Resources.disconnec;
                SortBox.Enabled = false;
                NewOrder.Enabled = false;
                check_notify.Enabled = false;
                check_new_items.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem3.Enabled = false;
            }
        }


    }
}
