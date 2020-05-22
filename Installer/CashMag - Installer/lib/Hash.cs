using System;
using System.Text;
using System.Security.Cryptography;

namespace CashMag___Installer.lib
{
    class Hash
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
        //MD5 Crytp

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
    }
}
