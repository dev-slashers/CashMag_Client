namespace CashMag_Server
{
    partial class Registra_Programma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registra_Programma));
            this.Licenza_Text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SiteLinkLab = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Licenza_Text
            // 
            this.Licenza_Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Licenza_Text.Location = new System.Drawing.Point(0, 150);
            this.Licenza_Text.MaxLength = 35;
            this.Licenza_Text.Name = "Licenza_Text";
            this.Licenza_Text.Size = new System.Drawing.Size(458, 20);
            this.Licenza_Text.TabIndex = 0;
            this.Licenza_Text.Text = "Inserire Licenza";
            this.Licenza_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Licenza_Text.Click += new System.EventHandler(this.Licenza_Text_Click);
            this.Licenza_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Licenza_Text_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CashMag_Server.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 141);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SiteLinkLab
            // 
            this.SiteLinkLab.AutoSize = true;
            this.SiteLinkLab.Location = new System.Drawing.Point(400, 128);
            this.SiteLinkLab.Name = "SiteLinkLab";
            this.SiteLinkLab.Size = new System.Drawing.Size(58, 13);
            this.SiteLinkLab.TabIndex = 2;
            this.SiteLinkLab.TabStop = true;
            this.SiteLinkLab.Text = "cashmag.it";
            this.SiteLinkLab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SiteLinkLab_LinkClicked);
            // 
            // Registra_Programma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 173);
            this.Controls.Add(this.SiteLinkLab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Licenza_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registra_Programma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benvenuto !";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registra_Programma_FormClosing);
            this.Load += new System.EventHandler(this.Registra_Programma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Licenza_Text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel SiteLinkLab;
    }
}