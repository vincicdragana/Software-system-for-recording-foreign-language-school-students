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
    public partial class FrmGlavnaForma : Form
    {
        public FrmGlavnaForma()
        {
            InitializeComponent();
        }

        private void FrmGlavnaForma_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = KontrolerKI.PrikaziUlogovanogRadnika();
        }
        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.Kraj();
        }

        private void unosUcenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosUcenika().ShowDialog();
            this.Show();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPretragaUcenika().ShowDialog();
            this.Show();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosNivoa().ShowDialog();
            this.Show();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosKursa().ShowDialog();
            this.Show();
        }

        private void izmenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPretragaKursa().ShowDialog();
            this.Show();
        }


    }
}
