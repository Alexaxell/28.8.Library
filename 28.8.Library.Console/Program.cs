using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _28._8.Library.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var gestoreNoleggi = new GetsoreNoleggi();

            string scelta = null;
            string tipo = null;
            string codiceFiscale;
            string nome;
            string cognome;
            string targa;
            string modello;
            int tariffa = 0;
            int numeroDiPosti = 0;
            int capacitaDiCarico = 0;
            string id;
            DateTime dataInzio;
            int numeroDiGiorni = 0;
            double costo = 0;
            Cliente cliente = null;
            Veicolo veicolo = null;
            Noleggio noleggio = null;
            bool controllore = true;

            while (scelta != "17")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("1. Inserisci un cliente");
                System.Console.WriteLine("2. Inserisci un veicolo");
                System.Console.WriteLine("3. Inserisci un noleggio");
                System.Console.WriteLine("4. Modifica un cliente");
                System.Console.WriteLine("5. Modifica un veicolo");
                System.Console.WriteLine("6. Modifica un noleggio");
                System.Console.WriteLine("7. Elimina un cliente");
                System.Console.WriteLine("8. Elimina un veicolo");
                System.Console.WriteLine("9. Elimina un noleggio");
                System.Console.WriteLine("10. Stampa il totale in euro dei noleggi data una targa");
                System.Console.WriteLine("11. Stampa il totale in euro dei noleggi dato un codice fiscale");
                System.Console.WriteLine("12. Stampa il totale in euro dei noleggi raggruppato per auto");
                System.Console.WriteLine("13. Carica i 3 dati su un file di testo in formato csv");
                System.Console.WriteLine("14. Stampa lista clienti");
                System.Console.WriteLine("15. Stampa lista veicoli");
                System.Console.WriteLine("16. Stampa lista noleggi");
                System.Console.WriteLine("17. Esci...");
                System.Console.WriteLine();

                scelta = System.Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        System.Console.Write("Codice fiscale: ");
                        codiceFiscale = System.Console.ReadLine();
                        System.Console.Write("Nome: ");
                        nome = System.Console.ReadLine();
                        System.Console.Write("Cognome: ");
                        cognome = System.Console.ReadLine();

                        gestoreNoleggi.Clienti.Add(new Cliente()
                        {
                            CodiceFiscale = codiceFiscale,
                            Nome = nome,
                            Cognome = cognome
                        });

                        break;

                    case "2":
                        var tipoVeicolo = new Veicolo();

                        System.Console.Write("Tipo: ");
                        tipo = System.Console.ReadLine();
                        if (tipo.ToUpper() == "A")
                        {
                            System.Console.Write("Targa: ");
                            targa = System.Console.ReadLine();
                            System.Console.Write("Modello: ");
                            modello = System.Console.ReadLine();
                            System.Console.Write("Tariffa: ");
                            tariffa = int.Parse(System.Console.ReadLine());
                            System.Console.Write("Numero di posti: ");
                            numeroDiPosti = int.Parse(System.Console.ReadLine());

                            gestoreNoleggi.Veicoli.Add(new Automobile()
                            {
                                Targa = targa,
                                Modello = modello,
                                Tariffa = tariffa,
                                NumeroDiPosti = numeroDiPosti
                            });
                        }
                        else
                        {
                            System.Console.Write("Targa: ");
                            targa = System.Console.ReadLine();
                            System.Console.Write("Modello: ");
                            modello = System.Console.ReadLine();
                            System.Console.Write("Tariffa: ");
                            tariffa = int.Parse(System.Console.ReadLine());
                            System.Console.Write("Capacità di carico: ");
                            capacitaDiCarico = int.Parse(System.Console.ReadLine());

                            gestoreNoleggi.Veicoli.Add(new Furgone()
                            {
                                Targa = targa,
                                Modello = modello,
                                Tariffa = tariffa,
                                CapacitaDiCarico = capacitaDiCarico
                            });
                        }
                        break;

                    case "3":
                        System.Console.Write("Id: ");
                        id = System.Console.ReadLine();
                        System.Console.Write("Data inizio: ");
                        dataInzio = DateTime.Parse(System.Console.ReadLine());
                        System.Console.Write("Numero di giorni: ");
                        numeroDiGiorni = int.Parse(System.Console.ReadLine());
                        System.Console.Write("Costo: ");
                        costo = double.Parse(System.Console.ReadLine());

                        while (controllore)
                        {
                            System.Console.Write("Cliente (codice fiscale): ");
                            codiceFiscale = System.Console.ReadLine();

                            foreach (var c in gestoreNoleggi.Clienti)
                            {
                                if (c.CodiceFiscale == codiceFiscale)
                                {
                                    cliente = c;
                                    controllore = false;
                                }
                            }
                        }

                        while (controllore)
                        {
                            System.Console.WriteLine("Veicolo (targa): ");
                            targa = System.Console.ReadLine();

                            foreach (var v in gestoreNoleggi.Veicoli)
                            {
                                if (v.Targa == targa)
                                {
                                    veicolo = v;
                                    controllore = false;
                                }
                            }
                        }

                        gestoreNoleggi.Noleggi.Add(new Noleggio()
                        {
                            Id = id,
                            DataInizio = dataInzio,
                            NumeroDiGiorni = numeroDiGiorni,
                            Costo = costo,
                            Cliente = cliente,
                            Veicolo = veicolo
                        });

                        break;

                    case "4":
                        while (true)
                        {
                            System.Console.Write("Cliente (codice fiscale): ");
                            codiceFiscale = System.Console.ReadLine();

                            foreach (var c in gestoreNoleggi.Clienti)
                            {
                                if (c.CodiceFiscale == codiceFiscale)
                                    cliente = c;
                            }

                            System.Console.Write("Codice fiscale: ");
                            cliente.CodiceFiscale = System.Console.ReadLine();
                            System.Console.Write("Nome: ");
                            cliente.Nome = System.Console.ReadLine();
                            System.Console.Write("Cognome: ");
                            cliente.Cognome = System.Console.ReadLine();

                            return;
                        }
                        break;

                    case "5":
                        System.Console.WriteLine("Veicolo (targa): ");
                        targa = System.Console.ReadLine();

                        foreach (var v in gestoreNoleggi.Veicoli)
                        {
                            if (v.Targa == targa)
                                veicolo = v;
                        }

                        if (veicolo is Automobile)
                        {
                            var automobile = (Automobile)veicolo;

                            System.Console.Write("Targa: ");
                            automobile.Targa = System.Console.ReadLine();
                            System.Console.Write("Modello: ");
                            automobile.Modello = System.Console.ReadLine();
                            System.Console.Write("Tariffa: ");
                            automobile.Tariffa = int.Parse(System.Console.ReadLine());
                            System.Console.Write("Numero di posti: ");
                            automobile.NumeroDiPosti = int.Parse(System.Console.ReadLine());
                        }
                        else
                        {
                            var furgone = (Furgone)veicolo;

                            System.Console.Write("Targa: ");
                            furgone.Targa = System.Console.ReadLine();
                            System.Console.Write("Modello: ");
                            furgone.Modello = System.Console.ReadLine();
                            System.Console.Write("Tariffa: ");
                            furgone.Tariffa = int.Parse(System.Console.ReadLine());
                            System.Console.Write("Numero di posti: ");
                            furgone.CapacitaDiCarico = int.Parse(System.Console.ReadLine());
                        }
                            break;
                    case "6":
                        System.Console.WriteLine("Noleggio (Id): ");
                        id = System.Console.ReadLine();

                        foreach (var n in gestoreNoleggi.Noleggi)
                        {
                            if (n.Id == id)
                                noleggio = n;
                        }

                        System.Console.Write("Id: ");
                        noleggio.Id = System.Console.ReadLine();
                        System.Console.Write("Data inizio: ");
                        noleggio.DataInizio = DateTime.Parse(System.Console.ReadLine());
                        System.Console.Write("Numero di giorni: ");
                        noleggio.NumeroDiGiorni = int.Parse(System.Console.ReadLine());
                        System.Console.Write("Costo: ");
                        noleggio.Costo = double.Parse(System.Console.ReadLine());

                        while (controllore)
                        {
                            System.Console.Write("Cliente (codice fiscale): ");
                            codiceFiscale = System.Console.ReadLine();

                            foreach (var c in gestoreNoleggi.Clienti)
                            {
                                if (c.CodiceFiscale == codiceFiscale)
                                {
                                    noleggio.Cliente = c;
                                    controllore = false;
                                }
                            }
                        }

                        while (controllore)
                        {
                            System.Console.WriteLine("Veicolo (targa): ");
                            targa = System.Console.ReadLine();

                            foreach (var v in gestoreNoleggi.Veicoli)
                            {
                                if (v.Targa == targa)
                                {
                                    noleggio.Veicolo = v;
                                    controllore = false;
                                }
                            }
                        }
                        break;
                    case "7":
                        System.Console.WriteLine("Cliente (codice fiscale): ");
                        codiceFiscale = System.Console.ReadLine();

                        foreach (var c in gestoreNoleggi.Clienti)
                        {
                            if (c.CodiceFiscale == codiceFiscale)
                                gestoreNoleggi.Clienti.Remove(c);
                        }
                        break;

                    case "8":
                        System.Console.WriteLine("Veicolo (targa): ");
                        targa = System.Console.ReadLine();

                        foreach (var v in gestoreNoleggi.Veicoli)
                        {
                            if (v.Targa == targa)
                                gestoreNoleggi.Veicoli.Remove(v);
                        }
                        break;

                    case "9":
                        System.Console.WriteLine("Noleggio (Id): ");
                        id = System.Console.ReadLine();

                        foreach (var n in gestoreNoleggi.Noleggi)
                        {
                            if (n.Id == id)
                                gestoreNoleggi.Noleggi.Remove(n);
                        }
                        break;

                    case "10":
                        System.Console.WriteLine("Inserisci la targa: ");
                        targa = System.Console.ReadLine();
                        System.Console.WriteLine(gestoreNoleggi.GetPrezzoTotaleNoleggiDallaTarga(targa).ToString());
                        break;

                    case "11":
                        System.Console.WriteLine("Inserisci il codice fiscale: ");
                        codiceFiscale = System.Console.ReadLine();
                        System.Console.WriteLine(gestoreNoleggi.GetPrezzoTotaleNoleggiDalCodiceFiscale(codiceFiscale).ToString());
                        break;

                    case "12":
                        var listaNoleggi = gestoreNoleggi.GetPrezzoTotaleNoleggiPerAuto();

                        foreach (var n in listaNoleggi)
                        {
                            System.Console.WriteLine(n.ToString());
                        }
                        break;

                    case "13":
                        System.Console.WriteLine("Inserisci il file path: ");
                        string filePath = System.Console.ReadLine();

                        gestoreNoleggi.SalvaSuCSV_Veicoli(filePath);
                        gestoreNoleggi.SalvaSuCSV_Clienti(filePath);
                        gestoreNoleggi.SalvaSuCSV_Noleggi(filePath);
                        break;

                    case "14":
                        foreach (var c in gestoreNoleggi.Clienti)
                        {
                            System.Console.WriteLine(c);
                        }
                        break;

                    case "15":
                        foreach (var v in gestoreNoleggi.Veicoli)
                        {
                            System.Console.WriteLine(v);
                        }
                        break;

                    case "16":
                        foreach (var n in gestoreNoleggi.Noleggi)
                        {
                            System.Console.WriteLine(n);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
