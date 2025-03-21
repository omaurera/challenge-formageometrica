using DevelopmentChallenge.Data.Helpers;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public Rectangulo(decimal largo, decimal ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }

        public override Enums.Formas Tipo => Enums.Formas.Rectangulo;

        public override decimal CalcularArea() => Largo * Ancho;

        public override decimal CalcularPerimetro() => 2 * (Largo + Ancho);
    }
}
