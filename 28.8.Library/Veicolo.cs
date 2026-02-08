using System.Collections.Generic;

namespace _28._8.Library
{
    public class Veicolo
    {
        public string Targa { get; set; }
        public string Modello { get; set; }
        public double Tariffa { get; set; }
        public List<Noleggio> Noleggi { get; set; }
    }
}