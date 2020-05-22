using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CashMag_Server
{
    public partial class Prezzi : Form
    {
        public Prezzi()
        {
            InitializeComponent();
        }

   
        Database.Engine db_engine = new Database.Engine();

        private void SearchText_Click(object sender, EventArgs e)
        {
            if(SearchText.Text == "Cerca...") SearchText.Text = String.Empty;
        }

        private void load_category(String query)
        {
            OptionSearch.Items.Clear();
            MySqlConnection Conn = new MySqlConnection(Database.Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                Conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while(read.Read())
                {
                    OptionSearch.Items.Add(read.GetString(1));
                }
            }catch
            {

            }finally
            {
                Conn.Close();
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
                    ProductList.Items[ID].SubItems.Add(read.GetString(3));
                    ProductList.Items[ID].SubItems.Add(read.GetString(4));
                    ProductList.Items[ID].SubItems.Add(read.GetString(0));
                    ID += 1;
                }
            }
            catch { }
            finally
            {
                Conn.Close();
            }

        }

        private void Prezzi_Load(object sender, EventArgs e)
        {
            load_category("select * from categoria;");
            load_product();
        }

        private void OptionSearch_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void OptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OptionSearch.Text == String.Empty)
            {
                load_product();
            }else
            {
                load_product("select * from prodotti where Categoria = '"+OptionSearch.Text+"';");
            }
        }

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            String Query = OptionSearch.Text.Length == 0 ? "ID and Nome Like '%" + SearchText.Text + "%';" : "Categoria = '" + OptionSearch.Text + "' AND Nome like '%" + SearchText.Text + "%';";
            load_product("SELECT * FROM prodotti where " + Query);
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ProductList.SelectedItems.Count != 0)
            {
                DialogResult msg = MessageBox.Show("Si è Sicuro di voler eliminare il prodotto ?", "Attenzione",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if(msg == DialogResult.Yes)
                {
                    db_engine.Execute("DELETE FROM prodotti WHERE ID = '" + ProductList.SelectedItems[0].SubItems[4].Text + "';");
                }
            }
            load_product();
        }
        
        private void edit()
        {
            if (ProductList.SelectedItems.Count != 0)
            {
                Edit Edit_Items = new Edit(ref ProductList);
                Edit_Items.Nome = ProductList.SelectedItems[0].Text;
                Edit_Items.Prezzo = ProductList.SelectedItems[0].SubItems[1].Text.Split('€')[0];
                Edit_Items.Categoria = ProductList.SelectedItems[0].SubItems[2].Text;
                Edit_Items.Disponibilita = ProductList.SelectedItems[0].SubItems[3].Text;
                Edit_Items.ID = ProductList.SelectedItems[0].SubItems[4].Text;
                Edit_Items.Action = "Modifica";
                foreach (string items in OptionSearch.Items) { Edit_Items.categoria_combo.Items.Add(items); }
                Edit_Items.ShowDialog();
                if (OptionSearch.Text == String.Empty)
                {
                    load_product();
                }
                else
                {
                    load_product("select * from prodotti where Categoria = '" + OptionSearch.Text + "';");
                }
                db_engine.Execute("update sys set Insert_Items = 'True' where id = '1';");
            }
        }
        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void aggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit Add_List = new Edit(ref ProductList);
            foreach (string items in OptionSearch.Items) { Add_List.categoria_combo.Items.Add(items); }
            Add_List.Action = "Aggiungi";
            Add_List.ShowDialog();

            if (OptionSearch.Text == String.Empty)
            {
                load_product();
            }
            else
            {
                load_product("select * from prodotti where Categoria = '" + OptionSearch.Text + "';");
            }

            db_engine.Execute("update sys set Insert_Items = 'True' where id = '1';");
        }

        private void ProductList_DoubleClick(object sender, EventArgs e)
        {
            edit();
        }
    }
}
