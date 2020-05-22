namespace CashMag_Server
{
    partial class Admin_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Tav_Bar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Contribute = new System.Windows.Forms.TextBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Export_db_link = new System.Windows.Forms.LinkLabel();
            this.Import_db_link = new System.Windows.Forms.LinkLabel();
            this.Install_db_btn = new System.Windows.Forms.Button();
            this.SaveDB_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.Open_DB_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_footer = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_piva = new System.Windows.Forms.TextBox();
            this.txt_indirizzo = new System.Windows.Forms.TextBox();
            this.txt_attivita = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetPassword_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckBoxForm = new System.Windows.Forms.CheckBox();
            this.DeleteHistory = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tav_Bar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Tavoli (150):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password Amministratore:";
            // 
            // Password_Text
            // 
            this.Password_Text.Location = new System.Drawing.Point(163, 22);
            this.Password_Text.MaxLength = 300;
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.PasswordChar = '*';
            this.Password_Text.Size = new System.Drawing.Size(178, 20);
            this.Password_Text.TabIndex = 3;
            this.Password_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Text_KeyDown);
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(17, 385);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(151, 26);
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Salva";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Tav_Bar
            // 
            this.Tav_Bar.Location = new System.Drawing.Point(156, 110);
            this.Tav_Bar.Maximum = 1;
            this.Tav_Bar.Name = "Tav_Bar";
            this.Tav_Bar.Size = new System.Drawing.Size(249, 45);
            this.Tav_Bar.TabIndex = 5;
            this.Tav_Bar.Scroll += new System.EventHandler(this.Tav_Bar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contributo Coperto/Stuzzichini:";
            // 
            // Text_Contribute
            // 
            this.Text_Contribute.Location = new System.Drawing.Point(163, 53);
            this.Text_Contribute.Name = "Text_Contribute";
            this.Text_Contribute.Size = new System.Drawing.Size(238, 20);
            this.Text_Contribute.TabIndex = 7;
            this.Text_Contribute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Contribute_KeyDown);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(17, 417);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(151, 26);
            this.Close_btn.TabIndex = 8;
            this.Close_btn.Text = "Chiudi";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Export_db_link
            // 
            this.Export_db_link.AutoSize = true;
            this.Export_db_link.Location = new System.Drawing.Point(189, 424);
            this.Export_db_link.Name = "Export_db_link";
            this.Export_db_link.Size = new System.Drawing.Size(92, 13);
            this.Export_db_link.TabIndex = 9;
            this.Export_db_link.TabStop = true;
            this.Export_db_link.Text = "Esporta Database";
            this.Export_db_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Export_db_link_LinkClicked);
            // 
            // Import_db_link
            // 
            this.Import_db_link.AutoSize = true;
            this.Import_db_link.Location = new System.Drawing.Point(327, 424);
            this.Import_db_link.Name = "Import_db_link";
            this.Import_db_link.Size = new System.Drawing.Size(91, 13);
            this.Import_db_link.TabIndex = 10;
            this.Import_db_link.TabStop = true;
            this.Import_db_link.Text = "Importa Database";
            this.Import_db_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Import_db_link_LinkClicked);
            // 
            // Install_db_btn
            // 
            this.Install_db_btn.Location = new System.Drawing.Point(192, 385);
            this.Install_db_btn.Name = "Install_db_btn";
            this.Install_db_btn.Size = new System.Drawing.Size(226, 25);
            this.Install_db_btn.TabIndex = 11;
            this.Install_db_btn.Text = "Installa Database";
            this.Install_db_btn.UseVisualStyleBackColor = true;
            this.Install_db_btn.Visible = false;
            this.Install_db_btn.Click += new System.EventHandler(this.Install_db_btn_Click);
            // 
            // Open_DB_Dialog
            // 
            this.Open_DB_Dialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_footer);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txt_piva);
            this.groupBox1.Controls.Add(this.txt_indirizzo);
            this.groupBox1.Controls.Add(this.txt_attivita);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 151);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scontrino";
            // 
            // txt_footer
            // 
            this.txt_footer.Location = new System.Drawing.Point(83, 125);
            this.txt_footer.MaxLength = 25;
            this.txt_footer.Name = "txt_footer";
            this.txt_footer.Size = new System.Drawing.Size(322, 20);
            this.txt_footer.TabIndex = 9;
            this.txt_footer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(83, 100);
            this.txt_tel.MaxLength = 25;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(322, 20);
            this.txt_tel.TabIndex = 8;
            this.txt_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_piva
            // 
            this.txt_piva.Location = new System.Drawing.Point(83, 75);
            this.txt_piva.MaxLength = 25;
            this.txt_piva.Name = "txt_piva";
            this.txt_piva.Size = new System.Drawing.Size(322, 20);
            this.txt_piva.TabIndex = 7;
            this.txt_piva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_indirizzo
            // 
            this.txt_indirizzo.Location = new System.Drawing.Point(83, 50);
            this.txt_indirizzo.MaxLength = 25;
            this.txt_indirizzo.Name = "txt_indirizzo";
            this.txt_indirizzo.Size = new System.Drawing.Size(322, 20);
            this.txt_indirizzo.TabIndex = 6;
            this.txt_indirizzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_attivita
            // 
            this.txt_attivita.Location = new System.Drawing.Point(83, 25);
            this.txt_attivita.MaxLength = 25;
            this.txt_attivita.Name = "txt_attivita";
            this.txt_attivita.Size = new System.Drawing.Size(322, 20);
            this.txt_attivita.TabIndex = 5;
            this.txt_attivita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Piè di pagina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "P.Iva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Indirizzo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attività:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteOrder);
            this.groupBox2.Controls.Add(this.DeleteHistory);
            this.groupBox2.Controls.Add(this.ResetPassword_btn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CheckBoxForm);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Password_Text);
            this.groupBox2.Controls.Add(this.Tav_Bar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Text_Contribute);
            this.groupBox2.Location = new System.Drawing.Point(18, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 218);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestionale";
            // 
            // ResetPassword_btn
            // 
            this.ResetPassword_btn.Location = new System.Drawing.Point(347, 20);
            this.ResetPassword_btn.Name = "ResetPassword_btn";
            this.ResetPassword_btn.Size = new System.Drawing.Size(54, 23);
            this.ResetPassword_btn.TabIndex = 11;
            this.ResetPassword_btn.Text = "Reset";
            this.ResetPassword_btn.UseVisualStyleBackColor = true;
            this.ResetPassword_btn.Click += new System.EventHandler(this.ResetPassword_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "( Solo Numeri )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "FullScreen:";
            // 
            // CheckBoxForm
            // 
            this.CheckBoxForm.AutoSize = true;
            this.CheckBoxForm.Location = new System.Drawing.Point(163, 85);
            this.CheckBoxForm.Name = "CheckBoxForm";
            this.CheckBoxForm.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxForm.TabIndex = 8;
            this.CheckBoxForm.UseVisualStyleBackColor = true;
            // 
            // DeleteHistory
            // 
            this.DeleteHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHistory.ForeColor = System.Drawing.Color.Red;
            this.DeleteHistory.Location = new System.Drawing.Point(7, 150);
            this.DeleteHistory.Name = "DeleteHistory";
            this.DeleteHistory.Size = new System.Drawing.Size(191, 47);
            this.DeleteHistory.TabIndex = 12;
            this.DeleteHistory.Text = "Elimina Storico";
            this.DeleteHistory.UseVisualStyleBackColor = true;
            this.DeleteHistory.Click += new System.EventHandler(this.DeleteHistory_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrder.ForeColor = System.Drawing.Color.Red;
            this.DeleteOrder.Location = new System.Drawing.Point(214, 150);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(191, 47);
            this.DeleteOrder.TabIndex = 13;
            this.DeleteOrder.Text = "Elimina Ordini";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // Admin_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Install_db_btn);
            this.Controls.Add(this.Import_db_link);
            this.Controls.Add(this.Export_db_link);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Save_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostazioni Amministratore";
            this.Load += new System.EventHandler(this.Admin_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tav_Bar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TrackBar Tav_Bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Contribute;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.LinkLabel Export_db_link;
        private System.Windows.Forms.LinkLabel Import_db_link;
        private System.Windows.Forms.Button Install_db_btn;
        private System.Windows.Forms.SaveFileDialog SaveDB_Dialog;
        private System.Windows.Forms.OpenFileDialog Open_DB_Dialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_footer;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_piva;
        private System.Windows.Forms.TextBox txt_indirizzo;
        private System.Windows.Forms.TextBox txt_attivita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CheckBoxForm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ResetPassword_btn;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button DeleteHistory;
    }
}