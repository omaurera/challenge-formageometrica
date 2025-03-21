using DevelopmentChallenge.Data.Helpers;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal radio)
        {
            Radio = radio;
        }

        public decimal Radio { get; set; }

        public override Enums.Formas Tipo => Enums.Formas.Circulo;

        public override decimal CalcularArea() => (decimal)Math.PI * Radio * Radio;

        public override decimal CalcularPerimetro() => 2 * (decimal)Math.PI * Radio;
    }
}
