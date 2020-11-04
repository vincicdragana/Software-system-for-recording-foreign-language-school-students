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
    public partial class FrmPretragaUcenika : Form
    {
        public FrmPretragaUcenika()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPretragaUcenika_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziUcenike(txtPretrazi, dgvPretraga);
        }

        private void txtPretrazi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KontrolerKI.PretraziUcenike(txtPretrazi, dgvPretraga);
            }
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziUcenike(txtPretrazi, dgvPretraga);
        }

        private void btnPrikaziUcenika_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.PrikaziIzabranogUcenika(dgvPretraga))
            {
                this.Hide();
                new FrmUnosUcenika(dgvPretraga).ShowDialog();
                this.Show();

                // osvezavanje
                KontrolerKI.PretraziUcenike(txtPretrazi, dgvPretraga);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosPohadjanja(dgvPretraga).ShowDialog();
            this.Show();

            // osvezavanje
            KontrolerKI.PretraziUcenike(txtPretrazi, dgvPretraga);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPrikazPohadjanja(dgvPretraga).ShowDialog();
            this.Show();

            // osvezavanje
            KontrolerKI.PretraziUcenike(txtPretrazi, dgvPretraga);
        }
    }
}
