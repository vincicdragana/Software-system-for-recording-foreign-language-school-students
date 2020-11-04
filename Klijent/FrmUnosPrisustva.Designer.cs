namespace Klijent
{
    partial class FrmUnosPrisustva
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrisustva = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiPrisustvo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustva)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(599, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Unesi prisustvo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPretraga.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Location = new System.Drawing.Point(195, 110);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.RowHeadersWidth = 51;
            this.dgvPretraga.RowTemplate.Height = 24;
            this.dgvPretraga.Size = new System.Drawing.Size(366, 328);
            this.dgvPretraga.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(191, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ucenici koji pohadjaju kurs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(-2, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datum:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(2, 36);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(174, 22);
            this.txtDatum.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(799, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prisutni su:";
            // 
            // dgvPrisustva
            // 
            this.dgvPrisustva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrisustva.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvPrisustva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisustva.Location = new System.Drawing.Point(787, 110);
            this.dgvPrisustva.Name = "dgvPrisustva";
            this.dgvPrisustva.RowHeadersWidth = 51;
            this.dgvPrisustva.RowTemplate.Height = 24;
            this.dgvPrisustva.Size = new System.Drawing.Size(256, 328);
            this.dgvPrisustva.TabIndex = 15;
            // 
            // btnIzbrisiPrisustvo
            // 
            this.btnIzbrisiPrisustvo.BackColor = System.Drawing.Color.MistyRose;
            this.btnIzbrisiPrisustvo.Font = new System.Drawing.Font("NSimSun", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIzbrisiPrisustvo.Location = new System.Drawing.Point(599, 215);
            this.btnIzbrisiPrisustvo.Name = "btnIzbrisiPrisustvo";
            this.btnIzbrisiPrisustvo.Size = new System.Drawing.Size(152, 69);
            this.btnIzbrisiPrisustvo.TabIndex = 16;
            this.btnIzbrisiPrisustvo.Text = "Izbrisi prisustvo";
            this.btnIzbrisiPrisustvo.UseVisualStyleBackColor = false;
            this.btnIzbrisiPrisustvo.Click += new System.EventHandler(this.btnIzbrisiPrisustvo_Click);
            // 
            // FrmUnosPrisustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.btnIzbrisiPrisustvo);
            this.Controls.Add(this.dgvPrisustva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnosPrisustva";
            this.Text = "FrmUnosPrisustva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPrisustva;
        private System.Windows.Forms.Button btnIzbrisiPrisustvo;
    }
}