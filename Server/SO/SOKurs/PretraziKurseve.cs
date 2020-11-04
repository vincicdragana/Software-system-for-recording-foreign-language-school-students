using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOKurs
{
    public class PretraziKurseve : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kurs ku = new Kurs();
            Broker.ObrisiZaUslovOstalo(ku);
            return Broker.VratiSveZaUslovOstalo(odo).OfType<Kurs>().ToList<Kurs>();
        }
    }
}
