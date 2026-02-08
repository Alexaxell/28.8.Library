using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._8.Library
{
    public class GetsoreNoleggi
    {
        public List<Veicolo> Veicoli { get; set; } = new List<Veicolo>();
        public List<Noleggio> Noleggi { get; set; } = new List<Noleggio>();
        public List<Cliente> Clienti { get; set; } = new List<Cliente>();

        public double GetPrezzoTotaleNoleggiDallaTarga(string targa)
        {
            double somma = 0;
            foreach (var veicolo in Veicoli)
            {
                if (veicolo.Targa == targa)
                {
                    foreach (var noleggio in veicolo.Noleggi)
                    {
                        somma += noleggio.Costo;
                    }
                }
                else 
                    return 0;
            }

            return somma;
        }

        /* public double GetPrezzoTotaleNoleggiDalCodiceFiscale(string codiceFiscale)
        {
            double somma = 0;
            foreach (var cliente in Clienti)
            {
                if (cliente.CodiceFiscale == codiceFiscale)
                {
                    foreach (var noleggio in cliente.Noleggi)
                    {
                        somma += noleggio.Costo;
                    }
                }
                else 
                    return 0;
            }

            return somma;
        } */

        public List<double> GetPrezzoTotaleNoleggiPerAuto()
        {
            double somma = 0;
            var listaPrezzi = new List<double>();

            foreach (var veicolo in Veicoli)
            {
                foreach (var noleggio in veicolo.Noleggi)
                {
                    somma += noleggio.Costo;
                }

                listaPrezzi.Add(somma);
            }

            return listaPrezzi;
        }

        public void CaricaSuCSV_Veicolo(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File inesistente.");
                return;
            }

            string qualcosa = null;
            string SEPARATORE = ";";
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(qualcosa);

            foreach (var veicolo in Veicoli) 
                stringBuilder.AppendLine($"{veicolo.Targa}{SEPARATORE}{veicolo.Modello}{SEPARATORE}" +
                                         $"{veicolo.Tariffa}");
            
            File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
        }

        public void CaricaSuCSV_Noleggi(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File inesistente.");
                return;
            }

            string qualcosa = null;
            string SEPARATORE = ";";
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(qualcosa);

            foreach (var noleggio in Noleggi)
                stringBuilder.AppendLine($"{noleggio.Id}{SEPARATORE}{noleggio.DataInizio}{SEPARATORE}" +
                                         $"{noleggio.NumeroDiGiorni}{SEPARATORE}{noleggio.Costo}{SEPARATORE}" +
                                         $"{noleggio.Cliente}");

            File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
        }

        public void SalvaSuCSV_Clienti(string filePath)
        {
            string INTESTAZIONE = "CodiceFiscle;Nome;Cognome";
            string SEPARATORE = ";";

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(INTESTAZIONE);

            foreach (var cliente in Clienti)
            {
                stringBuilder.AppendLine($"{cliente.CodiceFiscale}{SEPARATORE}{cliente.Nome}{SEPARATORE}" +
                                         $"{cliente.Cognome}");
            }

            File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
        }

        public void SalvaSuCSV_Veicoli(string filePath)
        {
            string INTESTAZIONE = "Targa;Modello;Tariffa;Tipo;Posti/Capacità";
            string SEPARATORE = ";";
            string tipo;

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(INTESTAZIONE);

            foreach (var veicolo in Veicoli)
            {
                if (veicolo is Automobile)
                {
                    var automobile = (Automobile)veicolo;
                    tipo = "A";

                    stringBuilder.AppendLine($"{automobile.Targa}{SEPARATORE}{automobile.Modello}{SEPARATORE}" +
                                             $"{automobile.Tariffa}{SEPARATORE}{tipo}{SEPARATORE}" +
                                             $"{automobile.NumeroDiPosti}");
                }
                else
                {
                    var furgone = (Furgone)veicolo;
                    tipo = "F";

                    stringBuilder.AppendLine($"{furgone.Targa}{SEPARATORE}{furgone.Modello}{SEPARATORE}" +
                                             $"{furgone.Tariffa}{SEPARATORE}{tipo}{SEPARATORE}" +
                                             $"{furgone.CapacitaDiCarico}");
                }
            }

            File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
        }

        public void SalvaSuCSV_Noleggi(string filePath)
        {
            string INTESTAZIONE = "Id;Targa;CodiceFiscale;DataInizio;NumeroGiorni;Costo";
            string SEPARATORE = ";";

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(INTESTAZIONE);

            foreach (var noleggio in Noleggi)
            {
                stringBuilder.AppendLine($"{noleggio.Id}{SEPARATORE}{noleggio.Veicolo.Targa}{SEPARATORE}" +
                                         $"{noleggio.Cliente.CodiceFiscale}{SEPARATORE}" +
                                         $"{noleggio.DataInizio}{SEPARATORE}{noleggio.NumeroDiGiorni}" +
                                         $"{SEPARATORE}{noleggio.Costo}");
            }

            File.WriteAllText(filePath, stringBuilder.ToString(), Encoding.UTF8);
        }
    }
}
