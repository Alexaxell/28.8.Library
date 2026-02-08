using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._8.Library.Winform
{
    public static class Archivio
    {
        public static List<Cliente> Clienti { get; } = new List<Cliente>();
        public static List<Veicolo> Veicoli { get; } = new List<Veicolo>();
        public static List<Noleggio> Noleggi { get; } = new List<Noleggio>();
    }
}
