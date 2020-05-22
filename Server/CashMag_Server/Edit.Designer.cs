namespace CashMag_Server
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.Nome_Text = new System.Windows.Forms.TextBox();
            this.Costo_Text = new System.Windows.Forms.TextBox();
            this.categoria_combo = new System.Windows.Forms.ComboBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disp_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome_Text
            // 
            this.Nome_Text.Location = new System.Drawing.Point(135, 10);
            this.Nome_Text.MaxLength = 29;
            this.Nome_Text.Name = "Nome_Text";
            this.Nome_Text.Size = new System.Drawing.Size(321, 20);
            this.Nome_Text.TabIndex = 0;
            // 
            // Costo_Text
            // 
            this.Costo_Text.Location = new System.Drawing.Point(135, 40);
            this.Costo_Text.Name = "Costo_Text";
            this.Costo_Text.Size = new System.Drawing.Size(321, 20);
            this.Costo_Text.TabIndex = 1;
            this.Costo_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Costo_Text_KeyDown);
            // 
            // categoria_combo
            // 
            this.categoria_combo.FormattingEnabled = true;
            this.categoria_combo.Location = new System.Drawing.Point(135, 70);
            this.categoria_combo.Name = "categoria_combo";
            this.categoria_combo.Size = new System.Drawing.Size(321, 21);
            this.categoria_combo.TabIndex = 2;
            this.categoria_combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoria_combo_KeyDown);
            // 
            // Enter_button
            // 
            this.Enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_button.Location = new System.Drawing.Point(135, 127);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(321, 33);
            this.Enter_button.TabIndex = 4;
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome / Descrizione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Costo al Pubblico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria Prodotto:";
            // 
            // disp_combo
            // 
            this.disp_combo.FormattingEnabled = true;
            this.disp_combo.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.disp_combo.Location = new System.Drawing.Point(135, 100);
            this.disp_combo.Name = "disp_combo";
            this.disp_combo.Size = new System.Drawing.Size(321, 21);
            this.disp_combo.TabIndex = 8;
            this.disp_combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disp_combo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Attualmente Disponibile:";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 166);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disp_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.categoria_combo);
            this.Controls.Add(this.Costo_Text);
            this.Controls.Add(this.Nome_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Prodotto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome_Text;
        private System.Windows.Forms.TextBox Costo_Text;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox disp_combo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox categoria_combo;
    }
}