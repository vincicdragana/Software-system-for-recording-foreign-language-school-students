using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Nivo : OpstiDomenskiObjekat
    {
        int iDNivo;
        string naziv;
        Jezik jezik;
        
        public int IDNivo { get => iDNivo; set => iDNivo = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public Jezik Jezik { get => jezik; set => jezik = value; }

        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            if (obj is Nivo n)
            {
                return n.IDNivo == this.IDNivo;
            }
            return false;
        }

        #region ODO
        [Browsable(false)]
        public string nazivTabele => "Nivo";
        [Browsable(false)]
        public string primarniKljuc => "IDNivo";
        [Browsable(false)]
        public string uslovPrimarni => "IDNivo = " + IDNivo;
        [Browsable(false)]
        public string uslovOstalo => "Naziv is null";
        [Browsable(false)]
        public string izmena => "IDNivo = " + IDNivo + ", Naziv = '" + Naziv + "', IDJezik = " + Jezik.IDJezik;
        [Browsable(false)]
        public string unos => "(IDNivo) values ("+ IDNivo+")";
        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Nivo n = new Nivo();
            n.IDNivo = Convert.ToInt32(red["IDNivo"]);
            n.naziv = (red["Naziv"]).ToString();
            n.Jezik = new Jezik
            {
                IDJezik = Convert.ToInt32(red["IDJezik"])
            };
            return n;
        
        }
        #endregion
    }
}
