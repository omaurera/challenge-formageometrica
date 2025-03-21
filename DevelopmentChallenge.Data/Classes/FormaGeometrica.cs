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

using DevelopmentChallenge.Data.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract Enums.Formas Tipo { get; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

        public static string Imprimir(List<FormaGeometrica> formas, Enums.Idiomas idioma)
        {
            Traductor traductor = new Traductor();
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{traductor.MensajeVacio(idioma)}</h1>");
            }
            else
            {
                sb.Append($"<h1>{traductor.MensajeReporte(idioma)}</h1>");

                var resumen = formas.GroupBy(f => f.Tipo)
                                    .Select(g => new
                                    {
                                        Tipo = g.Key,
                                        Cantidad = g.Count(),
                                        Area = g.Sum(f => f.CalcularArea()),
                                        Perimetro = g.Sum(f => f.CalcularPerimetro())
                                    });

                foreach (var item in resumen)
                {
                    sb.Append(traductor.MensajeForma(idioma, item.Tipo, item.Cantidad, item.Area, item.Perimetro));
                }

                sb.Append($"{traductor.TextoComunTraducido(idioma, "total")}:<br/>");
                sb.Append($"{formas.Count} {traductor.TextoComunTraducido(idioma, "formas")} ");
                sb.Append($"{traductor.TextoComunTraducido(idioma, "perímetro")} {resumen.Sum(r => r.Perimetro).ToString("#.##")} ");
                sb.Append($"{traductor.TextoComunTraducido(idioma, "área")} {resumen.Sum(r => r.Area).ToString("#.##")}");
            }

            return sb.ToString();
        }
    }
}
