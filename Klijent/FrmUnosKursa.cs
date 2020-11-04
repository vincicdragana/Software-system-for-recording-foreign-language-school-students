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
    public partial class FrmUnosKursa : Form
    {

        public FrmUnosKursa()
        {
            InitializeComponent();
            gbKlijent.Enabled = false;
            gbTermini.Enabled = false;
            panelAktivan.Enabled = false;
            btnSacuvajKurs.Enabled = false;
            btnIzmeni.Visible = false;
            KontrolerKI.PopuniKomboProfesor(cmbProfesor);
        }

        public FrmUnosKursa(object kurs)
        {
            InitializeComponent();
            KontrolerKI.PopuniKomboProfesor(cmbProfesor);
            KontrolerKI.popuniDetaljeKurs(kurs, txtDatumDo, txtDatumOd, txtNaziv, txtSifraKursa, rbDA, rbNE, dgvTermini, cmbNivo, cmbProfesor);
            btnSacuvajKurs.Visible = false;
            btnKreirajKurs.Enabled = false;
            gbKlijent.Enabled = true;
        }

        private void btnKreirajKurs_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.UnesiKurs(txtSifraKursa, dgvTermini))
            {
                KontrolerKI.PopuniKomboProfesor(cmbProfesor);
                KontrolerKI.PopuniKomboNivo(cmbNivo);
                gbKlijent.Enabled = true;
                panelAktivan.Enabled = true;
                gbTermini.Enabled = true;
                btnKreirajKurs.Enabled = false;
                btnSacuvajKurs.Enabled = true;
            }
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            KontrolerKI.DodajTermin(txtDatumTermin, txtDatumDo, txtDatumOd);
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                KontrolerKI.ObrisiTermin(dgvTermini.CurrentRow.DataBoundItem);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali termin!");
            }
        }

        private void btnSacuvajKurs_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.SacuvajKurs(txtDatumDo, txtDatumOd, txtNaziv, rbDA, rbNE, cmbNivo.SelectedItem, cmbNivo, cmbProfesor))
                this.Close();
        }



        private void gbTermini_Enter(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.IzmeniKursNovo(cmbNivo, cmbProfesor, txtDatumDo, txtDatumOd, txtNaziv, rbDA, rbNE))
            {
                this.Close();
            }


        }

        
    }
}
