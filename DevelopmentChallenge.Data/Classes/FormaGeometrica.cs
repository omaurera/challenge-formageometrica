/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Recursos;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public decimal Lado;
        public Enums.Formas Tipo { get; set; }
        public decimal? Base { get; set; }
        public decimal? Altura { get; set; }


        public FormaGeometrica(Enums.Formas tipo, decimal ancho, decimal? _base, decimal? altura)
        {
            Tipo = tipo;
            Lado = ancho;
            Base = _base;
            Altura = altura;
        }

        public static string Imprimir(List<FormaGeometrica> formas, Enums.Idiomas idioma)
        {
            Traductor traductor = new Traductor();
            Calculos calculos = new Calculos();
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{traductor.MensajeVacio(idioma)}</h1>");
            }
            else
            {
                sb.Append($"<h1>{traductor.MensajeReporte(idioma)}</h1>");

                Forma formaCuadrado = new Forma();
                Forma formaCirculo = new Forma();
                Forma formaTriangulo = new Forma();
                Forma formaTrapecio = new Forma();
                Forma formaRectangulo = new Forma();
                for (var i = 0; i < formas.Count; i++)
                {
                    switch (formas[i].Tipo)
                    {
                        case Enums.Formas.Cuadrado:
                            formaCuadrado.Cantidad++;
                            formaCuadrado.Area = calculos.CalcularArea(formas[i]);
                            formaCuadrado.Perimetro = calculos.CalcularPerimetro(formas[i]);
                            formaCuadrado.Tipo = formas[i].Tipo;
                            break;
                        case Enums.Formas.Circulo:
                            formaCirculo.Cantidad++;
                            formaCirculo.Area = calculos.CalcularArea(formas[i]);
                            formaCirculo.Perimetro = calculos.CalcularPerimetro(formas[i]);
                            formaCirculo.Tipo = formas[i].Tipo;
                            break;
                        case Enums.Formas.TrianguloEquilatero:
                            formaTriangulo.Cantidad++;
                            formaTriangulo.Area = calculos.CalcularArea(formas[i]);
                            formaTriangulo.Perimetro = calculos.CalcularPerimetro(formas[i]);
                            formaTriangulo.Tipo = formas[i].Tipo;
                            break;
                        case Enums.Formas.Trapecio:
                            formaTrapecio.Cantidad++;
                            formaTrapecio.Area = calculos.CalcularArea(formas[i]);
                            formaTrapecio.Perimetro = calculos.CalcularPerimetro(formas[i]);
                            formaTrapecio.Tipo = formas[i].Tipo;
                            break;
                        case Enums.Formas.Rectangulo:
                            formaRectangulo.Cantidad++;
                            formaRectangulo.Area = calculos.CalcularArea(formas[i]);
                            formaRectangulo.Perimetro = calculos.CalcularPerimetro(formas[i]);
                            formaRectangulo.Tipo = formas[i].Tipo;
                            break;
                        default:
                            break;
                    }
                }
                
                sb.Append(traductor.MensajeForma(idioma, formaCuadrado.Tipo, formaCuadrado.Cantidad, formaCuadrado.Area, formaCuadrado.Perimetro));
                sb.Append(traductor.MensajeForma(idioma, formaCirculo.Tipo, formaCirculo.Cantidad, formaCirculo.Area, formaCirculo.Perimetro));
                sb.Append(traductor.MensajeForma(idioma, formaTriangulo.Tipo, formaTriangulo.Cantidad, formaTriangulo.Area, formaTriangulo.Perimetro));
                sb.Append(traductor.MensajeForma(idioma, formaTrapecio.Tipo, formaTrapecio.Cantidad, formaTrapecio.Area, formaTrapecio.Perimetro));
                sb.Append(traductor.MensajeForma(idioma, formaRectangulo.Tipo, formaRectangulo.Cantidad, formaRectangulo.Area, formaRectangulo.Perimetro));

                sb.Append($"{traductor.TextoComunTraducido(idioma, "total")}:<br/>");
                sb.Append($"{formaCuadrado.Cantidad + formaCirculo.Cantidad + formaTriangulo.Cantidad + formaTrapecio.Cantidad + formaRectangulo.Cantidad} {traductor.TextoComunTraducido(idioma, "formas")} ");
                sb.Append($"{traductor.TextoComunTraducido(idioma, "perímetro")} {(formaCuadrado.Perimetro + formaCirculo.Perimetro + formaTriangulo.Perimetro + formaTrapecio.Perimetro + formaRectangulo.Perimetro).ToString("#.##")} ");
                sb.Append($"{traductor.TextoComunTraducido(idioma, "área")} {(formaCuadrado.Area + formaCirculo.Area + formaTriangulo.Area + formaTrapecio.Area + formaRectangulo.Area).ToString("#.##")}");
            }

            return sb.ToString();
        }
    }
}
