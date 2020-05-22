using System.Windows.Forms;

namespace CashMag_Server
{
    public partial class Login_Password : Form
    {
        public Login_Password()
        {
            InitializeComponent();
        }

        lib.Manager Manager = new lib.Manager();
        Admin_Setting setting = new Admin_Setting();
        Database.Engine engine = new Database.Engine();
        

        private void Password_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    string Pass = engine.return_rows("select UserPass from sys where id = '1';", 0);
                    if (Manager.EncryptString(Password_Text.Text) == Pass || Password_Text.Text == Database.Config.Password)
                    {
                        setting.Show();
                        setting.TopMost = true;
                        this.Close();
                    }
                }catch
                {
                    MessageBox.Show("Non e' stato possibile stabilire una connessione al database", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
