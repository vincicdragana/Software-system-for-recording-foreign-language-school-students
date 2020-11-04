using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmPretragaKursa : Form
    {
        public FrmPretragaKursa()
        {
            InitializeComponent();
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziKurseve(txtPretrazi, dgvKursevi);
        }

        private void txtPretrazi_KeyDown(object sender, KeyEventArgs e)
        {
            KontrolerKI.PretraziKurseve(txtPretrazi, dgvKursevi);
        }

        private void FrmPretragaKursa_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziKurseve(txtPretrazi, dgvKursevi);
        }

        private void btnPrikaziKurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosKursa(dgvKursevi.CurrentRow.DataBoundItem).ShowDialog();
            this.Show();

            KontrolerKI.PretraziKurseve(txtPretrazi, dgvKursevi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(KontrolerKI.DaLiPostojeTerminiZaKurs(dgvKursevi) == true)
            {
                this.Hide();
                new FrmEvidencijaPrisustva(dgvKursevi).ShowDialog();
                this.Show();

                KontrolerKI.PretraziKurseve(txtPretrazi, dgvKursevi);
            }
            else
            {
                MessageBox.Show("Ne postoje termini za izabrani kurs!");
            }
        }
    }
}
