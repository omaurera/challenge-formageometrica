using DevelopmentChallenge.Data.Helpers;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public decimal Lado { get; set; }

        public override Enums.Formas Tipo => Enums.Formas.Cuadrado;

        public override decimal CalcularArea() => Lado * Lado;

        public override decimal CalcularPerimetro() => Lado * 4;
    }
}
