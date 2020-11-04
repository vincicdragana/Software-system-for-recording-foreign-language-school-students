using Domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Server;
using Server.SO.SOKurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovi
{
    [TestClass]
    public class UnitTestoviKurs
    {
        [TestMethod]
        public void UnesiKursUspesno()
        {
            Kurs kurs = new Kurs();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiSifru(kurs)).Returns(1);
            mock.Setup(b => b.Sacuvaj(kurs));

            UnesiKurs uk = new UnesiKurs();
            uk.Broker = mock.Object;
            Kurs pov = (Kurs)uk.IzvrsiKonkretnuSO(kurs);
            mock.Verify((b => b.VratiSifru(kurs)), Times.Once());
            Assert.IsTrue(pov != null);
            Assert.AreEqual(1, pov.IDKurs);
        }

        [TestMethod]
        public void ZapamtiKursUspesno()
        {
            Kurs kurs = ListaKurseva()[0] as Kurs;
            Termin termin = new Termin();
            Mock<Broker> mock = new Mock<Broker>();
            Termin t = null;
            mock.Setup(b => b.IzmeniUslovPrimarni(kurs)).Returns(1);
            mock.Setup(b => b.VratiZaUslovOstalo(It.IsAny<Termin>())).Returns(t);
            mock.Setup(b => b.Sacuvaj(termin));

            ZapamtiKurs zk = new ZapamtiKurs();
            zk.Broker = mock.Object;
            Kurs pov = (Kurs)zk.IzvrsiKonkretnuSO(kurs);
            mock.Verify(b => b.IzmeniUslovPrimarni(kurs), Times.Once);
            for (int i = 0; i < kurs.Termini.Count; i++)
            {
                mock.Verify(b => b.VratiZaUslovOstalo(kurs.Termini[i]), Times.Exactly(1));
            }
            mock.Verify(b => b.VratiZaUslovOstalo(It.IsAny<Termin>()), Times.Exactly(kurs.Termini.Count));
            Assert.IsTrue(pov != null);
            Assert.AreEqual(kurs, pov);
            for(int i =0; i < kurs.Termini.Count; i++)
            {
                Assert.AreEqual(kurs.Termini[i], pov.Termini[i]);
            }

        }

        [TestMethod]
        public void PrikaziKursUspesno()
        {
            Kurs kurs = ListaKurseva()[0] as Kurs;
            List<OpstiDomenskiObjekat> termini = ListaTermina2();
            //Termin termin = new Termin
            //{
            //    Kurs = kurs,
            //    USLOV = "IDKurs=" + kurs.IDKurs
            //};

            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.VratiZaUslovPrimarni(kurs.Nivo)).Returns(kurs.Nivo);
            mock.Setup(b => b.VratiSveZaUslovOstalo(It.IsAny<Termin>())).Returns(termini);

            PrikaziKurs pk = new PrikaziKurs();
            pk.Broker = mock.Object;
            Kurs pov = (Kurs)pk.IzvrsiKonkretnuSO(kurs);
            mock.Verify(b => b.VratiZaUslovPrimarni(kurs.Nivo), Times.Once);
            mock.Verify(b => b.VratiSveZaUslovOstalo(It.IsAny<Termin>()), Times.Once);
            Assert.IsTrue(pov != null);
            Assert.AreEqual(termini.Count, pov.Termini.Count);
            for(int i = 0; i < pov.Termini.Count; i++)
            {
                Assert.AreEqual(termini[i], pov.Termini[i]);
            }
        }

        [TestMethod]
        public void PretraziKurseveUspesno()
        {
            Kurs kurs = ListaKurseva()[0] as Kurs;
            List<OpstiDomenskiObjekat> kursevi = ListaKurseva();
            Mock<Broker> mock = new Mock<Broker>();

            mock.Setup(b => b.ObrisiZaUslovOstalo(It.IsAny<Kurs>()));
            mock.Setup(b => b.VratiSveZaUslovOstalo(kurs)).Returns(kursevi);

            PretraziKurseve pk = new PretraziKurseve();
            pk.Broker = mock.Object;
            List<Kurs> pov = (List<Kurs>)pk.IzvrsiKonkretnuSO(kurs);
            mock.Verify(b => b.ObrisiZaUslovOstalo(It.IsAny<Kurs>()), Times.Once());
            mock.Verify(b => b.VratiSveZaUslovOstalo(kurs), Times.Once());

            Assert.IsTrue(pov != null);
            for(int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(kursevi[i], pov[i]);
            }
        }

        [TestMethod]
        public void PretraziSveProfesoreUspesno()
        {
            Profesor profesor = new Profesor();
            Mock<Broker> mock = new Mock<Broker>();
            List<OpstiDomenskiObjekat> profesori = ListaProfesora();

            mock.Setup(b => b.VratiSve(profesor))
                .Returns(profesori);

            PretraziSveProfesore psp = new PretraziSveProfesore();
            psp.Broker = mock.Object;
            List<Profesor> pov = (List<Profesor>)psp.IzvrsiKonkretnuSO(profesor);

            mock.Verify(b => b.VratiSve(profesor), Times.Once());
            Assert.IsTrue(pov != null);
            for (int i = 0; i < pov.Count; i++)
            {
                Assert.AreEqual(profesori[i], pov[i]);
            }
        }

        [TestMethod]
        public void VratiSertifikatZaProfesoraUspesno()
        {
            Sertifikat sertifikat = new Sertifikat();
            Mock<Broker> mock = new Mock<Broker>();

            VratiSertifikatZaProfesora vszp = new VratiSertifikatZaProfesora();
            vszp.Broker = mock.Object;
            Sertifikat pov = (Sertifikat)vszp.IzvrsiKonkretnuSO(sertifikat);
        }

        private List<OpstiDomenskiObjekat> ListaKurseva()
        {
            List<OpstiDomenskiObjekat> kursevi = new List<OpstiDomenskiObjekat>
            {
                new Kurs
                {
                    IDKurs =1,
                    Naziv = "Eng A1 okt-jan",
                    Nivo = new Nivo
                    {
                        IDNivo=1
                    }
                },
                new Kurs
                {
                    IDKurs =2,
                    Naziv = "Nem A1 jun-jan",
                    Nivo = new Nivo
                    {
                        IDNivo=2
                    }

                },
            };
            return kursevi;
        }

        private BindingList<Termin> ListaTermina()
        {
            BindingList<Termin> termini = new BindingList<Termin>
            {
                new Termin
                {
                    IdTermin = 1,
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    },
                    USLOV = " Datum = '" +Convert.ToDateTime("1996-12-30")+ "' AND IDKurs ="+1
        },
                 new Termin
                {
                    IdTermin = 2,
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    },
                    USLOV = " Datum = '" +Convert.ToDateTime("1996-12-20")+ "' AND IDKurs ="+1
                },
                  new Termin
                {
                    IdTermin = 3,
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    },
                    USLOV = " Datum = '" +Convert.ToDateTime("1996-12-10")+ "' AND IDKurs ="+1
                }
            };
            return termini;
        }

        private List<OpstiDomenskiObjekat> ListaTermina2()
        {
            List<OpstiDomenskiObjekat> termini = new List<OpstiDomenskiObjekat>
            {
                new Termin
                {
                    IdTermin = 1,
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    }

                },
                 new Termin
                {
                    IdTermin = 2,
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    }
                },
                  new Termin
                {
                    IdTermin = 3,
                    Kurs = new Kurs
                    {
                        IDKurs = 1
                    }
                }
            };
            return termini;
        }

        private List<OpstiDomenskiObjekat> ListaProfesora()
        {
            List<OpstiDomenskiObjekat> profesori = new List<OpstiDomenskiObjekat>
            {
                new Profesor
                {
                    Id=1,
                    ImePrezime = "Srna Brkic",
                    Jmbg ="89699t969"
                },
                new Profesor
                {
                    Id=2,
                    ImePrezime = "Kristina Novic",
                    Jmbg ="89608969"
                },
                new Profesor
                {
                    Id=3,
                    ImePrezime = "Dusan Savic",
                    Jmbg ="896999659"
                }
            };
            return profesori;
        }
    }
}
