using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.SOKurs
{
    public class VratiSertifikatZaProfesora : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {

            return Broker.VratiZaUslovOstalo(odo) as Sertifikat;
        }
    }
}
