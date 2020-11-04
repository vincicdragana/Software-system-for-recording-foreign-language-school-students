using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }

        private void FormaServer_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                this.Text = "Server je pokrenut!";
                MessageBox.Show("Server je pokrenut!");
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokova.Count > 0)
            {
                MessageBox.Show("Server ne moze biti ugasen!\nPostoje korisnici na sistemu!");
                return;
            }

            if (s.zaustaviServer())
            {
                this.Text = "Server nije pokrenut!";
                MessageBox.Show("Server je zaustavljen!");
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }

        }


    }
}
