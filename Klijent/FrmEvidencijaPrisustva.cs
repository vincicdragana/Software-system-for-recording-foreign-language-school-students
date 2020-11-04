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
    public partial class FrmEvidencijaPrisustva : Form
    {
        public FrmEvidencijaPrisustva(DataGridView dgv)
        {
            InitializeComponent();
            KontrolerKI.PopuniGridEvidencija(dgv, dgvTermini);

        }


        private void btnUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosPrisustva(dgvTermini).ShowDialog();
            this.Show();
        }

    }
}
