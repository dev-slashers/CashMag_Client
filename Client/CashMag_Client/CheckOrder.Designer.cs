﻿namespace CashMag_Client
{
    partial class CheckOrder
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuantList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(216, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancella";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // QuantList
            // 
            this.QuantList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantList.FormattingEnabled = true;
            this.QuantList.Location = new System.Drawing.Point(94, 44);
            this.QuantList.Name = "QuantList";
            this.QuantList.Size = new System.Drawing.Size(185, 37);
            this.QuantList.TabIndex = 6;
            this.QuantList.Text = "1";
            this.QuantList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantList_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.SubButton);
            this.groupBox1.Controls.Add(this.QuantList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantità";
            // 
            // SubButton
            // 
            this.SubButton.ForeColor = System.Drawing.Color.Red;
            this.SubButton.Location = new System.Drawing.Point(302, 44);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(61, 39);
            this.SubButton.TabIndex = 7;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.Color.Green;
            this.AddButton.Location = new System.Drawing.Point(6, 44);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(61, 39);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CheckOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(394, 193);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi Ordine";
            this.Load += new System.EventHandler(this.CheckOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox QuantList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
    }
}