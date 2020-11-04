using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        internal object VratiPrisustvaZaTermin(Prisustvo prisustvo)
        {

            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiPrisustvaZaTermin;
            transfer.TransferObjekat = prisustvo;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        internal Object PretraziPohadjanjaZaKurs(Pohadjanje p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziPohadjanjaZaKurs;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        internal Object IzbrisiPrisustvo(Prisustvo p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzbrisiPrisustvi;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }


        internal object UnesiPrisustvo(Prisustvo p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UnesiPrisustvo;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object UnesiPrisustvo()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.DajIDPrisustvo;
            transfer.TransferObjekat = new Prisustvo();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object UnesiUcenika()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UnesiUcenika;
            transfer.TransferObjekat = new Ucenik();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiUcenika(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiUcenika;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object UnesiNivo()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UnesiNivo;
            transfer.TransferObjekat = new Nivo();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiNivo(Nivo n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNivo;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PretraziSveJezike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziSveJezike;
            transfer.TransferObjekat = new Jezik();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object UnesiKurs()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UnesiKurs;
            transfer.TransferObjekat = new Kurs();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        internal Object DaLiPostojiPrisustvo(Prisustvo p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.DaLiPostojiPrisustvo;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiKurs(Kurs k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiKurs;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PrikaziKurs(Kurs k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziKurs;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object ObrisiPohadjanje(Pohadjanje p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiPohadjanje;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PretraziSveKurseve()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziSveKurseve;
            transfer.TransferObjekat = new Kurs();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PrikaziPohadjanjaZaUcenika(Pohadjanje p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziPohadjanjaZaUcenika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object UnesiPohadjanje()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UnesiPohadjanje;
            transfer.TransferObjekat = new Pohadjanje();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object ZapamtiPohadjanje(Pohadjanje p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiPohadjanje;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PronadjiRadnika(Radnik r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiRadnika;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object ObrisiUcenika(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiUcenika;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PretraziUcenike(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziUcenike;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        //public Object IzmeniKurs(Kurs k)
        //{
        //    TransferKlasa transfer = new TransferKlasa();
        //    transfer.Operacija = Operacije.IzmeniKurs;
        //    transfer.TransferObjekat = k;
        //    formater.Serialize(tok, transfer);

        //    return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        //}
        public Object PrikaziIzabranogUcenika(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziIzabranogUcenika;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PretraziKurseve(Kurs k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziKurseve;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object PretraziSveNivoe()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziSveNivoe;
            transfer.TransferObjekat = new Nivo();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        internal Object DaLiPostojiUcenik(Ucenik ucenik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.DaLiPostojiUcenik;
            transfer.TransferObjekat = ucenik;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        internal Object VratiSertifikatZaProfesora(Sertifikat s)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSertifikatZaProfesora;
            transfer.TransferObjekat = s;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        internal Object PretraziSveProfesore(Profesor p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziSveProfesore;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
    }
}
