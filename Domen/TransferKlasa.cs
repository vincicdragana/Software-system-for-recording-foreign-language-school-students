using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije {
        Kraj =1,
        PronadjiRadnika = 2,
        UnesiKurs =3,
        ZapamtiKurs=4,
        PretraziSveJezike=5,
        UnesiNivo=6,
        ZapamtiNivo=7,
        ObrisiPohadjanje=8,
        PretraziSveKurseve = 9,
        PrikaziPohadjanjaZaUcenika=10,
        UnesiPohadjanje = 11,
        ZapamtiPohadjanje =12,
        ObrisiUcenika =13,
        PretraziSveNivoe=14,
        PrikaziIzabranogUcenika=15,
        UnesiUcenika=16,
        ZapamtiUcenika=17,
        PretraziUcenike = 18,
        PretraziKurseve = 19,
        PrikaziKurs = 20,
        DaLiPostojiUcenik = 21,
        PretraziPohadjanjaZaKurs = 22,
        NadjiUcenikaZaID = 23,
        DajIDPrisustvo = 24,
        UnesiPrisustvo = 25,
        VratiPrisustvaZaTermin = 26,
        IzbrisiPrisustvi = 27,
        VratiSertifikatZaProfesora = 28,
        PretraziSveProfesore = 29,
        DaLiPostojiPrisustvo = 30
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
