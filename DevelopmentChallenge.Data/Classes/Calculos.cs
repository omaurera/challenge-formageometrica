using System;
namespace DevelopmentChallenge.Data.Classes
{
	public class Calculos
	{
        public decimal CalcularArea(FormaGeometrica forma)
        {
            switch (forma.Tipo)
            {
                case Enums.Formas.Cuadrado: return forma.Lado * forma.Lado;
                case Enums.Formas.Circulo: return (decimal)Math.PI * (forma.Lado / 2) * (forma.Lado / 2);
                case Enums.Formas.TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * forma.Lado * forma.Lado;
                case Enums.Formas.Trapecio: return ((decimal)Math.Sqrt(4) / 4) * forma.Lado * forma.Lado;
                case Enums.Formas.Rectangulo: return forma.Altura * forma.Base;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro(FormaGeometrica forma)
        {
            switch (forma.Tipo)
            {
                case Enums.Formas.Cuadrado: return forma.Lado * 4;
                case Enums.Formas.Circulo: return (decimal)Math.PI * forma.Lado;
                case Enums.Formas.TrianguloEquilatero: return forma.Lado * 3;
                case Enums.Formas.Trapecio: return forma.Lado * forma.Lado;
                case Enums.Formas.Rectangulo: return (2 * forma.Altura) + (2 * forma.Base);
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}

