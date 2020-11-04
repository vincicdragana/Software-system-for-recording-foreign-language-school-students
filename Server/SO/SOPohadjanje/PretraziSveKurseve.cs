using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOPohadjanje
{
    public class PretraziSveKurseve : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kurs k = new Kurs();
            k.USLOV = "Naziv is null";
            Broker.ObrisiZaUslovOstalo(k);
            return Broker.VratiSve(odo).OfType<Kurs>().ToList<Kurs>();

        }
    }
}
