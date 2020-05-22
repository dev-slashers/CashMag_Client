namespace CashMag_Server
{
    partial class Ordinazione
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordinazione));
            this.GrupTavolo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Chiudi_Ordinazione = new System.Windows.Forms.Button();
            this.Lab_Sum = new System.Windows.Forms.Label();
            this.ListSum = new System.Windows.Forms.ListView();
            this.Ordinazioni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrupTavolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupTavolo
            // 
            this.GrupTavolo.Controls.Add(this.button1);
            this.GrupTavolo.Controls.Add(this.Chiudi_Ordinazione);
            this.GrupTavolo.Controls.Add(this.Lab_Sum);
            this.GrupTavolo.Controls.Add(this.ListSum);
            this.GrupTavolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupTavolo.Location = new System.Drawing.Point(5, 5);
            this.GrupTavolo.Name = "GrupTavolo";
            this.GrupTavolo.Size = new System.Drawing.Size(515, 490);
            this.GrupTavolo.TabIndex = 5;
            this.GrupTavolo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(279, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chiudi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chiudi_Ordinazione
            // 
            this.Chiudi_Ordinazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chiudi_Ordinazione.Location = new System.Drawing.Point(5, 445);
            this.Chiudi_Ordinazione.Name = "Chiudi_Ordinazione";
            this.Chiudi_Ordinazione.Size = new System.Drawing.Size(231, 37);
            this.Chiudi_Ordinazione.TabIndex = 0;
            this.Chiudi_Ordinazione.Text = "Libera il tavolo";
            this.Chiudi_Ordinazione.UseVisualStyleBackColor = true;
            this.Chiudi_Ordinazione.Click += new System.EventHandler(this.Chiudi_Ordinazione_Click);
            // 
            // Lab_Sum
            // 
            this.Lab_Sum.AutoSize = true;
            this.Lab_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Sum.Location = new System.Drawing.Point(6, 385);
            this.Lab_Sum.Name = "Lab_Sum";
            this.Lab_Sum.Size = new System.Drawing.Size(260, 39);
            this.Lab_Sum.TabIndex = 4;
            this.Lab_Sum.Text = "Totale Ordine :";
            // 
            // ListSum
            // 
            this.ListSum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ordinazioni,
            this.Prezzo});
            this.ListSum.FullRowSelect = true;
            this.ListSum.GridLines = true;
            this.ListSum.Location = new System.Drawing.Point(5, 20);
            this.ListSum.Name = "ListSum";
            this.ListSum.Size = new System.Drawing.Size(505, 358);
            this.ListSum.TabIndex = 3;
            this.ListSum.UseCompatibleStateImageBehavior = false;
            this.ListSum.View = System.Windows.Forms.View.Details;
            // 
            // Ordinazioni
            // 
            this.Ordinazioni.Text = "Ordinazioni";
            this.Ordinazioni.Width = 250;
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            this.Prezzo.Width = 250;
            // 
            // Ordinazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 502);
            this.Controls.Add(this.GrupTavolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ordinazione";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordinazione";
            this.Load += new System.EventHandler(this.Ordinazione_Load);
            this.GrupTavolo.ResumeLayout(false);
            this.GrupTavolo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupTavolo;
        private System.Windows.Forms.Button Chiudi_Ordinazione;
        private System.Windows.Forms.Label Lab_Sum;
        private System.Windows.Forms.ListView ListSum;
        private System.Windows.Forms.ColumnHeader Ordinazioni;
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.Button button1;
    }
}