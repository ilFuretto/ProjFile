﻿namespace fileColombo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            aggiungi_btn = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            modifica_btn = new Button();
            elimina_btn = new Button();
            cercaRiga_btn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(408, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 121);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(226, 121);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 4;
            label2.Text = "COGNOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(431, 121);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 5;
            label3.Text = "NOME";
            // 
            // aggiungi_btn
            // 
            aggiungi_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            aggiungi_btn.Location = new Point(549, 121);
            aggiungi_btn.Name = "aggiungi_btn";
            aggiungi_btn.Size = new Size(107, 54);
            aggiungi_btn.TabIndex = 6;
            aggiungi_btn.Text = "AGGIUNGI";
            aggiungi_btn.UseVisualStyleBackColor = true;
            aggiungi_btn.Click += aggiungi_btn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(38, 208);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(493, 199);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(681, 121);
            button1.Name = "button1";
            button1.Size = new Size(107, 54);
            button1.TabIndex = 8;
            button1.Text = "CERCA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cerca_btn_Click;
            // 
            // modifica_btn
            // 
            modifica_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            modifica_btn.Location = new Point(549, 196);
            modifica_btn.Name = "modifica_btn";
            modifica_btn.Size = new Size(107, 54);
            modifica_btn.TabIndex = 9;
            modifica_btn.Text = "MODIFICA";
            modifica_btn.UseVisualStyleBackColor = true;
            modifica_btn.Click += modifica_btn_Click;
            // 
            // elimina_btn
            // 
            elimina_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            elimina_btn.Location = new Point(681, 196);
            elimina_btn.Name = "elimina_btn";
            elimina_btn.Size = new Size(107, 54);
            elimina_btn.TabIndex = 10;
            elimina_btn.Text = "ELIMINA";
            elimina_btn.UseVisualStyleBackColor = true;
            elimina_btn.Click += elimina_btn_Click;
            // 
            // cercaRiga_btn
            // 
            cercaRiga_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cercaRiga_btn.Location = new Point(618, 267);
            cercaRiga_btn.Name = "cercaRiga_btn";
            cercaRiga_btn.Size = new Size(107, 54);
            cercaRiga_btn.TabIndex = 11;
            cercaRiga_btn.Text = "CERCA RIGA";
            cercaRiga_btn.UseVisualStyleBackColor = true;
            cercaRiga_btn.Click += cercaRiga_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cercaRiga_btn);
            Controls.Add(elimina_btn);
            Controls.Add(modifica_btn);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(aggiungi_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button aggiungi_btn;
        private ListBox listBox1;
        private Button button1;
        private Button modifica_btn;
        private Button elimina_btn;
        private Button cercaRiga_btn;
    }
}
