using System;

namespace _28._8.Library
{
    public class Noleggio
    {
        public string Id { get; set; }
        public DateTime DataInizio { get; set; }
        public int NumeroDiGiorni { get; set; }
        public double Costo{ get; set; }
        public Cliente Cliente { get; set; }
        public Veicolo Veicolo { get; set; }
    }
}