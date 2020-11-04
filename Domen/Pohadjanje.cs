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
    public class Pohadjanje:OpstiDomenskiObjekat
    {
        int iDPohadjanje;
        Ucenik ucenik;
        Kurs kurs;
        DateTime datumUpisa;

        [Browsable(false)]
        public int IDPohadjanje { get => iDPohadjanje; set => iDPohadjanje = value; }
        [Browsable(false)]
        public Ucenik Ucenik { get => ucenik; set => ucenik = value; }
        public Kurs Kurs { get => kurs; set => kurs = value; }
        public DateTime DatumUpisa { get => datumUpisa; set => datumUpisa = value; }

        public override bool Equals(object obj)
        {
            if (obj is Pohadjanje p)
            {
                return p.IDPohadjanje == IDPohadjanje;
            }
            return false;
        }

        #region ODO
        [Browsable(false)]
        public string nazivTabele => "Pohadjanje";
        [Browsable(false)]
        public string primarniKljuc => "IDPohadjanje";
        [Browsable(false)]
        public string uslovPrimarni => "IDPohadjanje = "+IDPohadjanje;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => "IDPohadjanje = "+IDPohadjanje+", IDUcenik = "+Ucenik.IDUcenik+", DatumUpisa = '"+ DatumUpisa.ToString("yyyy-MM-dd") + "', IDKurs = "+Kurs.IDKurs+"";
        [Browsable(false)]
        public string unos => "(IDPohadjanje) values (" + IDPohadjanje + ")";

        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Pohadjanje p = new Pohadjanje();
            p.IDPohadjanje = Convert.ToInt32(red["IDPohadjanje"]);
            p.Ucenik = new Ucenik
            {
                IDUcenik = Convert.ToInt32(red["IDUcenik"])
            };
            p.kurs = new Kurs
            {
                IDKurs = Convert.ToInt32(red["IDKurs"])
            };
            p.DatumUpisa = Convert.ToDateTime(red["DatumUpisa"]);
            return p;
        }
        #endregion
    }
}
