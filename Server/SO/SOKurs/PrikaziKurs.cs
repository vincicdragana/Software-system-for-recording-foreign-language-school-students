using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO.SOKurs
{
    public class PrikaziKurs:OpstaSO
    {
       
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kurs k = odo as Kurs;

            k.Nivo = Broker.VratiZaUslovPrimarni(k.Nivo) as Nivo;
            k.Profesor = Broker.VratiZaUslovPrimarni(k.Profesor) as Profesor;
            Termin t = new Termin();
            t.USLOV = "IDKurs=" + k.IDKurs;

            List<Termin> lista = Broker.VratiSveZaUslovOstalo(t).OfType<Termin>().ToList<Termin>();

            foreach (Termin te in lista)
            {

                k.Termini.Add(te);
            }

            return k;

        }
    }
}
