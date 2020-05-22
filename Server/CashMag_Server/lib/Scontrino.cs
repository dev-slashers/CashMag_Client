using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CashMag_Server.lib
{
    class Scontrino
    {
        String[] Lista;
        String Attivita;
        String Indirizzo;
        String Piva;
        String Tel;
        String Tavolo;
        String Footer;

        public Scontrino(String[] Lista,String Attivita,String Indirizzo,String Piva, String Tel,String Tavolo ,String Footer)
        {
            this.Lista = Lista;
            this.Attivita = Attivita;
            this.Indirizzo = Indirizzo;
            this.Piva = Piva;
            this.Tel = Tel;
            this.Footer = Footer;
            this.Tavolo = Tavolo;
        }
        public void Print()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(CreateReceipt);
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK) printDocument.Print();

        }

        private String PadCenter(String names, char carattere = ' ', int maxlenght = 35)
        {
            string result = "";
            string[] charA = names.Split(',');

            for (int i = 0; i < charA.Length; i++)
            {
                int padLeft = (maxlenght - charA[i].Length) / 2;
                string temp = charA[i].PadLeft(charA[i].Length + padLeft, carattere);
                result += temp.PadRight(maxlenght, carattere) + "\n";
            }
            return result;
        }


        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;


            graphic.DrawString(PadCenter(Attivita), new Font("Courier New", 12), new SolidBrush(Color.Black),startX,startY);
            
            graphic.DrawString(PadCenter(Indirizzo), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, (startY + 30));
            graphic.DrawString(PadCenter(Piva), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, (startY + 50));
            graphic.DrawString(PadCenter(Tel), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, (startY + 70));
            offset += 70;
            string top = "Prodotto".PadRight(30) + "Costo";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            float totalprice = 0.00f;

            foreach (string item in Lista)
            {

                string productDescription = item;
                string productTotal = item.Substring(item.Length - 6, 6);
                float  productPrice = float.Parse(item.Split('€')[0].Substring(item.Split('€')[0].Length - 5, 5));
     
                totalprice += productPrice;

                if (productDescription.Contains("  -"))
                {
                    string productLine = productDescription.Substring(0, 24);

                    graphic.DrawString(productLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5;
                }
                else
                {
                    string productLine = productDescription;

                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5;
                }

            }

            offset = offset + 20;
            
            graphic.DrawString("Totale ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 60;
            graphic.DrawString(PadCenter(Tavolo), font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(PadCenter(Footer), font, new SolidBrush(Color.Black), startX, (startY + offset + 20));
        }
    }
}


