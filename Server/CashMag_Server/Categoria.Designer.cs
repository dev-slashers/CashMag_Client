namespace CashMag_Server
{
    partial class Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.CategoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.Category_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryList
            // 
            this.CategoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.CategoryList.ContextMenuStrip = this.Category_menu;
            this.CategoryList.FullRowSelect = true;
            this.CategoryList.GridLines = true;
            this.CategoryList.Location = new System.Drawing.Point(0, 20);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(316, 429);
            this.CategoryList.TabIndex = 4;
            this.CategoryList.UseCompatibleStateImageBehavior = false;
            this.CategoryList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Categoria";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Indice";
            this.columnHeader4.Width = 0;
            // 
            // Category_menu
            // 
            this.Category_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.chiudiToolStripMenuItem});
            this.Category_menu.Name = "Category_menu";
            this.Category_menu.Size = new System.Drawing.Size(114, 54);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 6);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(159, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(159, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "Cerca. . .";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(0, 0);
            this.AddBox.MaxLength = 40;
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(159, 20);
            this.AddBox.TabIndex = 7;
            this.AddBox.Text = "Aggiungi . . .";
            this.AddBox.Click += new System.EventHandler(this.AddBox_Click);
            this.AddBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddBox_KeyDown);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.CategoryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Categoria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.Category_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CategoryList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ContextMenuStrip Category_menu;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
    }
}