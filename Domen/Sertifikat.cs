using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Sertifikat : OpstiDomenskiObjekat
    {
        int idSertifikat;
        string naziv;
        Profesor profesor;
        Jezik jezik;
        public int IdSertifikat { get => idSertifikat; set => idSertifikat = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public Jezik Jezik { get => jezik; set => jezik = value; }

        #region ODO
        public string nazivTabele => "Sertifikat";

        public string primarniKljuc => "IDSertifikat";

        public string uslovPrimarni => "IDSertifikat = "+IdSertifikat;

        public string USLOV = "";
        public string uslovOstalo => USLOV;

        public string izmena => "";

        public string unos => "";


        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Sertifikat s = new Sertifikat();
            s.IdSertifikat = Convert.ToInt32(red["IDSertifikat"]);
            s.Naziv = (red["Naziv"]).ToString();
            s.Profesor = new Profesor
            {
                Id = Convert.ToInt32(red["IDProfesor"])
            };
            s.Jezik = new Jezik
            {
                IDJezik = Convert.ToInt32(red["IDJezik"])
            };
            return s;
        }
        #endregion
    }
}
