namespace CashMag_Server
{
    partial class Prezzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prezzi));
            this.OptionSearch = new System.Windows.Forms.ComboBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_List = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionSearch
            // 
            this.OptionSearch.FormattingEnabled = true;
            this.OptionSearch.Location = new System.Drawing.Point(380, 2);
            this.OptionSearch.Name = "OptionSearch";
            this.OptionSearch.Size = new System.Drawing.Size(228, 21);
            this.OptionSearch.TabIndex = 5;
            this.OptionSearch.SelectedIndexChanged += new System.EventHandler(this.OptionSearch_SelectedIndexChanged);
            this.OptionSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionSearch_KeyDown);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(0, 2);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(380, 20);
            this.SearchText.TabIndex = 4;
            this.SearchText.Text = "Cerca...";
            this.SearchText.Click += new System.EventHandler(this.SearchText_Click);
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.ProductList.ContextMenuStrip = this.Menu_List;
            this.ProductList.FullRowSelect = true;
            this.ProductList.GridLines = true;
            this.ProductList.Location = new System.Drawing.Point(0, 24);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(614, 631);
            this.ProductList.TabIndex = 3;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            this.ProductList.DoubleClick += new System.EventHandler(this.ProductList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezzo";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Disponibilità";
            this.columnHeader5.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Indice";
            this.columnHeader4.Width = 0;
            // 
            // Menu_List
            // 
            this.Menu_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.eliminaToolStripMenuItem});
            this.Menu_List.Name = "contextMenuStrip1";
            this.Menu_List.Size = new System.Drawing.Size(124, 76);
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aggiungiToolStripMenuItem.Text = "Aggiungi";
            this.aggiungiToolStripMenuItem.Click += new System.EventHandler(this.aggiungiToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // Prezzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 658);
            this.Controls.Add(this.OptionSearch);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prezzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prezzi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Prezzi_Load);
            this.Menu_List.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptionSearch;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip Menu_List;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
    }
}