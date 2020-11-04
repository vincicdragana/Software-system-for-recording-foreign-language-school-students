using System;
using System.Collections.Generic;
using Domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server;
using Server.SO.SOUcenik;

namespace Testovi
{
    [TestClass]
    public class UnitTestoviUcenik
    {

        [TestMethod]
        
        public void UnesiUcenikaUspesno()
        {
            Ucenik ucenik = new Ucenik();
            Mock<Broker> mock = new Mock<Broker>();
            
            mock.Setup(b => b.VratiSifru(ucenik)).Returns(1);
            mock.Setup(b => b.Sacuvaj(ucenik));
            //mock.Setup(b => b.VratiSifru(null)).Throws<Exception>();
            
            UnesiUcenika u = new UnesiUcenika();
            u.Broker = mock.Object;
            Ucenik pov = (Ucenik)u.IzvrsiKonkretnuSO(ucenik);
            mock.Verify((b => b.VratiSifru(ucenik)), Times.Once());
            Assert.IsTrue(pov != null);
            Assert.AreEqual(1,pov.IDUcenik);
                
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void UnesiUcenikaNeuspesno()
        {
            Ucenik ucenik = new Ucenik();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(null)).Throws<Exception>();
            mock.Setup(b => b.Sacuvaj(ucenik));

            UnesiUcenika u = new UnesiUcenika();
            u.Broker = mock.Object;
            Ucenik pov = (Ucenik)u.IzvrsiKonkretnuSO(null);
            mock.Verify((b => b.Sacuvaj(ucenik)), Times.Never);
        }

        [TestMethod]

        public void ZapamtiUcenikaUspesno()
        {
            Ucenik ucenik = ListaUcenika()[1] as Ucenik;
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.IzmeniUslovPrimarni(ucenik)).Returns(1);

            ZapamtiUcenika zu = new ZapamtiUcenika();
            zu.Broker = mock.Object;
            int pov = (int)zu.IzvrsiKonkretnuSO(ucenik);
            mock.Verify((b => b.IzmeniUslovPrimarni(ucenik)), Times.Once);
            Assert.AreEqual(1, pov);


        }

        [TestMethod]

        public void PrikaziIzabranogiUcenikaUspesno()
        {
            Ucenik ucenik = new Ucenik()
            {
                IDUcenik = 1
            };
            Mock<Broker> mock = new Mock<Broker>();
            var uc = ListaUcenika()[1] as Ucenik;
            mock.Setup(b => b.VratiZaUslovPrimarni(ucenik)).Returns(uc);

            PrikaziIzabranogUcenika piu = new PrikaziIzabranogUcenika();
            piu.Broker = mock.Object;
            Ucenik pov = (Ucenik)piu.IzvrsiKonkretnuSO(ucenik);
            mock.Verify(b => b.VratiZaUslovPrimarni(ucenik), Times.Once());
            Assert.AreEqual(uc.IDUcenik, pov.IDUcenik);
        }

        [TestMethod]

        public void PretraziUcenikeUspesno()
        {
            Ucenik ucenik = new Ucenik();
            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> ucenici = ListaUcenika();
            mock.Setup(b => b.ObrisiZaUslovOstalo(It.IsAny<Ucenik>()));
            mock.Setup(b => b.VratiSveZaUslovOstalo(ucenik))
                .Returns(ucenici);

            PretraziUcenike pu = new PretraziUcenike();
            pu.Broker = mock.Object;
            List<Ucenik> pov = (List<Ucenik>)pu.IzvrsiKonkretnuSO(ucenik);
            mock.Verify(b => b.ObrisiZaUslovOstalo(It.IsAny<Ucenik>()), Times.Once());
            mock.Verify(b => b.VratiSveZaUslovOstalo(ucenik), Times.Once());
            Assert.IsTrue(pov != null);
            for(int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(ucenici[i],pov[i]); 
            }

        }

        [TestMethod]

        public void PretraziSveNivoeUspesno()
        {
            Nivo nivo = new Nivo();
            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> nivoi = ListaNivoa();
            mock.Setup(b => b.ObrisiZaUslovOstalo(It.IsAny<Nivo>()));
            mock.Setup(b => b.VratiSve(nivo))
                .Returns(nivoi);

            PretraziSveNivoe psn = new PretraziSveNivoe();
            psn.Broker = mock.Object;
            List<Nivo> pov = (List<Nivo>)psn.IzvrsiKonkretnuSO(nivo);
            mock.Verify(b => b.ObrisiZaUslovOstalo(It.IsAny<Nivo>()), Times.Once());
            mock.Verify(b => b.VratiSve(nivo), Times.Once());
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(nivoi[i], pov[i]);
            }

        }

        [TestMethod]

        public void PretraziPohadjanjaZaKursUspesno()
        {
            Pohadjanje p = new Pohadjanje();

            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> pohadjanja = ListaPohadjanja();
            mock.Setup(b => b.VratiSveZaUslovOstalo(p)).Returns(pohadjanja);

            PretraziPohadjanjaZaKurs ppzk = new PretraziPohadjanjaZaKurs();
            ppzk.Broker = mock.Object;
            List<Pohadjanje> pov = (List<Pohadjanje>)ppzk.IzvrsiKonkretnuSO(p);
            mock.Verify(b => b.VratiSveZaUslovOstalo(p), Times.Once());
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(pohadjanja[i], pov[i]);
            }

        }

        [TestMethod]

        public void ObrisiUcenikaUspesno()
        {
            Ucenik u = ListaUcenika()[1] as Ucenik;
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.ObrisiZaUslovPrimarni(u)).Returns(1);

            ObrisiUcenika ou = new ObrisiUcenika();
            ou.Broker = mock.Object;
            int pov = (int)ou.IzvrsiKonkretnuSO(u);
            mock.Verify(b => b.ObrisiZaUslovPrimarni(u), Times.Once());
            Assert.AreEqual(1, pov);
        }

        [TestMethod]

        public void DaLiPostojiUcenikUspesno()
        {
            Ucenik u1 = ListaUcenika()[1] as Ucenik;
            Ucenik u2 = new Ucenik()
            {
                JMBG1 = u1.JMBG1,
            };
            Mock<Broker> mock = new Mock<Broker>();
            mock.Setup(b => b.VratiZaUslovOstalo(u2)).Returns(u1);

            DaLiPostojiUcenik dlpu = new DaLiPostojiUcenik();
            dlpu.Broker = mock.Object;
            Ucenik pov = (Ucenik)dlpu.IzvrsiKonkretnuSO(u2);
            mock.Verify(b => b.VratiZaUslovOstalo(u2), Times.Once);
            Assert.IsTrue(pov != null);
            Assert.AreEqual(u1, pov);

        }

        private List<OpstiDomenskiObjekat> ListaUcenika()
        {
            List<OpstiDomenskiObjekat> ucenici = new List<OpstiDomenskiObjekat>
            {
                new Ucenik
                {
                    IDUcenik = 1,
                    Ime = "Dragana",
                    Prezime = "Vincic",
                    JMBG1 = "047509300",
                    DatumRodjenja = Convert.ToDateTime("1996-12-30"),
                    BrojTelefona = "0645536672",
                    Adresa = "Simiceva 3a"
                },
                new Ucenik
                {
                    IDUcenik = 2,
                    Ime = "Mirjana",
                    Prezime = "Simic",
                    JMBG1 = "047503400",
                    DatumRodjenja = Convert.ToDateTime("1990-10-30"),
                    BrojTelefona = "0645536902",
                    Adresa = "Simiceva 23"
                },
                new Ucenik
                {
                    IDUcenik = 3,
                    Ime = "Petar",
                    Prezime = "Slavcevic",
                    JMBG1 = "009809300",
                    DatumRodjenja = Convert.ToDateTime("1991-12-10"),
                    BrojTelefona = "0639536672",
                    Adresa = "Bulevar umetnosti 5"
                }

            };
            return ucenici;
        }

        private List<OpstiDomenskiObjekat> ListaNivoa()
        {
            List<OpstiDomenskiObjekat> nivoi = new List<OpstiDomenskiObjekat>
            {
                new Nivo
                {
                    IDNivo = 1,
                    Naziv = "Eng A1",
                    Jezik = new Jezik
                    {
                        IDJezik = 1,
                        Naziv = "Engleski"
                    }
                },
                new Nivo
                {
                    IDNivo = 2,
                    Naziv = "Eng A2",
                    Jezik = new Jezik
                    {
                        IDJezik = 1,
                        Naziv = "Engleski"
                    }
                },
                new Nivo
                {
                    IDNivo = 3,
                    Naziv = "Nem A1",
                    Jezik = new Jezik
                    {
                        IDJezik = 2,
                        Naziv = "Nemacki"
                    }
                }


            };
            return nivoi;
        }

        private List<OpstiDomenskiObjekat> ListaPohadjanja()
        {
            List<OpstiDomenskiObjekat> pohadjanja = new List<OpstiDomenskiObjekat>
            {
                new Pohadjanje
                {
                    IDPohadjanje = 1,
                    Kurs = new Kurs
                    {

                    },
                    Ucenik = new Ucenik
                    {

                    }
                },
                new Pohadjanje
                {
                    IDPohadjanje = 2,
                    Kurs = new Kurs
                    {

                    },
                    Ucenik = new Ucenik
                    {

                    }
                },
                new Pohadjanje
                {
                    IDPohadjanje = 3,
                    Kurs = new Kurs
                    {

                    },
                    Ucenik = new Ucenik
                    {

                    }
                },


            };
            return pohadjanja;
        }
    }
}
