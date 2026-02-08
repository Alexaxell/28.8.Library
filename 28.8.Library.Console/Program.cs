using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._8.Library.Console
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Cliente cliente;
            Veicolo veicolo;


            while (scelta != "8")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("1. Inserisci un cliente");
                System.Console.WriteLine("2. Inserisci un veicolo");
                System.Console.WriteLine("3. Inserisci un noleggio");
                System.Console.WriteLine("4. Stampa il totale in euro dei noleggi data una targa");
                System.Console.WriteLine("5. Stampa il totale in euro dei noleggi dato un codice fiscale");
                System.Console.WriteLine("6. Stampa il totale in euro dei noleggi raggruppato per auto");
                System.Console.WriteLine("7. Carica i 3 dati su un file di testo in formato csv");
                System.Console.WriteLine("8. Esci...");
                System.Console.WriteLine();

                switch (scelta)
                {
                    case "1":
                        System.Console.Write("Codice fiscale: ");
                        codiceFiscale = System.Console.ReadLine();
                        System.Console.Write("Nome: ");
                        nome = System.Console.ReadLine();
                        System.Console.WriteLine("Cognome: ");
                        cognome = System.Console.ReadLine();
                        break;

                    case "2":
                        var tipoVeicolo = new Veicolo();

                        System.Console.Write("Tipo: ");
                        if (tipo.ToUpper() == "A")
                        {
                            var automobile = (Automobile)tipoVeicolo;
                            System.Console.Write("Targa: ");
                            targa = System.Console.ReadLine();
                            System.Console.Write("Modello: ");
                            modello = System.Console.ReadLine();
                            System.Console.Write("Tariffa: ");
                            tariffa = int.Parse(System.Console.ReadLine());
                            System.Console.Write("Numero di posti: ");
                            numeroDiPosti = int.Parse(System.Console.ReadLine());
                        }
                        else
                        {
                            var furgone = (Furgone)tipoVeicolo;
                            System.Console.Write("Targa: ");
                            targa = System.Console.ReadLine();
                            System.Console.Write("Modello: ");
                            modello = System.Console.ReadLine();
                            System.Console.Write("Tariffa: ");
                            tariffa = int.Parse(System.Console.ReadLine());
                            System.Console.Write("Capacità di carico: ");
                            capacitaDiCarico = int.Parse(System.Console.ReadLine());
                        }
                        break;

                    case "3":
                        System.Console.Write("Id: ");
                        id = System.Console.ReadLine();
                        System.Console.Write("Targa: ");
                        targa = System.Console.ReadLine();
                        System.Console.Write("Data inizio: ");
                        dataInzio = DateTime.Parse(System.Console.ReadLine());
                        System.Console.Write("Numero di giorni: ");
                        numeroDiGiorni = int.Parse(System.Console.ReadLine());
                        System.Console.Write("Costo: ");
                        costo = double.Parse(System.Console.ReadLine());
                        System.Console.Write("Cliente: ");
                        System.Console.WriteLine("Veicolo: ");
                        break;
                }
            }
        }
    }
}
