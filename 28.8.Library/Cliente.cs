using System.Collections.Generic;

namespace _28._8.Library
{
    public class Cliente
    {
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public override string ToString()
        {
            return $"{CodiceFiscale} {Nome} {Cognome}";
        }
    }
}