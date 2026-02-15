using _28._8.Library;

namespace _28._8.Library.Test
{
    [TestClass]
    public sealed class Test1
    {
        private GetsoreNoleggi CreaGestoreConDatiBase()
        {
            var cliente = new Cliente { CodiceFiscale = "ABC123", Nome = "Mario", Cognome = "Rossi" };
            var auto = new Automobile { Targa = "AA111AA", Modello = "Fiesta", Tariffa = 10, NumeroDiPosti = 5 };
            var furgone = new Furgone { Targa = "BB222BB", Modello = "Ducato", Tariffa = 20, CapacitaDiCarico = 1000 };

            var noleggi = new List<Noleggio>
        {
            new Noleggio { Id = "1", Cliente = cliente, Veicolo = auto, NumeroDiGiorni = 2, Costo = 20, DataInizio = DateTime.Today },
            new Noleggio { Id = "2", Cliente = cliente, Veicolo = auto, NumeroDiGiorni = 3, Costo = 30, DataInizio = DateTime.Today },
            new Noleggio { Id = "3", Cliente = cliente, Veicolo = furgone, NumeroDiGiorni = 1, Costo = 20, DataInizio = DateTime.Today }
        };

            return new GetsoreNoleggi
            {
                Clienti = new List<Cliente> { cliente },
                Veicoli = new List<Veicolo> { auto, furgone },
                Noleggi = noleggi
            };
        }

        [TestMethod]
        public void GetPrezzoTotaleNoleggiDallaTarga_SommaCorretta()
        {
            var gestore = CreaGestoreConDatiBase();

            var totale = gestore.GetPrezzoTotaleNoleggiDallaTarga("AA111AA");

            Assert.AreEqual(50, totale);
        }

        [TestMethod]
        public void GetPrezzoTotaleNoleggiDallaTarga_TargaNonPresente_RitornaZero()
        {
            var gestore = CreaGestoreConDatiBase();

            var totale = gestore.GetPrezzoTotaleNoleggiDallaTarga("ZZ999ZZ");

            Assert.AreEqual(0, totale);
        }

        [TestMethod]
        public void GetPrezzoTotaleNoleggiDalCodiceFiscale_SommaCorretta()
        {
            var gestore = CreaGestoreConDatiBase();

            var totale = gestore.GetPrezzoTotaleNoleggiDalCodiceFiscale("ABC123");

            Assert.AreEqual(70, totale);
        }

        [TestMethod]
        public void GetPrezzoTotaleNoleggiDalCodiceFiscale_CFNonPresente_RitornaZero()
        {
            var gestore = CreaGestoreConDatiBase();

            var totale = gestore.GetPrezzoTotaleNoleggiDalCodiceFiscale("XXX999");

            Assert.AreEqual(0, totale);
        }

        [TestMethod]
        public void GetPrezzoTotaleNoleggiPerAuto_RitornaValoriCorretti()
        {
            var gestore = CreaGestoreConDatiBase();

            var risultati = gestore.GetPrezzoTotaleNoleggiPerAuto();

            Assert.AreEqual(2, risultati.Count);
        }
    }
    }