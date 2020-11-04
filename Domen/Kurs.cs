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
    public class Kurs : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return Naziv;
        }


        int iDKurs;
        string naziv;
        DateTime datumOd;
        DateTime datumDO;
        int aktivan;
        Nivo nivo;
        BindingList<Termin> termini;
        Profesor profesor;

        [Browsable(false)]
        public int IDKurs { get => iDKurs; set => iDKurs = value; }
        public string Naziv { get => naziv; set => naziv = value; } 
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        [Browsable(false)]
        public DateTime DatumDO { get => datumDO; set => datumDO = value; }
        [Browsable(false)]
        public int Aktivan { get => aktivan; set => aktivan = value; }
        [Browsable(false)]
        public Nivo Nivo { get => nivo; set => nivo = value; }
        [Browsable(false)]
        public BindingList<Termin> Termini { get => termini; set => termini = value; }
        [Browsable(false)]
        public Profesor Profesor { get => profesor; set => profesor = value; }

        public Kurs()
        {
            termini = new BindingList<Termin>();
        }

        #region ODO
        [Browsable(false)]
        public string nazivTabele => "Kurs";
        [Browsable(false)]
        public string primarniKljuc => "IDKurs";
        [Browsable(false)]
        public string uslovPrimarni => "IDKurs ="+IDKurs;

        public string USLOV = "Naziv is null";

        [Browsable(false)]
        public string uslovOstalo => USLOV;
        
        public string IZMENA = "";

        [Browsable(false)]
        public string izmena => IZMENA;
        [Browsable(false)]
        public string unos => "(IDKurs) values ("+IDKurs+")";


        [Browsable(false)]
        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Kurs k = new Kurs();
            k.iDKurs = Convert.ToInt32(red["IDKurs"]);
            k.Naziv = (red["Naziv"]).ToString();
            k.DatumOd = Convert.ToDateTime(red["DatumOd"]);
            k.DatumDO = Convert.ToDateTime(red["DatumDo"]);
            k.Aktivan = Convert.ToInt32(red["Aktivan"]);
            k.Nivo = new Nivo
            {
                IDNivo = Convert.ToInt32(red["IDNivo"])
            };
            k.Profesor = new Profesor
            {
                Id = Convert.ToInt32(red["IDProfesor"])
            };

            return k;
        }
        #endregion
    }
}
