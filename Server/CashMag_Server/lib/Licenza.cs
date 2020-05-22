using System;
using System.Net;
using System.Text;
using Microsoft.Win32;
using System.Security.Cryptography;


namespace CashMag_Server.lib
{
    class Licenza
    {
        InIManager Gestor = new InIManager(Database.Config.Setting_ini);

        public Boolean Controllo_Licenza(string Licenza)
        {
            WebClient wb = new WebClient();
            try
            {
                String json_output = wb.DownloadString(Database.Config.Server_Token + MD5Hash(Licenza));
                String Download_Key = Base64Encode(json_read(json_output, "Download_Key")).Substring(10).ToLower();
                if (Licenza == json_read(json_output, "Licenza") && Download_Key == json_read(json_output, "Access_Key"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public Boolean Load_Licenza()
        {
            if(CheckForInternetConnection() == true && Controllo_Licenza(Gestor.Read("Licenza", "Software")) == true)
            {
                return true;
            }
            if (CheckForInternetConnection() == false)
            {
                if(Base64Encode(Read_RegistryKey("Licenza")) ==  Base64Encode(MD5Hash(Gestor.Read("Licenza","Software"))))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckForInternetConnection()
        {
            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                try
                {
                    using (var client = new WebClient())
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }else
            {
                return false;
            }
        }

        //Json read
        public string json_read(string json, string index)
        {
            int Count = 0;
            String Result = String.Empty;
            foreach (string str in json.Split(':'))
            {
                if (str.IndexOf(index) != -1)
                {
                    Result = json.Split(':')[Count + 1].Split('"')[1];
                }
                Count++;
            }
            return Result;
        }

        // Hash encode
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        // Registry Manager
        public void Create_RegistryKey(String Name, String Value)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"AppEvents\");
            key.SetValue(Name, Value);
            key.Close();
        }

        public string Read_RegistryKey(string Name)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AppEvents");
                return key.GetValue(Name).ToString();
            }catch
            {
                return string.Empty;
            }
        }
    }
}
