namespace CashMag___Installer
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckLicenza = new System.Windows.Forms.TextBox();
            this.UtenteLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.download_link = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autore:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(50, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Turboli Salvatore";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Versione:";
            // 
            // CheckLicenza
            // 
            this.CheckLicenza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckLicenza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckLicenza.Location = new System.Drawing.Point(125, 84);
            this.CheckLicenza.MaxLength = 25;
            this.CheckLicenza.Name = "CheckLicenza";
            this.CheckLicenza.Size = new System.Drawing.Size(191, 13);
            this.CheckLicenza.TabIndex = 3;
            this.CheckLicenza.Text = "Inserisci licenza";
            this.CheckLicenza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckLicenza.Click += new System.EventHandler(this.CheckLicenza_Click);
            this.CheckLicenza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckLicenza_KeyDown);
            // 
            // UtenteLab
            // 
            this.UtenteLab.AutoSize = true;
            this.UtenteLab.Location = new System.Drawing.Point(94, 58);
            this.UtenteLab.Name = "UtenteLab";
            this.UtenteLab.Size = new System.Drawing.Size(39, 13);
            this.UtenteLab.TabIndex = 4;
            this.UtenteLab.Text = "Utente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assistenza:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(315, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "cashmag.it";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // download_link
            // 
            this.download_link.BackColor = System.Drawing.Color.WhiteSmoke;
            this.download_link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.download_link.Location = new System.Drawing.Point(97, 33);
            this.download_link.Name = "download_link";
            this.download_link.Size = new System.Drawing.Size(346, 13);
            this.download_link.TabIndex = 7;
            this.download_link.Text = "Link";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(455, 109);
            this.Controls.Add(this.download_link);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UtenteLab);
            this.Controls.Add(this.CheckLicenza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckLicenza;
        private System.Windows.Forms.Label UtenteLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox download_link;
    }
}