using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CashMag_Server.lib
{
    class Manager
    {
        // Base64 
        public string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = ASCIIEncoding.ASCII.GetString(b);
            }
            catch 
            {
                decrypted = "";
            }
            return decrypted;
        }

        public string EncryptString(string strEncrypted)
        {
            byte[] b = ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }


        public void New_Order_Notify()
        {
            Stream str = Properties.Resources.Notifica;
            System.Media.SoundPlayer Notifica = new System.Media.SoundPlayer(str);
            Notifica.Play();
        }

        //Trasferisce una listview ad un altra listview 
        public void Migrate_list(ref ListView First, ref ListView Another)
        {
            Another.Items.Clear();
            for (int i = 0; i < First.Items.Count; i++)
            {
                Another.Items.Add(First.Items[i].Text);
                Another.Items[i].SubItems.Add(First.Items[i].SubItems[1].Text);
            }
        }

        public bool CheckFormOpen(String FmName)
        {
            foreach (Form FormName in Application.OpenForms) if (FormName.Text == FmName) return true;
            return false;
        }

        //Controllo Valore Float
        public Boolean Controllo_Costo(String Values)
        {
            try
            {
                float cifra = float.Parse(Values);
                float Sum = cifra + cifra;
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Calcolatrice
        public int Sum(String TextSum)
        {
            List<string> s = new List<string>();
            string[] decimalNumbers = TextSum.Split('+', '-', '*', '/');
            string[] operators = TextSum.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.');
            try
            {
                foreach (var item in operators)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        s.Add(item);
                    }
                }
                decimal intSum = 0;
                for (int i = 0; i < decimalNumbers.Length; i++)
                {
                    if (i == 0)
                    {
                        intSum = Convert.ToDecimal(decimalNumbers[i]);
                    }
                    if (i > 0)
                    {
                        string oprator = s[i - 1];
                        switch (oprator)
                        {
                            case "+":
                                intSum = intSum + Convert.ToDecimal(decimalNumbers[i]);
                                break;
                            case "-":
                                intSum = intSum - Convert.ToDecimal(decimalNumbers[i]);
                                break;
                            case "*":
                                intSum = intSum * Convert.ToDecimal(decimalNumbers[i]);
                                break;
                            case "/":
                                intSum = intSum / Convert.ToDecimal(decimalNumbers[i]);
                                break;
                        }
                    }
                }
                return Int32.Parse(Math.Round(intSum, 2).ToString());
            }
            catch
            {
                return 0;
            }
        }

    }
}

