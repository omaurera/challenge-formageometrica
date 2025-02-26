using DevelopmentChallenge.Data.Recursos;

namespace DevelopmentChallenge.Data.Classes
{
    public class Traductor
	{
        public string MensajeVacio(Enums.Idiomas idioma)
        {
            switch (idioma)
            {
                case Enums.Idiomas.Castellano:
                    return Castellano.Vacio;
                case Enums.Idiomas.Ingles:
                    return Ingles.Vacio;
                case Enums.Idiomas.Italiano:
                    return Italiano.Vacio;
                case Enums.Idiomas.Portugues:
                    return Portugues.Vacio;
            }

            return string.Empty;
        }

        public string MensajeReporte(Enums.Idiomas idioma)
        {
            switch (idioma)
            {
                case Enums.Idiomas.Castellano:
                    return Castellano.Reporte;
                case Enums.Idiomas.Ingles:
                    return Ingles.Reporte;
                case Enums.Idiomas.Italiano:
                    return Italiano.Reporte;
                case Enums.Idiomas.Portugues:
                    return Portugues.Reporte;
            }

            return string.Empty;
        }

        public string MensajeForma(Enums.Idiomas idioma, Enums.Formas tipo, int cantidad, decimal area, decimal perimetro)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | {TextoComunTraducido(idioma, "área")} {area:#.##} | {TextoComunTraducido(idioma, "perímetro")} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string TextoComunTraducido(Enums.Idiomas idioma, string texto)
        {
            switch (idioma)
            {
                case Enums.Idiomas.Castellano:
                    if (texto.ToLower() == Castellano.Area.ToLower())
                        return Castellano.Area;
                    else if (texto.ToLower() == Castellano.Perimetro.ToLower())
                        return Castellano.Perimetro;
                    else if (texto.ToLower() == Castellano.Formas.ToLower())
                        return Castellano.Formas;
                    else if (texto.ToLower() == Castellano.Total.ToLower())
                        return Castellano.Total.ToUpper();
                    else
                        return Castellano.FormaDesconocida;
                case Enums.Idiomas.Ingles:
                    if (texto.ToLower() == Castellano.Area.ToLower())
                        return Ingles.Area;
                    else if (texto.ToLower() == Castellano.Perimetro.ToLower())
                        return Ingles.Perimetro;
                    else if (texto.ToLower() == Castellano.Formas.ToLower())
                        return Ingles.Formas;
                    else if (texto.ToLower() == Castellano.Total.ToLower())
                        return Ingles.Total.ToUpper();
                    else
                        return Ingles.FormaDesconocida;
                case Enums.Idiomas.Italiano:
                    if (texto.ToLower() == Castellano.Area.ToLower())
                        return Italiano.Area;
                    else if (texto.ToLower() == Castellano.Perimetro.ToLower())
                        return Italiano.Perimetro;
                    else if (texto.ToLower() == Castellano.Formas.ToLower())
                        return Italiano.Formas;
                    else if (texto.ToLower() == Castellano.Total.ToLower())
                        return Italiano.Total.ToUpper();
                    else
                        return Italiano.FormaDesconocida;
                case Enums.Idiomas.Portugues:
                    if (texto.ToLower() == Castellano.Area.ToLower())
                        return Portugues.Area;
                    else if (texto.ToLower() == Castellano.Perimetro.ToLower())
                        return Portugues.Perimetro;
                    else if (texto.ToLower() == Castellano.Formas.ToLower())
                        return Portugues.Formas;
                    else if (texto.ToLower() == Castellano.Total.ToLower())
                        return Portugues.Total.ToUpper();
                    else
                        return Portugues.FormaDesconocida;
            }

            return string.Empty;
        }

        private string TraducirForma(Enums.Formas forma, int cantidad, Enums.Idiomas idioma)
        {
            switch (forma)
            {
                case Enums.Formas.Cuadrado:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? Castellano.Cuadrado : Castellano.Cuadrados;
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? Ingles.Cuadrado : Ingles.Cuadrados;
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? Italiano.Cuadrado : Italiano.Cuadrados;
                    else
                        return cantidad == 1 ? Portugues.Cuadrado : Portugues.Cuadrados;
                case Enums.Formas.Circulo:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? Castellano.Circulo : Castellano.Circulos;
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? Ingles.Circulo : Ingles.Circulos;
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? Italiano.Circulo : Italiano.Circulos;
                    else
                        return cantidad == 1 ? Portugues.Circulo : Portugues.Circulos;
                case Enums.Formas.TrianguloEquilatero:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? Castellano.Triangulo : Castellano.Triangulos;
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? Ingles.Triangulo : Ingles.Triangulos;
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? Italiano.Triangulo : Italiano.Triangulos;
                    else
                        return cantidad == 1 ? Portugues.Triangulo : Portugues.Triangulos;
                case Enums.Formas.Trapecio:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? Castellano.Trapecio : Castellano.Trapecios;
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? Ingles.Trapecio : Ingles.Trapecios;
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? Italiano.Trapecio : Italiano.Trapecios;
                    else
                        return cantidad == 1 ? Portugues.Trapecio : Portugues.Trapecios;
                case Enums.Formas.Rectangulo:
                    if (idioma == Enums.Idiomas.Castellano)
                        return cantidad == 1 ? Castellano.Rectangulo : Castellano.Rectangulos;
                    else if (idioma == Enums.Idiomas.Ingles)
                        return cantidad == 1 ? Ingles.Rectangulo : Ingles.Rectangulos;
                    else if (idioma == Enums.Idiomas.Italiano)
                        return cantidad == 1 ? Italiano.Rectangulo : Italiano.Rectangulos;
                    else
                        return cantidad == 1 ? Portugues.Rectangulo : Portugues.Rectangulos;
            }

            return string.Empty;
        }
    }
}

