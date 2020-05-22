using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CashMag_Server
{
    public partial class Edit : Form
    {
        
        public Edit(ref ListView lista_prodotti)
        {
            Product_List = lista_prodotti;
            InitializeComponent();
        }

        lib.Manager Man = new lib.Manager();
        ListView Product_List = new ListView();
        
        public String Nome, Prezzo, Categoria, Disponibilita, ID, Action;

        private void disp_combo_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; }
        private void categoria_combo_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; }


        private void Enter_button_Click(object sender, EventArgs e)
        {
            if(Nome_Text.Text.Length >= 1 && Man.Controllo_Costo(Costo_Text.Text) && categoria_combo.Text.Length >= 1 && disp_combo.Text.Length >= 1)
            {
                Insert(Nome_Text.Text, Costo_Text.Text, categoria_combo.Text, ID, disp_combo.Text);
                Product_List.Items.Clear();
                this.Close();
            }else
            {
                MessageBox.Show("Controllare che i campi siano corretti", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            Nome_Text.Text = Nome;
            Costo_Text.Text = Prezzo;
            categoria_combo.Text = Categoria;
            disp_combo.Text = Disponibilita;
            Enter_button.Text = Action;
        }



        public void Insert(String Nome, String Prezzo, String Categoria, String ID, String Disp)
        {
            String Query = null;
            if (Enter_button.Text == "Aggiungi") Query = "INSERT INTO prodotti (Nome,Prezzo,Categoria,Disponibile) VALUES (@Nome,@Prezzo,@Categoria,@Disponibilita)";
            if (Enter_button.Text == "Modifica") Query = "UPDATE prodotti set Nome = @Nome,Prezzo = @Prezzo, Categoria = @Categoria, Disponibile = @Disponibilita where id ='" + ID + "';";
            MySqlConnection conn = new MySqlConnection(Database.Config.Host);
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = Query;
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Prezzo", Prezzo);
            cmd.Parameters.AddWithValue("@Categoria", Categoria);
            cmd.Parameters.AddWithValue("@Disponibilita", Disp);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        private void Costo_Text_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] Arr = { Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Oemcomma};
            foreach(Keys k in Arr)
            {
                if(e.KeyCode == k)
                {
                    Costo_Text.Text += k.ToString().Replace("Oemcomma", ",").Replace("NumPad",String.Empty);
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }

            if(e.KeyCode == Keys.Back)
            {
                if(Costo_Text.Text.Length >= 1) Costo_Text.Text = Costo_Text.Text.Substring(0, (Costo_Text.Text.Length -1));
            }
        }

    }
}
