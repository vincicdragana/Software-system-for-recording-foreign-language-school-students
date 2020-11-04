using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOKurs
{
    public class ZapamtiKurs : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Kurs k = odo as Kurs;
            Broker.IzmeniUslovPrimarni(k);

            //Termin t = new Termin();
            
            //t.USLOV = " IDKurs = " + k.IDKurs;

            //Broker.dajSesiju().ObrisiZaUslovOstalo(t);

            foreach (Termin te in k.Termini)
            {
                te.USLOV = " Datum = '" +te.Datum+ "' AND IDKurs ="+te.Kurs.IDKurs;
                if(Broker.VratiZaUslovOstalo(te) == null)
                {
                    Broker.Sacuvaj(te);
                }
                
            }


            return k;
        }
    }
}
