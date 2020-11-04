namespace Klijent
{
    partial class FrmUnosUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosUcenika));
            this.label9 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtIDUcenik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUcenik = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreirajUcenika = new System.Windows.Forms.Button();
            this.gbUcenik.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "(dd.MM.yyyy)";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.MistyRose;
            this.btnSacuvaj.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSacuvaj.Location = new System.Drawing.Point(132, 387);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 42);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(160, 232);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(121, 22);
            this.txtAdresa.TabIndex = 13;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(160, 191);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(121, 22);
            this.txtBrojTelefona.TabIndex = 12;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(160, 150);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(121, 22);
            this.txtDatumRodjenja.TabIndex = 11;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(160, 108);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(121, 22);
            this.txtJMBG.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(160, 70);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(121, 22);
            this.txtPrezime.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(160, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(121, 22);
            this.txtIme.TabIndex = 8;
            // 
            // txtIDUcenik
            // 
            this.txtIDUcenik.Location = new System.Drawing.Point(163, 12);
            this.txtIDUcenik.Name = "txtIDUcenik";
            this.txtIDUcenik.ReadOnly = true;
            this.txtIDUcenik.Size = new System.Drawing.Size(121, 22);
            this.txtIDUcenik.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Broj telefona:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID učenik:";
            // 
            // gbUcenik
            // 
            this.gbUcenik.BackColor = System.Drawing.Color.MistyRose;
            this.gbUcenik.Controls.Add(this.label2);
            this.gbUcenik.Controls.Add(this.label9);
            this.gbUcenik.Controls.Add(this.txtJMBG);
            this.gbUcenik.Controls.Add(this.txtAdresa);
            this.gbUcenik.Controls.Add(this.label7);
            this.gbUcenik.Controls.Add(this.label4);
            this.gbUcenik.Controls.Add(this.txtIme);
            this.gbUcenik.Controls.Add(this.label5);
            this.gbUcenik.Controls.Add(this.txtBrojTelefona);
            this.gbUcenik.Controls.Add(this.label6);
            this.gbUcenik.Controls.Add(this.txtDatumRodjenja);
            this.gbUcenik.Controls.Add(this.txtPrezime);
            this.gbUcenik.Controls.Add(this.label3);
            this.gbUcenik.Location = new System.Drawing.Point(3, 56);
            this.gbUcenik.Name = "gbUcenik";
            this.gbUcenik.Size = new System.Drawing.Size(401, 297);
            this.gbUcenik.TabIndex = 20;
            this.gbUcenik.TabStop = false;
            this.gbUcenik.Text = "Detalji ucenika";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Klijent.Properties.Resources._71504b3279467ae714a9b5e012f68052;
            this.panel1.Controls.Add(this.btnIzmeni);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.btnKreirajUcenika);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.gbUcenik);
            this.panel1.Controls.Add(this.txtIDUcenik);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 523);
            this.panel1.TabIndex = 21;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.MistyRose;
            this.btnIzmeni.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIzmeni.Location = new System.Drawing.Point(22, 447);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(178, 42);
            this.btnIzmeni.TabIndex = 23;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisi.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnObrisi.Location = new System.Drawing.Point(250, 447);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(178, 42);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKreirajUcenika
            // 
            this.btnKreirajUcenika.BackColor = System.Drawing.Color.MistyRose;
            this.btnKreirajUcenika.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKreirajUcenika.Location = new System.Drawing.Point(307, 3);
            this.btnKreirajUcenika.Name = "btnKreirajUcenika";
            this.btnKreirajUcenika.Size = new System.Drawing.Size(144, 41);
            this.btnKreirajUcenika.TabIndex = 21;
            this.btnKreirajUcenika.Text = "Kreiraj ucenika";
            this.btnKreirajUcenika.UseVisualStyleBackColor = false;
            this.btnKreirajUcenika.Click += new System.EventHandler(this.btnKreirajUcenika_Click);
            // 
            // FrmUnosUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 498);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosUcenika";
            this.Text = "FrmUnosUcenika";
            this.gbUcenik.ResumeLayout(false);
            this.gbUcenik.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtIDUcenik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUcenik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreirajUcenika;
    }
}