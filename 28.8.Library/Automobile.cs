namespace _28._8.Library
{
    public class Automobile : Veicolo
    {
        public int NumeroDiPosti { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{NumeroDiPosti}";
        }
    }
}