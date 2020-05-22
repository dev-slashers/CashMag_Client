using System;
using System.Windows.Forms;

namespace CashMag_Server
{
    public partial class Admin_Setting : Form
    {
        public Admin_Setting()
        {
            InitializeComponent();
        }

        
        lib.Manager manage = new lib.Manager();
        Database.Backup backup = new Database.Backup();
        Database.Engine engine = new Database.Engine();

        private void Admin_Setting_Load(object sender, EventArgs e)
        {
            Tav_Bar.Maximum = Database.Config.Numero_Max_Tavoli;
            try
            {
                Password_Text.Text      = manage.DecryptString(engine.return_rows("select * from sys where id = '1';", 1));
                Tav_Bar.Value           = Int32.Parse(engine.return_rows("select * from sys where id = '1';", 2));
                Text_Contribute.Text    = engine.return_rows("select * from sys where id = '1';", 4);
                CheckBoxForm.Checked    = bool.Parse(engine.return_rows("select FormSize from sys where id = '1';", 0));

                txt_attivita.Text     =   engine.return_rows("select Attivita from scontrino where id = '1';", 0);
                txt_indirizzo.Text    =   engine.return_rows("select Indirizzo from scontrino where id = '1';", 0);
                txt_piva.Text         =   engine.return_rows("select Piva from scontrino where id = '1';", 0);
                txt_tel.Text          =   engine.return_rows("select Tel from scontrino where id = '1';", 0);
                txt_footer.Text       =   engine.return_rows("select Footer from scontrino where id ='1';", 0);

            }
            catch
            {
                MessageBox.Show("Non è stato possibile stabilire una connessione al database", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = "Numero Tavoli (" + Tav_Bar.Value.ToString() +"):";
            this.TopMost = true;
        }


        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tav_Bar_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Numero Tavoli (" + Tav_Bar.Value.ToString() + "):";
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            String New_Pass = manage.EncryptString(Password_Text.Text);
            if(Password_Text.Text.Length >= 2 || Text_Contribute.Text.Length >= 1)
            {
                engine.Execute("update Sys set Numero_Tavoli = '" + Tav_Bar.Value.ToString() + "', UserPass = '" + New_Pass + "', Costo_Coperto = '" + Text_Contribute.Text + "', FormSize = '"+CheckBoxForm.Checked.ToString()+"' where id = '1';");
                engine.Execute("update scontrino set Attivita = '"+txt_attivita.Text+"', Indirizzo = '"+txt_indirizzo.Text+"', Piva = '"+txt_piva.Text+"', Tel = '"+txt_tel.Text+"', Footer = '"+txt_footer.Text+"' where id ='1';");
                MessageBox.Show("Per rendere effettive le modifiche riavviare il software", "Modifiche effettuate", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }else
            {
                MessageBox.Show("i campi non possono essere vuoti", "Errore Generico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Password_Text_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] Arr_key = { Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 };
            foreach(Keys k in Arr_key)
            {
                if (e.KeyCode == k)
                {
                    Password_Text.Text += k.ToString().Replace("NumPad", String.Empty);
                }else
                {
                    e.SuppressKeyPress = true;
                }
            }
            
            if (e.KeyCode == Keys.Enter && Password_Text.Text == Database.Config.Password)
            {
                Install_db_btn.Visible = true;
            }

        }

        private void Install_db_btn_Click(object sender, EventArgs e)
        {
            engine.Execute(Database.Config.install_db);
        }

        private void Export_db_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveDB_Dialog.FileName = "CASHMAG_DB.sql";
            SaveDB_Dialog.Title = "Destionazione Sql file";
            DialogResult Save = SaveDB_Dialog.ShowDialog();

            if(Save == DialogResult.OK && SaveDB_Dialog.FileName.ToString() != null)
            {
                if(backup.Save(SaveDB_Dialog.FileName.ToString()))
                {
                    MessageBox.Show("Il Database è stato esportato correttamente","Database",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void Import_db_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Open_DB_Dialog.FileName = "CASHMAG_DB.sql";
            Open_DB_Dialog.Title =  "Importa Database";
            DialogResult Open = Open_DB_Dialog.ShowDialog();

            if(Open == DialogResult.OK && Open_DB_Dialog.FileName.ToString() != null)
            {
                if(backup.Restore(Open_DB_Dialog.FileName.ToString()))
                {
                    MessageBox.Show("Database importato correttamente","Database",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void Text_Contribute_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] Arr = { Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Oemcomma };
            foreach (Keys k in Arr)
            {
                if (e.KeyCode == k)
                {
                    Text_Contribute.Text += k.ToString().Replace("Oemcomma", ",").Replace("NumPad", String.Empty);
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                if (Text_Contribute.Text.Length >= 1) Text_Contribute.Text = Text_Contribute.Text.Substring(0, (Text_Contribute.Text.Length - 1));
            }
        }

        private void ResetPassword_btn_Click(object sender, EventArgs e)
        {
            Password_Text.Text = string.Empty;
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Rimuovere tutti gli ordini in memoria?", "Sei sicuro ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(Delete == DialogResult.Yes)
            {
                MessageBox.Show("do it");
                engine.Execute("truncate ordinazioni;");
            }
        }

        private void DeleteHistory_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Eliminare in modo permanente lo storico ?", "Sei sicuro ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Delete == DialogResult.Yes)
            {
                engine.Execute("truncate storico");
            }
        }
    }
}
