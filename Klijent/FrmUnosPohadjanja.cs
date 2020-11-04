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
    public partial class FrmUnosPohadjanja : Form
    {
        DataGridView dgvPretraga;
        public FrmUnosPohadjanja(DataGridView dgvPretraga)
        {
            InitializeComponent();
            this.dgvPretraga = dgvPretraga;
            KontrolerKI.popuniKomboKurs(cmbKurs);

        }

        private void btnKreirajPohadjanje_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.UnesiPohadjanjaZaUcenika(IDPohadjanje))
            {
                gbPohadjanje.Enabled = true;
            };
        }

        private void btnUnesiPohadjanje_Click(object sender, EventArgs e)
        {

            if (KontrolerKI.SacuvajPohadjanje(txtDatumUpisa,cmbKurs.SelectedItem,cmbKurs))
            {
                IDPohadjanje.Text = "";
                txtDatumUpisa.Clear();
                cmbKurs.Text = "Izaberite kurs!";
            };
        }

        private void FrmUnosPohadjanja_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniUcenika(dgvPretraga, lblUcenik);
            gbPohadjanje.Enabled = false;
        }

        private void cmbKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.PopuniDatumZaKursPohadjanje(cmbKurs.SelectedItem, lblDatum);
        }
    }
}
