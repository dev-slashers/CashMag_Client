namespace CashMag___Installer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IP_Text = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Port_txt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.host_txt = new System.Windows.Forms.TextBox();
            this.Database_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VoidradioButton = new System.Windows.Forms.RadioButton();
            this.BarRadioButton = new System.Windows.Forms.RadioButton();
            this.PubRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Avanzate = new System.Windows.Forms.ToolStripMenuItem();
            this.scorciatoiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountUtenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.modificaMyiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniAvanzateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP_Text
            // 
            this.IP_Text.Location = new System.Drawing.Point(72, 88);
            this.IP_Text.Name = "IP_Text";
            this.IP_Text.Size = new System.Drawing.Size(198, 20);
            this.IP_Text.TabIndex = 0;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(5, 169);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(314, 34);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "Installa";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Locale:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Password_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Username_txt);
            this.groupBox2.Controls.Add(this.Port_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(620, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(70, 55);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(200, 20);
            this.Password_txt.TabIndex = 2;
            this.Password_txt.Text = "gestionale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(70, 26);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(200, 20);
            this.Username_txt.TabIndex = 1;
            this.Username_txt.Text = "root";
            // 
            // Port_txt
            // 
            this.Port_txt.FormattingEnabled = true;
            this.Port_txt.Items.AddRange(new object[] {
            "3300",
            "3306"});
            this.Port_txt.Location = new System.Drawing.Point(70, 85);
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.Size = new System.Drawing.Size(200, 21);
            this.Port_txt.TabIndex = 10;
            this.Port_txt.Text = "3300";
            this.Port_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Port_txt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Porta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP/Host:";
            // 
            // host_txt
            // 
            this.host_txt.Location = new System.Drawing.Point(72, 22);
            this.host_txt.Name = "host_txt";
            this.host_txt.Size = new System.Drawing.Size(198, 20);
            this.host_txt.TabIndex = 0;
            this.host_txt.Text = "localhost";
            // 
            // Database_txt
            // 
            this.Database_txt.Location = new System.Drawing.Point(72, 56);
            this.Database_txt.Name = "Database_txt";
            this.Database_txt.Size = new System.Drawing.Size(198, 20);
            this.Database_txt.TabIndex = 8;
            this.Database_txt.Text = "cashmag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Database:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StartupCheckBox);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(5, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurazione Applicativo";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.Checked = true;
            this.StartupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartupCheckBox.Location = new System.Drawing.Point(32, 21);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(86, 17);
            this.StartupCheckBox.TabIndex = 2;
            this.StartupCheckBox.Text = "Apri All\'avvio";
            this.StartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(212, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Tablet";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PC";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IP_Text);
            this.groupBox1.Controls.Add(this.host_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Database_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(325, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VoidradioButton);
            this.groupBox4.Controls.Add(this.BarRadioButton);
            this.groupBox4.Controls.Add(this.PubRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(5, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 55);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipologia Attività";
            // 
            // VoidradioButton
            // 
            this.VoidradioButton.AutoSize = true;
            this.VoidradioButton.Location = new System.Drawing.Point(138, 22);
            this.VoidradioButton.Name = "VoidradioButton";
            this.VoidradioButton.Size = new System.Drawing.Size(53, 17);
            this.VoidradioButton.TabIndex = 2;
            this.VoidradioButton.TabStop = true;
            this.VoidradioButton.Text = "Vuoto";
            this.VoidradioButton.UseVisualStyleBackColor = true;
            // 
            // BarRadioButton
            // 
            this.BarRadioButton.AutoSize = true;
            this.BarRadioButton.Checked = true;
            this.BarRadioButton.Location = new System.Drawing.Point(32, 22);
            this.BarRadioButton.Name = "BarRadioButton";
            this.BarRadioButton.Size = new System.Drawing.Size(41, 17);
            this.BarRadioButton.TabIndex = 1;
            this.BarRadioButton.TabStop = true;
            this.BarRadioButton.Text = "Bar";
            this.BarRadioButton.UseVisualStyleBackColor = true;
            // 
            // PubRadioButton
            // 
            this.PubRadioButton.AutoSize = true;
            this.PubRadioButton.Location = new System.Drawing.Point(212, 22);
            this.PubRadioButton.Name = "PubRadioButton";
            this.PubRadioButton.Size = new System.Drawing.Size(85, 17);
            this.PubRadioButton.TabIndex = 0;
            this.PubRadioButton.Text = "Pub/Pizzeria";
            this.PubRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Avanzate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Avanzate
            // 
            this.Menu_Avanzate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scorciatoiaToolStripMenuItem,
            this.opzioniAvanzateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.esciToolStripMenuItem});
            this.Menu_Avanzate.Name = "Menu_Avanzate";
            this.Menu_Avanzate.Size = new System.Drawing.Size(37, 20);
            this.Menu_Avanzate.Text = "File";
            // 
            // scorciatoiaToolStripMenuItem
            // 
            this.scorciatoiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountUtenteToolStripMenuItem,
            this.mySQLInstallerToolStripMenuItem,
            this.toolStripMenuItem3,
            this.modificaMyiniToolStripMenuItem});
            this.scorciatoiaToolStripMenuItem.Name = "scorciatoiaToolStripMenuItem";
            this.scorciatoiaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.scorciatoiaToolStripMenuItem.Text = "Scorciatoia";
            // 
            // accountUtenteToolStripMenuItem
            // 
            this.accountUtenteToolStripMenuItem.Name = "accountUtenteToolStripMenuItem";
            this.accountUtenteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.accountUtenteToolStripMenuItem.Text = "Account utente";
            this.accountUtenteToolStripMenuItem.Click += new System.EventHandler(this.accountUtenteToolStripMenuItem_Click);
            // 
            // mySQLInstallerToolStripMenuItem
            // 
            this.mySQLInstallerToolStripMenuItem.Name = "mySQLInstallerToolStripMenuItem";
            this.mySQLInstallerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mySQLInstallerToolStripMenuItem.Text = "MySQL Installer";
            this.mySQLInstallerToolStripMenuItem.Click += new System.EventHandler(this.mySQLInstallerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 6);
            // 
            // modificaMyiniToolStripMenuItem
            // 
            this.modificaMyiniToolStripMenuItem.Name = "modificaMyiniToolStripMenuItem";
            this.modificaMyiniToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificaMyiniToolStripMenuItem.Text = "Modifica my.ini";
            this.modificaMyiniToolStripMenuItem.Click += new System.EventHandler(this.modificaMyiniToolStripMenuItem_Click);
            // 
            // opzioniAvanzateToolStripMenuItem
            // 
            this.opzioniAvanzateToolStripMenuItem.Name = "opzioniAvanzateToolStripMenuItem";
            this.opzioniAvanzateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.opzioniAvanzateToolStripMenuItem.Text = "Opzioni Avanzate";
            this.opzioniAvanzateToolStripMenuItem.Click += new System.EventHandler(this.opzioniAvanzateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(5, 147);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(314, 16);
            this.StatusBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(323, 206);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashMag - Installer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_Text;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox host_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Database_txt;
        private System.Windows.Forms.ComboBox Port_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton BarRadioButton;
        private System.Windows.Forms.RadioButton PubRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Avanzate;
        private System.Windows.Forms.ToolStripMenuItem opzioniAvanzateToolStripMenuItem;
        private System.Windows.Forms.CheckBox StartupCheckBox;
        private System.Windows.Forms.ProgressBar StatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem scorciatoiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountUtenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaMyiniToolStripMenuItem;
        private System.Windows.Forms.RadioButton VoidradioButton;
        private System.Windows.Forms.ToolStripMenuItem mySQLInstallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

