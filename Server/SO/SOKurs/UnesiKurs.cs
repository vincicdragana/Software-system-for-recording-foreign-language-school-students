using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOKurs
{
    public class UnesiKurs : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            int ID;
            try
            {
                ID = Broker.VratiSifru(odo);
            }
            catch (Exception)
            {

                ID = -1;
            }
            Kurs k = new Kurs()
            {
                IDKurs = ID
            };
            if (ID > -1)
            {
                Broker.Sacuvaj(k);
            }
            else
            {
                k = null;
                return k;
            }
            return k;
        }
    }
}
