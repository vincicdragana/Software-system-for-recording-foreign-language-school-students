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
using Server.SO.SORadnik;
using Server.SO.SONivo;
using Server.SO.SOUcenik;
using Server.SO.SOKurs;
using Server.SO.SOPohadjanje;
using Server.SO.SOPrisustvo;

namespace Server
{
    class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();
        }

        void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.PronadjiRadnika:
                            PronadjiRadnika pr = new PronadjiRadnika();
                            transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UnesiNivo:
                            UnesiNivo un = new UnesiNivo();
                            transfer.Rezultat = un.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UnesiUcenika:
                            UnesiUcenika uu = new UnesiUcenika();
                            transfer.Rezultat = uu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UnesiKurs:
                            UnesiKurs uk = new UnesiKurs();
                            transfer.Rezultat = uk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiKurs:
                            ZapamtiKurs zk = new ZapamtiKurs();
                            transfer.Rezultat = zk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziKurs:
                            PrikaziKurs pk = new PrikaziKurs();
                            transfer.Rezultat = pk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziSveJezike:
                            PretraziSveJezike psj = new PretraziSveJezike();
                            transfer.Rezultat = psj.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiNivo:
                            ZapamtiNivo zn = new ZapamtiNivo();
                            transfer.Rezultat = zn.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiPohadjanje:
                            ObrisiPohadjanje op = new ObrisiPohadjanje();
                            transfer.Rezultat = op.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziSveKurseve:
                            PretraziSveKurseve psk= new PretraziSveKurseve();
                            transfer.Rezultat = psk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziKurseve:
                            PretraziKurseve prik = new PretraziKurseve();
                            transfer.Rezultat = prik.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSertifikatZaProfesora:
                            VratiSertifikatZaProfesora vszp = new VratiSertifikatZaProfesora();
                            transfer.Rezultat = vszp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziSveProfesore:
                            PretraziSveProfesore psp = new PretraziSveProfesore();
                            transfer.Rezultat = psp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PrikaziPohadjanjaZaUcenika:
                            PrikaziPohadjanjaZaUcenika ppzu = new PrikaziPohadjanjaZaUcenika();
                            transfer.Rezultat = ppzu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UnesiPohadjanje:
                            UnesiPohadjanje up= new UnesiPohadjanje();
                            transfer.Rezultat = up.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.DajIDPrisustvo:
                            DajIDPrisustvo upri = new DajIDPrisustvo();
                            transfer.Rezultat = upri.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.DaLiPostojiPrisustvo:
                            DaLiPostojiPrisustvo dlpp = new DaLiPostojiPrisustvo();
                            transfer.Rezultat = dlpp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UnesiPrisustvo:
                            UnesiPrisustvo spri = new UnesiPrisustvo();
                            transfer.Rezultat = spri.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiPrisustvaZaTermin:
                            VratiPrisustvaZaTermin vpzt = new VratiPrisustvaZaTermin();
                            transfer.Rezultat = vpzt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzbrisiPrisustvi:
                            IzbrisiPrisustvo izp = new IzbrisiPrisustvo();
                            transfer.Rezultat = izp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiPohadjanje:
                            ZapamtiPohadjanje zp = new ZapamtiPohadjanje();
                            transfer.Rezultat = zp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiUcenika:
                            ObrisiUcenika ou = new ObrisiUcenika();
                            transfer.Rezultat = ou.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziSveNivoe:
                            PretraziSveNivoe psn = new PretraziSveNivoe();
                            transfer.Rezultat = psn.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziUcenike:
                            PretraziUcenike pue = new PretraziUcenike();
                            transfer.Rezultat = pue.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziPohadjanjaZaKurs:
                            PretraziPohadjanjaZaKurs puezk = new PretraziPohadjanjaZaKurs();
                            transfer.Rezultat = puezk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.DaLiPostojiUcenik:
                            DaLiPostojiUcenik dlpu = new DaLiPostojiUcenik();
                            transfer.Rezultat = dlpu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PrikaziIzabranogUcenika:
                            PrikaziIzabranogUcenika piu = new PrikaziIzabranogUcenika();
                            transfer.Rezultat = piu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiUcenika:
                            ZapamtiUcenika zu = new ZapamtiUcenika();
                            transfer.Rezultat = zu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaTokova.Remove(tok);
            }
        }
    }
}
