namespace CashMag_Server
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabCassa = new System.Windows.Forms.Label();
            this.Scontrino_Cassa = new System.Windows.Forms.ListView();
            this.ProdottoHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezzoHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Cassa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ripulisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaVoceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cassa_Display = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_List = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDecrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aggiungiAllaCassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GrupTavolo = new System.Windows.Forms.GroupBox();
            this.check_new_order = new System.Windows.Forms.Timer(this.components);
            this.load_main = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.print_btn_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonSetting = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonShutdown = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPrezzi = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonCategorie = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonStorico = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonBell = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPrint = new System.Windows.Forms.RibbonButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Menu_Cassa.SuspendLayout();
            this.Product_List.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 127);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 303);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabCassa);
            this.tabPage2.Controls.Add(this.Scontrino_Cassa);
            this.tabPage2.Controls.Add(this.Cassa_Display);
            this.tabPage2.Controls.Add(this.ProductList);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1149, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestione Cassa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabCassa
            // 
            this.LabCassa.AutoSize = true;
            this.LabCassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCassa.Location = new System.Drawing.Point(541, 607);
            this.LabCassa.Name = "LabCassa";
            this.LabCassa.Size = new System.Drawing.Size(164, 57);
            this.LabCassa.TabIndex = 6;
            this.LabCassa.Text = "Cassa";
            this.LabCassa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Scontrino_Cassa
            // 
            this.Scontrino_Cassa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdottoHead,
            this.PrezzoHead});
            this.Scontrino_Cassa.ContextMenuStrip = this.Menu_Cassa;
            this.Scontrino_Cassa.FullRowSelect = true;
            this.Scontrino_Cassa.Location = new System.Drawing.Point(551, 14);
            this.Scontrino_Cassa.Name = "Scontrino_Cassa";
            this.Scontrino_Cassa.Size = new System.Drawing.Size(584, 579);
            this.Scontrino_Cassa.TabIndex = 5;
            this.Scontrino_Cassa.UseCompatibleStateImageBehavior = false;
            this.Scontrino_Cassa.View = System.Windows.Forms.View.Details;
            // 
            // ProdottoHead
            // 
            this.ProdottoHead.Text = "Prodotto";
            this.ProdottoHead.Width = 500;
            // 
            // PrezzoHead
            // 
            this.PrezzoHead.Text = "Prezzo";
            // 
            // Menu_Cassa
            // 
            this.Menu_Cassa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ripulisciToolStripMenuItem,
            this.eliminaVoceToolStripMenuItem});
            this.Menu_Cassa.Name = "Menu_Cassa";
            this.Menu_Cassa.Size = new System.Drawing.Size(142, 48);
            // 
            // ripulisciToolStripMenuItem
            // 
            this.ripulisciToolStripMenuItem.Name = "ripulisciToolStripMenuItem";
            this.ripulisciToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ripulisciToolStripMenuItem.Text = "Ripulisci";
            this.ripulisciToolStripMenuItem.Click += new System.EventHandler(this.ripulisciToolStripMenuItem_Click);
            // 
            // eliminaVoceToolStripMenuItem
            // 
            this.eliminaVoceToolStripMenuItem.Name = "eliminaVoceToolStripMenuItem";
            this.eliminaVoceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.eliminaVoceToolStripMenuItem.Text = "Elimina Voce";
            this.eliminaVoceToolStripMenuItem.Click += new System.EventHandler(this.eliminaVoceToolStripMenuItem_Click);
            // 
            // Cassa_Display
            // 
            this.Cassa_Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cassa_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cassa_Display.Location = new System.Drawing.Point(781, 605);
            this.Cassa_Display.Name = "Cassa_Display";
            this.Cassa_Display.Size = new System.Drawing.Size(354, 56);
            this.Cassa_Display.TabIndex = 0;
            this.Cassa_Display.Text = "0";
            this.Cassa_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cassa_Display.DoubleClick += new System.EventHandler(this.Cassa_Display_DoubleClick);
            this.Cassa_Display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cassa_Display_KeyDown);
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ProductList.ContextMenuStrip = this.Product_List;
            this.ProductList.FullRowSelect = true;
            this.ProductList.GridLines = true;
            this.ProductList.Location = new System.Drawing.Point(8, 14);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(521, 650);
            this.ProductList.TabIndex = 4;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            this.ProductList.DoubleClick += new System.EventHandler(this.ProductList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezzo";
            this.columnHeader2.Width = 100;
            // 
            // Product_List
            // 
            this.Product_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.refreshDecrescenteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aggiungiAllaCassaToolStripMenuItem});
            this.Product_List.Name = "Product_List";
            this.Product_List.Size = new System.Drawing.Size(199, 76);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.refreshToolStripMenuItem.Text = "Aggiorna";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // refreshDecrescenteToolStripMenuItem
            // 
            this.refreshDecrescenteToolStripMenuItem.Name = "refreshDecrescenteToolStripMenuItem";
            this.refreshDecrescenteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.refreshDecrescenteToolStripMenuItem.Text = "Aggiorna - Decrescente";
            this.refreshDecrescenteToolStripMenuItem.Click += new System.EventHandler(this.refreshDecrescenteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
            // 
            // aggiungiAllaCassaToolStripMenuItem
            // 
            this.aggiungiAllaCassaToolStripMenuItem.Name = "aggiungiAllaCassaToolStripMenuItem";
            this.aggiungiAllaCassaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aggiungiAllaCassaToolStripMenuItem.Text = "Aggiungi Alla Cassa";
            this.aggiungiAllaCassaToolStripMenuItem.Click += new System.EventHandler(this.aggiungiAllaCassaToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrupTavolo);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestione Tavoli";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GrupTavolo
            // 
            this.GrupTavolo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupTavolo.Location = new System.Drawing.Point(0, 0);
            this.GrupTavolo.Name = "GrupTavolo";
            this.GrupTavolo.Size = new System.Drawing.Size(1161, 1358);
            this.GrupTavolo.TabIndex = 0;
            this.GrupTavolo.TabStop = false;
            // 
            // check_new_order
            // 
            this.check_new_order.Tick += new System.EventHandler(this.check_new_order_Tick);
            // 
            // load_main
            // 
            this.load_main.Tick += new System.EventHandler(this.load_main_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 111);
            this.toolStripMenuItem1.Text = "Stampa";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // print_btn_menu
            // 
            this.print_btn_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn_menu.Name = "print_btn_menu";
            this.print_btn_menu.Size = new System.Drawing.Size(59, 111);
            this.print_btn_menu.Text = "Stampa";
            this.print_btn_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSetting);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonAbout);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonShutdown);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonExit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 251);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::CashMag_Server.Properties.Resources.logo;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1176, 128);
            this.ribbon1.TabIndex = 2;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(6, 2, 20, 0);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonSetting
            // 
            this.ribbonSetting.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonSetting.Image = global::CashMag_Server.Properties.Resources.Admin_icon;
            this.ribbonSetting.LargeImage = global::CashMag_Server.Properties.Resources.Admin_icon;
            this.ribbonSetting.Name = "ribbonSetting";
            this.ribbonSetting.SmallImage = global::CashMag_Server.Properties.Resources.Admin_icon;
            this.ribbonSetting.Text = "Impostazioni";
            this.ribbonSetting.Click += new System.EventHandler(this.ribbonSetting_Click);
            // 
            // ribbonAbout
            // 
            this.ribbonAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonAbout.Image = ((System.Drawing.Image)(resources.GetObject("ribbonAbout.Image")));
            this.ribbonAbout.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonAbout.LargeImage")));
            this.ribbonAbout.Name = "ribbonAbout";
            this.ribbonAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonAbout.SmallImage")));
            this.ribbonAbout.Text = "Informazioni";
            this.ribbonAbout.Click += new System.EventHandler(this.ribbonAbout_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // ribbonShutdown
            // 
            this.ribbonShutdown.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonShutdown.Image = global::CashMag_Server.Properties.Resources.shutdown;
            this.ribbonShutdown.LargeImage = global::CashMag_Server.Properties.Resources.shutdown;
            this.ribbonShutdown.Name = "ribbonShutdown";
            this.ribbonShutdown.SmallImage = global::CashMag_Server.Properties.Resources.shutdown;
            this.ribbonShutdown.Text = "Spegni";
            this.ribbonShutdown.Click += new System.EventHandler(this.ribbonShutdown_Click);
            // 
            // ribbonExit
            // 
            this.ribbonExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonExit.Image = global::CashMag_Server.Properties.Resources.exit;
            this.ribbonExit.LargeImage = global::CashMag_Server.Properties.Resources.exit;
            this.ribbonExit.Name = "ribbonExit";
            this.ribbonExit.SmallImage = global::CashMag_Server.Properties.Resources.exit;
            this.ribbonExit.Text = "Esci";
            this.ribbonExit.Click += new System.EventHandler(this.ribbonExit_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Text = "Strumenti";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.ribbonPrezzi);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Prodotti";
            // 
            // ribbonPrezzi
            // 
            this.ribbonPrezzi.Image = global::CashMag_Server.Properties.Resources.paste;
            this.ribbonPrezzi.LargeImage = global::CashMag_Server.Properties.Resources.paste;
            this.ribbonPrezzi.Name = "ribbonPrezzi";
            this.ribbonPrezzi.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonPrezzi.SmallImage")));
            this.ribbonPrezzi.Click += new System.EventHandler(this.ribbonPrezzi_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.ribbonCategorie);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Categorie";
            // 
            // ribbonCategorie
            // 
            this.ribbonCategorie.Image = global::CashMag_Server.Properties.Resources.category_icon;
            this.ribbonCategorie.LargeImage = global::CashMag_Server.Properties.Resources.category_icon;
            this.ribbonCategorie.Name = "ribbonCategorie";
            this.ribbonCategorie.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonCategorie.SmallImage")));
            this.ribbonCategorie.Click += new System.EventHandler(this.ribbonCategorie_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.ribbonStorico);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Storico";
            // 
            // ribbonStorico
            // 
            this.ribbonStorico.Image = global::CashMag_Server.Properties.Resources.history;
            this.ribbonStorico.LargeImage = global::CashMag_Server.Properties.Resources.history;
            this.ribbonStorico.Name = "ribbonStorico";
            this.ribbonStorico.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonStorico.SmallImage")));
            this.ribbonStorico.Click += new System.EventHandler(this.ribbonStorico_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ButtonMoreVisible = false;
            this.ribbonPanel4.Items.Add(this.ribbonBell);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Chiama";
            // 
            // ribbonBell
            // 
            this.ribbonBell.Image = global::CashMag_Server.Properties.Resources.bell;
            this.ribbonBell.LargeImage = global::CashMag_Server.Properties.Resources.bell;
            this.ribbonBell.Name = "ribbonBell";
            this.ribbonBell.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonBell.SmallImage")));
            this.ribbonBell.Click += new System.EventHandler(this.ribbonBell_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ButtonMoreVisible = false;
            this.ribbonPanel5.Items.Add(this.ribbonPrint);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Stampa";
            // 
            // ribbonPrint
            // 
            this.ribbonPrint.Image = global::CashMag_Server.Properties.Resources.stamp;
            this.ribbonPrint.LargeImage = global::CashMag_Server.Properties.Resources.stamp;
            this.ribbonPrint.Name = "ribbonPrint";
            this.ribbonPrint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonPrint.SmallImage")));
            this.ribbonPrint.Click += new System.EventHandler(this.ribbonPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 421);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Cashmag - Desk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Menu_Cassa.ResumeLayout(false);
            this.Product_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox GrupTavolo;
        private System.Windows.Forms.Timer check_new_order;
        private System.Windows.Forms.TextBox Cassa_Display;
        private System.Windows.Forms.Timer load_main;
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip Product_List;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiAllaCassaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem print_btn_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListView Scontrino_Cassa;
        private System.Windows.Forms.ColumnHeader ProdottoHead;
        private System.Windows.Forms.ColumnHeader PrezzoHead;
        private System.Windows.Forms.ContextMenuStrip Menu_Cassa;
        private System.Windows.Forms.ToolStripMenuItem ripulisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaVoceToolStripMenuItem;
        private System.Windows.Forms.Label LabCassa;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonSetting;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonAbout;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonShutdown;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonExit;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonPrezzi;
        private System.Windows.Forms.RibbonButton ribbonCategorie;
        private System.Windows.Forms.RibbonButton ribbonStorico;
        private System.Windows.Forms.RibbonButton ribbonBell;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonPrint;
        private System.Windows.Forms.ToolStripMenuItem refreshDecrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

