using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CashMag_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Main MainForm = new Main();
        lib.Manager Manager = new lib.Manager();
        lib.Licenza Licenza = new lib.Licenza();
        Database.Engine db_engine = new Database.Engine();
        Registra_Programma Register_Form = new Registra_Programma();

        int X = 5; int Y = 20; Boolean Inizialize = true;

        


        public void load_tavolo(int max = 0)
        {
            int count = 1;
            while (Inizialize)
            {
                if (Y != 740)
                {
                    Button btn = new Button();
                    btn.Click += AzioneTasto;
                    btn.Width = 75;
                    btn.Height = 75;
                    btn.Text = "Vuoto";
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.BackgroundImageLayout = ImageLayout.Center;
                    GrupTavolo.Controls.Add(btn);
                    btn.Location = new Point(X, Y);
                    X += 100;
                    if (X >= 1150)
                    {
                        Y += 80;
                        X = 5;
                    }
                }
                else
                {
                    Inizialize = false;
                }
                if (max != 0)
                {
                    if (max <= count)
                    {
                        Inizialize = false;
                    }
                }
                count += 1;
            }
 
        }

        public void AzioneTasto(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name != string.Empty)
            {
                int Count_Items = Scontrino_Cassa.Items.Count;
                Ordinazione Order = new Ordinazione(ref btn, ref Scontrino_Cassa, ref LabCassa ,btn.Name.Split('_')[1]);
                btn.BackColor = Color.Yellow;
                Order.ShowDialog();
                if (Scontrino_Cassa.Items.Count != Count_Items) Somma_Cassa();
            }
        }



        private void check_new_order_Tick(object sender, EventArgs e)
        {
            int ID = 0;
            try
            {
                ID = Int32.Parse(db_engine.return_rows("select * from ordinazioni Where Stato = 'True';", 0));
            }
            catch
            {
                ID = 0;
            }
            if (db_engine.return_rows("select * from ordinazioni Where ID = '" + ID.ToString() + "';", 5) == "True")
            {
                foreach (Control btn in GrupTavolo.Controls)
                {
                    if (btn is Button)
                    {
                        if (btn.Name == string.Empty)
                        {
                            db_engine.Execute("update ordinazioni set Stato = 'False' Where ID = '" + ID.ToString() + "';");
                            btn.Text = db_engine.return_rows("select * from ordinazioni where id = '" + ID.ToString() + "'", 2);
                            btn.Name = "btn_" + ID.ToString();
                            btn.BackColor = Color.GreenYellow;
                            Manager.New_Order_Notify();
                            break;
                        }
                    }
                }
            }
        }



        private void Cassa_Display_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] Arr_key = { Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Add, Keys.Subtract, Keys.OemMinus, Keys.Divide, Keys.Multiply };
            foreach (Keys k in Arr_key)
            {
                if (e.KeyCode == k)
                {
                    Cassa_Display.Text += k.ToString().Replace("NumPad", String.Empty).Replace("Add", "+").Replace("Subtract", "-").Replace("Minus", "-").Replace("Divide", "/").Replace("Multiply", "*").Replace("Oem", "");
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.Enter) Cassa_Display.Text = Manager.Sum(Cassa_Display.Text).ToString();
            if (e.KeyCode == Keys.Cancel) Cassa_Display.Text = string.Empty;

        }

        private void load_main_Tick(object sender, EventArgs e)
        {
            MainForm.Show();
            if (db_engine.Check_Connection())
            {
                check_new_order.Enabled = true;
                load_main.Enabled = false;
                try
                {
                    load_tavolo(Int32.Parse(db_engine.return_rows("select * from sys where id = '1';", 2)));
                } catch
                {
                    load_tavolo(1);
                }

                this.Opacity = 100;
                this.ShowInTaskbar = true;
                this.TopMost = true;
                load_product();
                MainForm.Close();
                this.TopMost = false;
            }
            else
            {
                this.Opacity = 0;
                this.ShowInTaskbar = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            check_new_order.Enabled = false;
            foreach (Control btn in GrupTavolo.Controls)
            {
                if (btn is Button)
                {
                    if (btn.BackColor == Color.GreenYellow || btn.BackColor == Color.Yellow)
                    {
                        db_engine.Execute("update ordinazioni set Stato = 'True' where id = '" + btn.Name.Split('_')[1] + "';");
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Licenza.Load_Licenza())
            {
                load_main.Enabled = false;
                Register_Form.ShowDialog();
            } else
            {
                load_main.Enabled = true;
            }

            if (db_engine.return_rows("select FormSize from sys where id = '1';", 0) == "True")
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }


        private void load_product(string query = "select * from prodotti;")
        {
            int ID = 0;
            ProductList.Items.Clear();
            MySqlConnection Conn = new MySqlConnection(Database.Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                Conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    ProductList.Items.Add(read.GetString(1));
                    ProductList.Items[ID].SubItems.Add(read.GetString(2) + "€");
                    ID += 1;
                }
            }
            catch { }
            finally
            {
                Conn.Close();
            }

        }

        private void refreshDecrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_product("SELECT * FROM cashmag.prodotti order by id desc;");
        }

        private void Aggiungi_AllaCassa()
        {
            int count = Scontrino_Cassa.Items.Count;
            if (ProductList.SelectedItems.Count != 0)
            {
                Scontrino_Cassa.Items.Add(ProductList.SelectedItems[0].Text);
                Scontrino_Cassa.Items[count].SubItems.Add(ProductList.SelectedItems[0].SubItems[1].Text);
            }
            Somma_Cassa();
            LabCassa.Text = "Cassa";
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_product();
        }

        private void aggiungiAllaCassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aggiungi_AllaCassa();
        }

        private void ProductList_DoubleClick(object sender, EventArgs e)
        {
            Aggiungi_AllaCassa();
        }


        private void ripulisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cassa_Display.Text = "0";
            Scontrino_Cassa.Items.Clear();
        }

        private void eliminaVoceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Scontrino_Cassa.SelectedItems.Count != 0)
            {
                Scontrino_Cassa.Items.Remove(Scontrino_Cassa.SelectedItems[0]);
            }
        }

        
        private void Somma_Cassa()
        {
            float Sum = 0.00f;
            try
            {
                
                for (int i = 0; i < Scontrino_Cassa.Items.Count; i++)
                {
                    Sum += float.Parse(Scontrino_Cassa.Items[i].SubItems[1].Text.Split('€')[0]);
                }
                Cassa_Display.Text = String.Format("{0:c}",Sum);
            }
            catch
            {
                Cassa_Display.Text = "Errore";
            }
        }


        private void ribbonSetting_Click(object sender, EventArgs e)
        {
            if (!Manager.CheckFormOpen("Impostazioni Amministratore"))
            {
                Login_Password login = new Login_Password();
                login.ShowDialog();
            }
        }

        private void ribbonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ribbonShutdown_Click(object sender, EventArgs e)
        {
            DialogResult Shutdown = MessageBox.Show("Spegnere la macchina?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Shutdown == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
        }


        private void ribbonPrezzi_Click(object sender, EventArgs e)
        {
            if (!Manager.CheckFormOpen("Prezzi"))
            {
                Prezzi p = new Prezzi();
                p.Show();
            }
        }

        private void ribbonCategorie_Click(object sender, EventArgs e)
        {
            if (!Manager.CheckFormOpen("Categoria"))
            {
                Categoria frm_categoria = new Categoria();
                frm_categoria.Show();
            }
        }

        private void ribbonStorico_Click(object sender, EventArgs e)
        {
            if (!Manager.CheckFormOpen("Storico"))
            {
                History Storico = new History();
                Storico.Show();
            }
        }

        private void ribbonBell_Click(object sender, EventArgs e)
        {
            db_engine.Execute("UPDATE sys SET Campanello = 'True' Where ID = '1';");
        }

        private void ribbonPrint_Click(object sender, EventArgs e)
        {
            List<String> Prodotti = new List<String>();
            for (int i = 0; i < Scontrino_Cassa.Items.Count; i++)
            {
                Prodotti.Add(Scontrino_Cassa.Items[i].Text.PadRight(30) + Scontrino_Cassa.Items[i].SubItems[1].Text);
            }

            String Attivita = db_engine.return_rows("select Attivita from scontrino where id = '1';", 0);
            String Indirizzo = db_engine.return_rows("select Indirizzo from scontrino where id = '1';", 0);
            String Piva = db_engine.return_rows("select Piva from scontrino where id = '1';", 0);
            String Tel = db_engine.return_rows("select Tel from scontrino where id = '1';", 0);
            String Footer = db_engine.return_rows("select Footer from scontrino where id ='1';", 0);

            if (Scontrino_Cassa.Items.Count != 0)
            {
                lib.Scontrino Scontrino = new lib.Scontrino(Prodotti.ToArray(), Attivita, Indirizzo, Piva, Tel, LabCassa.Text, Footer);
                Scontrino.Print();
            }
            else
            {
                MessageBox.Show("Lista prodotti vuota", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Scontrino_Cassa.Items.Clear();
            LabCassa.Text = "Cassa";
            Cassa_Display.Text = "0";
        }

        private void ribbonAbout_Click(object sender, EventArgs e)
        {
            About Autore = new About();
            Autore.ShowDialog();
        }

        private void Cassa_Display_DoubleClick(object sender, EventArgs e)
        {
            Cassa_Display.Text = String.Empty;
        }
    }
}
