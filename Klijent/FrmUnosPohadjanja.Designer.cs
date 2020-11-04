namespace Klijent
{
    partial class FrmUnosPohadjanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosPohadjanja));
            this.gbPohadjanje = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblGreska = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatumUpisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUcenik = new System.Windows.Forms.Label();
            this.btnUnesiPohadjanje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IDPohadjanje = new System.Windows.Forms.Label();
            this.btnKreirajPohadjanje = new System.Windows.Forms.Button();
            this.gbPohadjanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPohadjanje
            // 
            this.gbPohadjanje.BackColor = System.Drawing.Color.MistyRose;
            this.gbPohadjanje.Controls.Add(this.lblDatum);
            this.gbPohadjanje.Controls.Add(this.lblGreska);
            this.gbPohadjanje.Controls.Add(this.label1);
            this.gbPohadjanje.Controls.Add(this.txtDatumUpisa);
            this.gbPohadjanje.Controls.Add(this.label2);
            this.gbPohadjanje.Controls.Add(this.cmbKurs);
            this.gbPohadjanje.Location = new System.Drawing.Point(12, 172);
            this.gbPohadjanje.Name = "gbPohadjanje";
            this.gbPohadjanje.Size = new System.Drawing.Size(358, 175);
            this.gbPohadjanje.TabIndex = 0;
            this.gbPohadjanje.TabStop = false;
            this.gbPohadjanje.Text = "Detalji pohadjanja";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(123, 98);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(153, 17);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "datum izabranog kursa";
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Location = new System.Drawing.Point(133, -20);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(0, 17);
            this.lblGreska.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datum upisa";
            // 
            // txtDatumUpisa
            // 
            this.txtDatumUpisa.Location = new System.Drawing.Point(126, 140);
            this.txtDatumUpisa.Name = "txtDatumUpisa";
            this.txtDatumUpisa.Size = new System.Drawing.Size(151, 22);
            this.txtDatumUpisa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv kursa";
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(126, 57);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(151, 24);
            this.cmbKurs.TabIndex = 11;
            this.cmbKurs.SelectedIndexChanged += new System.EventHandler(this.cmbKurs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ucenik";
            // 
            // lblUcenik
            // 
            this.lblUcenik.AutoSize = true;
            this.lblUcenik.BackColor = System.Drawing.Color.MistyRose;
            this.lblUcenik.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUcenik.Location = new System.Drawing.Point(129, 38);
            this.lblUcenik.Name = "lblUcenik";
            this.lblUcenik.Size = new System.Drawing.Size(240, 20);
            this.lblUcenik.TabIndex = 13;
            this.lblUcenik.Text = "ime i prezime ucenika";
            // 
            // btnUnesiPohadjanje
            // 
            this.btnUnesiPohadjanje.BackColor = System.Drawing.Color.MistyRose;
            this.btnUnesiPohadjanje.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUnesiPohadjanje.Location = new System.Drawing.Point(108, 361);
            this.btnUnesiPohadjanje.Name = "btnUnesiPohadjanje";
            this.btnUnesiPohadjanje.Size = new System.Drawing.Size(162, 58);
            this.btnUnesiPohadjanje.TabIndex = 12;
            this.btnUnesiPohadjanje.Text = "Sacuvaj pohadjanje";
            this.btnUnesiPohadjanje.UseVisualStyleBackColor = false;
            this.btnUnesiPohadjanje.Click += new System.EventHandler(this.btnUnesiPohadjanje_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "IDPohadjanje";
            // 
            // IDPohadjanje
            // 
            this.IDPohadjanje.AutoSize = true;
            this.IDPohadjanje.BackColor = System.Drawing.Color.MistyRose;
            this.IDPohadjanje.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.IDPohadjanje.Location = new System.Drawing.Point(177, 108);
            this.IDPohadjanje.Name = "IDPohadjanje";
            this.IDPohadjanje.Size = new System.Drawing.Size(20, 20);
            this.IDPohadjanje.TabIndex = 15;
            this.IDPohadjanje.Text = "/";
            // 
            // btnKreirajPohadjanje
            // 
            this.btnKreirajPohadjanje.BackColor = System.Drawing.Color.MistyRose;
            this.btnKreirajPohadjanje.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKreirajPohadjanje.Location = new System.Drawing.Point(235, 73);
            this.btnKreirajPohadjanje.Name = "btnKreirajPohadjanje";
            this.btnKreirajPohadjanje.Size = new System.Drawing.Size(135, 83);
            this.btnKreirajPohadjanje.TabIndex = 17;
            this.btnKreirajPohadjanje.Text = "Kreiraj pohadjanje";
            this.btnKreirajPohadjanje.UseVisualStyleBackColor = false;
            this.btnKreirajPohadjanje.Click += new System.EventHandler(this.btnKreirajPohadjanje_Click);
            // 
            // FrmUnosPohadjanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources._71504b3279467ae714a9b5e012f68052;
            this.ClientSize = new System.Drawing.Size(391, 431);
            this.Controls.Add(this.btnKreirajPohadjanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDPohadjanje);
            this.Controls.Add(this.gbPohadjanje);
            this.Controls.Add(this.btnUnesiPohadjanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUcenik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosPohadjanja";
            this.Text = "FrmUnosPohadjanja";
            this.Load += new System.EventHandler(this.FrmUnosPohadjanja_Load);
            this.gbPohadjanje.ResumeLayout(false);
            this.gbPohadjanje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPohadjanje;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumUpisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUcenik;
        private System.Windows.Forms.Button btnUnesiPohadjanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IDPohadjanje;
        private System.Windows.Forms.Button btnKreirajPohadjanje;
        private System.Windows.Forms.Label lblDatum;
    }
}