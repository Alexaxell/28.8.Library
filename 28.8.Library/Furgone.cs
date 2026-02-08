namespace _28._8.Library
{
    public class Furgone : Veicolo
    {
        public double CapacitaDiCarico { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{CapacitaDiCarico}";
        }
    }
}