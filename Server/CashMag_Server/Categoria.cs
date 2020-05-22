using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CashMag_Server
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        Database.Engine db_engine = new Database.Engine();

        private void SearchBox_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Cerca. . .") SearchBox.Text = string.Empty;
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            if (AddBox.Text == "Aggiungi . . .") AddBox.Text = string.Empty;
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void AddBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && AddBox.Text.Length >= 1)
            {
                db_engine.Execute("insert into cashmag.categoria (Nome) values ('"+AddBox.Text+"');");
                AddBox.Text = string.Empty;
                load_product();
            }
        }

        private void load_product(string query = "SELECT * FROM categoria order by id desc;")
        {
            int ID = 0;
            CategoryList.Items.Clear();
            MySqlConnection Conn = new MySqlConnection(Database.Config.Host);
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                Conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    CategoryList.Items.Add(read.GetString(1));
                    CategoryList.Items[ID].SubItems.Add(read.GetString(0));
                    ID += 1;
                }
            }
            catch { }
            finally
            {
                Conn.Close();
            }

        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            load_product();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            load_product("select * from categoria where nome like '%"+SearchBox.Text+"%';");
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CategoryList.SelectedItems.Count != 0)
            {
                db_engine.Execute("DELETE FROM categoria WHERE ID = '" + CategoryList.SelectedItems[0].SubItems[1].Text + "';");
                load_product();
            }
        }
    }
}
