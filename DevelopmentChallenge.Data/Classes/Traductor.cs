namespace DevelopmentChallenge.Data.Classes
{
    public class Traductor
	{
		public string MensajesTraducidos(Enums.Idiomas idioma, string texto)
		{
			switch (texto.ToLower())
			{
				case "vacio":
					return NoHayForma(idioma);
                case "reporte":
                    return ReporteForma(idioma);
            }

            return string.Empty;
        }

		private string NoHayForma(Enums.Idiomas idioma)
		{
			switch (idioma)
			{
				case Enums.Idiomas.Castellano:
					return "Lista vacía de formas!";
				case Enums.Idiomas.Ingles:
					return "Empty list of shapes!";
                case Enums.Idiomas.Italiano:
                    return "Elenco vuoto di forme!";
                case Enums.Idiomas.Portugues:
                    return "Lista vazia de formas!";
            }

            return string.Empty;
        }

        private string ReporteForma(Enums.Idiomas idioma)
        {
            switch (idioma)
            {
                case Enums.Idiomas.Castellano:
                    return "Reporte de Formas!";
                case Enums.Idiomas.Ingles:
                    return "Shapes report!";
                case Enums.Idiomas.Italiano:
                    return "Rapporto sui moduli!";
                case Enums.Idiomas.Portugues:
                    return "Relatório de formulários!";
            }

            return string.Empty;
        }

        public string TraducirForma(Enums.Formas forma, int cantidad, Enums.Idiomas idioma)
        {
            switch (forma)
            {
                case Enums.Formas.Cuadrado:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? "Square" : "Squares";
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? "Piazza" : "Piazze";
                    else
                        return cantidad == 1 ? "Quadrado" : "Quadrados";
                case Enums.Formas.Circulo:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? "Círculo" : "Círculos";
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? "Circle" : "Circles";
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? "Cerchio" : "Cerchi";
                    else
                        return cantidad == 1 ? "Círculo" : "Círculos";
                case Enums.Formas.TrianguloEquilatero:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? "Triangle" : "Triangles";
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? "Triangolo" : "Triangoli";
                    else
                        return cantidad == 1 ? "Triângulo" : "Triângulos";
                case Enums.Formas.Trapecio:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? "Trapecio" : "Trapecios";
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? "Trapeze" : "Trapeze";
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? "Trapezio" : "Trapezio";
                    else
                        return cantidad == 1 ? "Trapézio" : "Trapézio";
                case Enums.Formas.Rectangulo:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? "Rectángulo" : "Rectángulos";
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? "Rectangle" : "Rectangles";
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                    else
                        return cantidad == 1 ? "Retângulo" : "Retângulos";
            }

            return string.Empty;
        }

        public string TextoComunTraducido(Enums.Idiomas idioma, string texto)
        {
            switch (idioma)
            {
                case Enums.Idiomas.Castellano:
                    if (texto.ToLower() == "area")
                        return "Area";
                    else if (texto.ToLower() == "perimetro")
                        return "Perimetro";
                    else if (texto.ToLower() == "formas")
                        return "formas";
                    else if (texto.ToLower() == "total")
                        return "TOTAL";
                    else
                        return "Forma desconocida";
                case Enums.Idiomas.Ingles:
                    if (texto.ToLower() == "area")
                        return "Area";
                    else if (texto.ToLower() == "perimetro")
                        return "Perimeter";
                    else if (texto.ToLower() == "formas")
                        return "shapes";
                    else if (texto.ToLower() == "total")
                        return "TOTAL";
                    else
                        return "Unknown shapes";
                case Enums.Idiomas.Italiano:
                    if (texto.ToLower() == "area")
                        return "Zona";
                    else if (texto.ToLower() == "perimetro")
                        return "Perimetro";
                    else if (texto.ToLower() == "formas")
                        return "forme";
                    else if (texto.ToLower() == "total")
                        return "TOTALE";
                    else
                        return "Forme sconosciute";
                case Enums.Idiomas.Portugues:
                    if (texto.ToLower() == "area")
                        return "Area";
                    else if (texto.ToLower() == "perimetro")
                        return "Perimetro";
                    else if (texto.ToLower() == "formas")
                        return "formas";
                    else if (texto.ToLower() == "total")
                        return "TOTAL";
                    else
                        return "Forma desconhecidas";
            }

            return string.Empty;
        }
    }
}

