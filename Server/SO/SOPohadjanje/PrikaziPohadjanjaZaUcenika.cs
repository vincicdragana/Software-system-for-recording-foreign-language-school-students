using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOPohadjanje
{
    public class PrikaziPohadjanjaZaUcenika : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            List<Pohadjanje> pohadjanja = Broker.VratiSveZaUslovOstalo(odo).OfType<Pohadjanje>().ToList<Pohadjanje>();
            foreach(Pohadjanje p in pohadjanja)
            {
                p.Kurs = Broker.VratiZaUslovPrimarni(p.Kurs) as Kurs;
                 
            }

            return pohadjanja;
        }
    }
}
