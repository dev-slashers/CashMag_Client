namespace CashMag_Server
{
    partial class History
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.Storico_Lista = new System.Windows.Forms.ListView();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ordinazioni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Totale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edit_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaStoricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Riepilogo_Text = new System.Windows.Forms.ToolStripTextBox();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.PrintHistory = new System.Drawing.Printing.PrintDocument();
            this.Edit_Menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Storico_Lista
            // 
            this.Storico_Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Ordinazioni,
            this.Totale,
            this.ID});
            this.Storico_Lista.ContextMenuStrip = this.Edit_Menu;
            this.Storico_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Storico_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Storico_Lista.FullRowSelect = true;
            this.Storico_Lista.GridLines = true;
            this.Storico_Lista.Location = new System.Drawing.Point(0, 0);
            this.Storico_Lista.Name = "Storico_Lista";
            this.Storico_Lista.Size = new System.Drawing.Size(1195, 493);
            this.Storico_Lista.TabIndex = 4;
            this.Storico_Lista.UseCompatibleStateImageBehavior = false;
            this.Storico_Lista.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 150;
            // 
            // Ordinazioni
            // 
            this.Ordinazioni.Text = "Ordinazioni";
            this.Ordinazioni.Width = 800;
            // 
            // Totale
            // 
            this.Totale.Text = "Totale";
            this.Totale.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "";
            this.ID.Width = 0;
            // 
            // Edit_Menu
            // 
            this.Edit_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stampaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.eliminaStoricoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.esciToolStripMenuItem});
            this.Edit_Menu.Name = "Edit_Menu";
            this.Edit_Menu.Size = new System.Drawing.Size(153, 98);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stampaToolStripMenuItem.Text = "Stampa";
            this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificaToolStripMenuItem.Text = "Elimina";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // eliminaStoricoToolStripMenuItem
            // 
            this.eliminaStoricoToolStripMenuItem.Name = "eliminaStoricoToolStripMenuItem";
            this.eliminaStoricoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminaStoricoToolStripMenuItem.Text = "Elimina storico";
            this.eliminaStoricoToolStripMenuItem.Click += new System.EventHandler(this.eliminaStoricoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Riepilogo_Text,
            this.txt_search});
            this.menuStrip1.Location = new System.Drawing.Point(0, 493);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 64);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Riepilogo_Text
            // 
            this.Riepilogo_Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Riepilogo_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Riepilogo_Text.Enabled = false;
            this.Riepilogo_Text.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Riepilogo_Text.Name = "Riepilogo_Text";
            this.Riepilogo_Text.Size = new System.Drawing.Size(800, 60);
            this.Riepilogo_Text.Text = "Data | Totale Incasso";
            // 
            // txt_search
            // 
            this.txt_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(200, 60);
            this.txt_search.Text = "Cerca Data";
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // PrintHistory
            // 
            this.PrintHistory.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintHistory_PrintPage);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1195, 557);
            this.Controls.Add(this.Storico_Lista);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storico";
            this.Load += new System.EventHandler(this.History_Load);
            this.Edit_Menu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Storico_Lista;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Ordinazioni;
        private System.Windows.Forms.ColumnHeader Totale;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox Riepilogo_Text;
        private System.Windows.Forms.ContextMenuStrip Edit_Menu;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument PrintHistory;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaStoricoToolStripMenuItem;
    }
}