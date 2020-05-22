using System;
using System.IO;
using System.Text;
using System.Media;
using System.Diagnostics;

namespace CashMag_Client.lib
{
    class Manager
    {
        public void Notifica_Ordinazione()
        {
            Stream File = Properties.Resources.ding;
            SoundPlayer Sound = new SoundPlayer(File);
            Sound.Play();
        }


        public string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException)
            {
                decrypted = "";
            }
            return decrypted;
        }

        //Chiude la tastiera Windows
        public void KillProcess(String Processo = "TabTip")
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == Processo)
                {
                    Process.GetProcessById(theprocess.Id).Kill();
                    break;
                }

            }
        }

        public string EnryptString(string strEncrypted)
        {
            byte[] b = ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }
    }
}
