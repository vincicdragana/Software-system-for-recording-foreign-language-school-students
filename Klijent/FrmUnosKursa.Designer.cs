namespace Klijent
{
    partial class FrmUnosKursa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosKursa));
            this.gbKlijent = new System.Windows.Forms.GroupBox();
            this.cmbNivo = new System.Windows.Forms.ComboBox();
            this.lblnivo = new System.Windows.Forms.Label();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNE = new System.Windows.Forms.RadioButton();
            this.rbDA = new System.Windows.Forms.RadioButton();
            this.btnSacuvajKurs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTermini = new System.Windows.Forms.GroupBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.txtDatumTermin = new System.Windows.Forms.TextBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifraKursa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKreirajKurs = new System.Windows.Forms.Button();
            this.panelAktivan = new System.Windows.Forms.Panel();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.gbKlijent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbTermini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.panelAktivan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKlijent
            // 
            this.gbKlijent.BackColor = System.Drawing.Color.MistyRose;
            this.gbKlijent.Controls.Add(this.cmbNivo);
            this.gbKlijent.Controls.Add(this.cmbProfesor);
            this.gbKlijent.Controls.Add(this.lblnivo);
            this.gbKlijent.Controls.Add(this.txtDatumDo);
            this.gbKlijent.Controls.Add(this.label5);
            this.gbKlijent.Controls.Add(this.txtDatumOd);
            this.gbKlijent.Controls.Add(this.txtNaziv);
            this.gbKlijent.Controls.Add(this.label2);
            this.gbKlijent.Controls.Add(this.label1);
            this.gbKlijent.Controls.Add(this.lblNaziv);
            this.gbKlijent.Enabled = false;
            this.gbKlijent.Location = new System.Drawing.Point(12, 83);
            this.gbKlijent.Name = "gbKlijent";
            this.gbKlijent.Size = new System.Drawing.Size(371, 389);
            this.gbKlijent.TabIndex = 0;
            this.gbKlijent.TabStop = false;
            this.gbKlijent.Text = "Detalji kursa";
            // 
            // cmbNivo
            // 
            this.cmbNivo.FormattingEnabled = true;
            this.cmbNivo.Location = new System.Drawing.Point(151, 51);
            this.cmbNivo.Name = "cmbNivo";
            this.cmbNivo.Size = new System.Drawing.Size(145, 24);
            this.cmbNivo.TabIndex = 43;
            // 
            // lblnivo
            // 
            this.lblnivo.AutoSize = true;
            this.lblnivo.Location = new System.Drawing.Point(17, 54);
            this.lblnivo.Name = "lblnivo";
            this.lblnivo.Size = new System.Drawing.Size(36, 17);
            this.lblnivo.TabIndex = 42;
            this.lblnivo.Text = "Nivo";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Location = new System.Drawing.Point(152, 302);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.Size = new System.Drawing.Size(145, 22);
            this.txtDatumDo.TabIndex = 41;
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(151, 236);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(145, 22);
            this.txtDatumOd.TabIndex = 40;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(151, 111);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(145, 22);
            this.txtNaziv.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Datum zavrsetka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Datum pocetka";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(17, 116);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 32;
            this.lblNaziv.Text = "Naziv";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNE);
            this.groupBox2.Controls.Add(this.rbDA);
            this.groupBox2.Location = new System.Drawing.Point(135, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 44);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // rbNE
            // 
            this.rbNE.AutoSize = true;
            this.rbNE.Checked = true;
            this.rbNE.Location = new System.Drawing.Point(137, 15);
            this.rbNE.Name = "rbNE";
            this.rbNE.Size = new System.Drawing.Size(48, 21);
            this.rbNE.TabIndex = 5;
            this.rbNE.TabStop = true;
            this.rbNE.Text = "NE";
            this.rbNE.UseVisualStyleBackColor = true;
            // 
            // rbDA
            // 
            this.rbDA.AutoSize = true;
            this.rbDA.Location = new System.Drawing.Point(30, 15);
            this.rbDA.Name = "rbDA";
            this.rbDA.Size = new System.Drawing.Size(48, 21);
            this.rbDA.TabIndex = 4;
            this.rbDA.Text = "DA";
            this.rbDA.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajKurs
            // 
            this.btnSacuvajKurs.BackColor = System.Drawing.Color.MistyRose;
            this.btnSacuvajKurs.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSacuvajKurs.Location = new System.Drawing.Point(12, 492);
            this.btnSacuvajKurs.Name = "btnSacuvajKurs";
            this.btnSacuvajKurs.Size = new System.Drawing.Size(151, 95);
            this.btnSacuvajKurs.TabIndex = 38;
            this.btnSacuvajKurs.Text = "Sacuvaj kurs";
            this.btnSacuvajKurs.UseVisualStyleBackColor = false;
            this.btnSacuvajKurs.Click += new System.EventHandler(this.btnSacuvajKurs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Aktivan";
            // 
            // gbTermini
            // 
            this.gbTermini.BackColor = System.Drawing.Color.MistyRose;
            this.gbTermini.Controls.Add(this.btnIzbrisi);
            this.gbTermini.Controls.Add(this.txtDatumTermin);
            this.gbTermini.Controls.Add(this.dgvTermini);
            this.gbTermini.Controls.Add(this.btnDodajTermin);
            this.gbTermini.Controls.Add(this.label4);
            this.gbTermini.Location = new System.Drawing.Point(407, 83);
            this.gbTermini.Name = "gbTermini";
            this.gbTermini.Size = new System.Drawing.Size(625, 389);
            this.gbTermini.TabIndex = 36;
            this.gbTermini.TabStop = false;
            this.gbTermini.Text = "Termin";
            this.gbTermini.Enter += new System.EventHandler(this.gbTermini_Enter);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIzbrisi.Location = new System.Drawing.Point(458, 207);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(129, 61);
            this.btnIzbrisi.TabIndex = 16;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(151, 171);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(145, 24);
            this.cmbProfesor.TabIndex = 15;
            // 
            // txtDatumTermin
            // 
            this.txtDatumTermin.Location = new System.Drawing.Point(145, 62);
            this.txtDatumTermin.Name = "txtDatumTermin";
            this.txtDatumTermin.Size = new System.Drawing.Size(145, 22);
            this.txtDatumTermin.TabIndex = 14;
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(12, 116);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(364, 244);
            this.dgvTermini.TabIndex = 13;
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDodajTermin.Location = new System.Drawing.Point(458, 116);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(129, 61);
            this.btnDodajTermin.TabIndex = 12;
            this.btnDodajTermin.Text = "Dodaj";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum";
            // 
            // txtSifraKursa
            // 
            this.txtSifraKursa.Location = new System.Drawing.Point(180, 25);
            this.txtSifraKursa.Name = "txtSifraKursa";
            this.txtSifraKursa.ReadOnly = true;
            this.txtSifraKursa.Size = new System.Drawing.Size(145, 22);
            this.txtSifraKursa.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sifra kursa:";
            // 
            // btnKreirajKurs
            // 
            this.btnKreirajKurs.BackColor = System.Drawing.Color.MistyRose;
            this.btnKreirajKurs.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKreirajKurs.Location = new System.Drawing.Point(331, 15);
            this.btnKreirajKurs.Name = "btnKreirajKurs";
            this.btnKreirajKurs.Size = new System.Drawing.Size(149, 44);
            this.btnKreirajKurs.TabIndex = 17;
            this.btnKreirajKurs.Text = "Kreiraj kurs";
            this.btnKreirajKurs.UseVisualStyleBackColor = false;
            this.btnKreirajKurs.Click += new System.EventHandler(this.btnKreirajKurs_Click);
            // 
            // panelAktivan
            // 
            this.panelAktivan.BackColor = System.Drawing.Color.MistyRose;
            this.panelAktivan.Controls.Add(this.label3);
            this.panelAktivan.Controls.Add(this.groupBox2);
            this.panelAktivan.Location = new System.Drawing.Point(569, 12);
            this.panelAktivan.Name = "panelAktivan";
            this.panelAktivan.Size = new System.Drawing.Size(371, 65);
            this.panelAktivan.TabIndex = 40;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.MistyRose;
            this.btnIzmeni.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIzmeni.Location = new System.Drawing.Point(213, 492);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(151, 95);
            this.btnIzmeni.TabIndex = 41;
            this.btnIzmeni.Text = "Izmeni kurs";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // FrmUnosKursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources._71504b3279467ae714a9b5e012f68052;
            this.ClientSize = new System.Drawing.Size(1044, 599);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.panelAktivan);
            this.Controls.Add(this.btnKreirajKurs);
            this.Controls.Add(this.txtSifraKursa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvajKurs);
            this.Controls.Add(this.gbTermini);
            this.Controls.Add(this.gbKlijent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosKursa";
            this.Text = "FrmUnosKursa";
            this.gbKlijent.ResumeLayout(false);
            this.gbKlijent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbTermini.ResumeLayout(false);
            this.gbTermini.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.panelAktivan.ResumeLayout(false);
            this.panelAktivan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKlijent;
        private System.Windows.Forms.ComboBox cmbNivo;
        private System.Windows.Forms.Label lblnivo;
        private System.Windows.Forms.TextBox txtDatumDo;
        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNE;
        private System.Windows.Forms.RadioButton rbDA;
        private System.Windows.Forms.Button btnSacuvajKurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.GroupBox gbTermini;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.TextBox txtDatumTermin;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtSifraKursa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKreirajKurs;
        private System.Windows.Forms.Panel panelAktivan;
        private System.Windows.Forms.Button btnIzmeni;
    }
}