namespace Klijent
{
    partial class FrmPrikazPohadjanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrikazPohadjanja));
            this.lblUcenik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvPohadjanja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPohadjanja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUcenik
            // 
            this.lblUcenik.AutoSize = true;
            this.lblUcenik.BackColor = System.Drawing.Color.MistyRose;
            this.lblUcenik.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUcenik.Location = new System.Drawing.Point(172, 17);
            this.lblUcenik.Name = "lblUcenik";
            this.lblUcenik.Size = new System.Drawing.Size(152, 20);
            this.lblUcenik.TabIndex = 7;
            this.lblUcenik.Text = "ime i prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ucenik: ";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisi.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnObrisi.Location = new System.Drawing.Point(240, 350);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(205, 45);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dgvPohadjanja
            // 
            this.dgvPohadjanja.AllowUserToAddRows = false;
            this.dgvPohadjanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPohadjanja.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvPohadjanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPohadjanja.Location = new System.Drawing.Point(12, 60);
            this.dgvPohadjanja.Name = "dgvPohadjanja";
            this.dgvPohadjanja.RowTemplate.Height = 24;
            this.dgvPohadjanja.Size = new System.Drawing.Size(640, 274);
            this.dgvPohadjanja.TabIndex = 4;
            // 
            // FrmPrikazPohadjanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources._71504b3279467ae714a9b5e012f68052;
            this.ClientSize = new System.Drawing.Size(665, 410);
            this.Controls.Add(this.lblUcenik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvPohadjanja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrikazPohadjanja";
            this.Text = "FrmPrikazPohadjanja";
            this.Load += new System.EventHandler(this.FrmPrikazPohadjanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPohadjanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUcenik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvPohadjanja;
    }
}