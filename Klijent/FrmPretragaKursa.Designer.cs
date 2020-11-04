namespace Klijent
{
    partial class FrmPretragaKursa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretragaKursa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrikaziKurs = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Klijent.Properties.Resources._71504b3279467ae714a9b5e012f68052;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPrikaziKurs);
            this.panel1.Controls.Add(this.dgvKursevi);
            this.panel1.Controls.Add(this.txtPretrazi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 452);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(35, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Evidencija prisustva";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrikaziKurs
            // 
            this.btnPrikaziKurs.BackColor = System.Drawing.Color.MistyRose;
            this.btnPrikaziKurs.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPrikaziKurs.Location = new System.Drawing.Point(318, 386);
            this.btnPrikaziKurs.Name = "btnPrikaziKurs";
            this.btnPrikaziKurs.Size = new System.Drawing.Size(175, 53);
            this.btnPrikaziKurs.TabIndex = 4;
            this.btnPrikaziKurs.Text = "Prikazi kurs";
            this.btnPrikaziKurs.UseVisualStyleBackColor = false;
            this.btnPrikaziKurs.Click += new System.EventHandler(this.btnPrikaziKurs_Click);
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKursevi.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(34, 129);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.RowHeadersWidth = 51;
            this.dgvKursevi.RowTemplate.Height = 24;
            this.dgvKursevi.Size = new System.Drawing.Size(726, 231);
            this.dgvKursevi.TabIndex = 2;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(273, 58);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(422, 22);
            this.txtPretrazi.TabIndex = 1;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            this.txtPretrazi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPretrazi_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga kurseva:";
            // 
            // FrmPretragaKursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPretragaKursa";
            this.Text = "FrmPretragaKursa";
            this.Load += new System.EventHandler(this.FrmPretragaKursa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrikaziKurs;
        private System.Windows.Forms.DataGridView dgvKursevi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}