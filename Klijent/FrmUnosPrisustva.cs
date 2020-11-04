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
    public partial class FrmUnosPrisustva : Form
    {
        public FrmUnosPrisustva(DataGridView dgvTermini)
        {
            InitializeComponent();
            KontrolerKI.PopuniDetaljePrisustvo(dgvPrisustva, dgvTermini, txtDatum, dgvPretraga);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.UnesiPrisustvo(dgvPretraga,dgvPrisustva))
            {
                MessageBox.Show("Prisustvo evidentirano!");
                
            }
        }

        private void btnIzbrisiPrisustvo_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.IzbrisiPrisustvo(dgvPrisustva))
            {
                MessageBox.Show("Prisustvo izbrisano!");

            }
        }

    }
}
