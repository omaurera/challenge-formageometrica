using DevelopmentChallenge.Data.Helpers;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public decimal BaseMayor { get; set; }
        public decimal BaseMenor { get; set; }
        public decimal Altura { get; set; }
        public decimal Lado1 { get; set; }
        public decimal Lado2 { get; set; }

        public override Enums.Formas Tipo => Enums.Formas.Trapecio;

        public override decimal CalcularArea() => ((BaseMayor + BaseMenor) / 2) * Altura;

        public override decimal CalcularPerimetro() => BaseMayor + BaseMenor + Lado1 + Lado2;
    }
}
