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
    public partial class FrmPrikazPohadjanja : Form
    {
        DataGridView dgvPretraga;
        public FrmPrikazPohadjanja(DataGridView dgvPretraga)
        {
            InitializeComponent();
            this.dgvPretraga = dgvPretraga;
        }

        private void FrmPrikazPohadjanja_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniDetalje(dgvPretraga,dgvPohadjanja,lblUcenik);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiPohadjanje(dgvPohadjanja);

            KontrolerKI.PopuniDetalje(dgvPretraga, dgvPohadjanja, lblUcenik);
        }
    }
}
