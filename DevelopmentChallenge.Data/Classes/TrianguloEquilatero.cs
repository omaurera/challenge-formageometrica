using DevelopmentChallenge.Data.Helpers;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public decimal Lado { get; set; }

        public override Enums.Formas Tipo => Enums.Formas.TrianguloEquilatero;

        public override decimal CalcularArea() => (decimal)Math.Sqrt(3) / 4 * Lado * Lado;

        public override decimal CalcularPerimetro() => Lado * 3;
    }
}
