namespace Klijent
{
    partial class FrmUnosNivoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosNivoa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbJezik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDNivo = new System.Windows.Forms.TextBox();
            this.btnKreirajNivo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.cmbJezik);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 266);
            this.panel1.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSacuvaj.Location = new System.Drawing.Point(47, 187);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(287, 59);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbJezik
            // 
            this.cmbJezik.FormattingEnabled = true;
            this.cmbJezik.Location = new System.Drawing.Point(129, 34);
            this.cmbJezik.Name = "cmbJezik";
            this.cmbJezik.Size = new System.Drawing.Size(121, 24);
            this.cmbJezik.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jezik";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(129, 107);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 22);
            this.txtNaziv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "IDNivo";
            // 
            // IDNivo
            // 
            this.IDNivo.Location = new System.Drawing.Point(141, 28);
            this.IDNivo.Name = "IDNivo";
            this.IDNivo.ReadOnly = true;
            this.IDNivo.Size = new System.Drawing.Size(100, 22);
            this.IDNivo.TabIndex = 10;
            // 
            // btnKreirajNivo
            // 
            this.btnKreirajNivo.BackColor = System.Drawing.Color.MistyRose;
            this.btnKreirajNivo.Location = new System.Drawing.Point(280, 23);
            this.btnKreirajNivo.Name = "btnKreirajNivo";
            this.btnKreirajNivo.Size = new System.Drawing.Size(134, 36);
            this.btnKreirajNivo.TabIndex = 7;
            this.btnKreirajNivo.Text = "Kreiraj nivo";
            this.btnKreirajNivo.UseVisualStyleBackColor = false;
            this.btnKreirajNivo.Click += new System.EventHandler(this.btnKreirajNivo_Click);
            // 
            // FrmUnosNivoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources._71504b3279467ae714a9b5e012f68052;
            this.ClientSize = new System.Drawing.Size(457, 379);
            this.Controls.Add(this.btnKreirajNivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDNivo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosNivoa";
            this.Text = "FrmUnosNivoa";
            this.Load += new System.EventHandler(this.FrmUnosNivoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbJezik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDNivo;
        private System.Windows.Forms.Button btnKreirajNivo;
    }
}