using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Enums.Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Enums.Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Enums.Idiomas.Italiano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Enums.Idiomas.Portugues));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new FormaGeometrica(Enums.Formas.Cuadrado, 5, null, null)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, Enums.Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas!</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(Enums.Formas.Cuadrado, 5, null, null),
                new FormaGeometrica(Enums.Formas.Cuadrado, 1, null, null),
                new FormaGeometrica(Enums.Formas.Cuadrado, 3, null, null)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Enums.Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report!</h1>3 Squares | Area 9 | Perimeter 12 <br/>TOTAL:<br/>3 shapes Perimeter 12 Area 9", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Enums.Formas.Cuadrado, 5, null, null),
                new FormaGeometrica(Enums.Formas.Circulo, 3, null, null),
                new FormaGeometrica(Enums.Formas.TrianguloEquilatero, 4, null, null),
                new FormaGeometrica(Enums.Formas.Cuadrado, 2, null, null),
                new FormaGeometrica(Enums.Formas.TrianguloEquilatero, 9, null, null),
                new FormaGeometrica(Enums.Formas.Circulo, 2.75m, null, null),
                new FormaGeometrica(Enums.Formas.TrianguloEquilatero, 4.2m, null, null)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report!</h1>2 Squares | Area 4 | Perimeter 8 <br/>2 Circles | Area 5,94 | Perimeter 8,64 <br/>3 Triangles | Area 7,64 | Perimeter 12,6 <br/>TOTAL:<br/>7 shapes Perimeter 29,24 Area 17,58",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Enums.Formas.Cuadrado, 5, null, null),
                new FormaGeometrica(Enums.Formas.Circulo, 3, null, null),
                new FormaGeometrica(Enums.Formas.TrianguloEquilatero, 4, null, null),
                new FormaGeometrica(Enums.Formas.Cuadrado, 2, null, null),
                new FormaGeometrica(Enums.Formas.TrianguloEquilatero, 9, null, null),
                new FormaGeometrica(Enums.Formas.Circulo, 2.75m, null, null),
                new FormaGeometrica(Enums.Formas.TrianguloEquilatero, 4.2m, null, null)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas!</h1>2 Cuadrados | Area 4 | Perimetro 8 <br/>2 Círculos | Area 5,94 | Perimetro 8,64 <br/>3 Triángulos | Area 7,64 | Perimetro 12,6 <br/>TOTAL:<br/>7 formas Perimetro 29,24 Area 17,58",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConRectanguloEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Enums.Formas.Rectangulo, 5, 7, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli!</h1>1 Rettangolo | Zona 35 | Perimetro 24 <br/>TOTALE:<br/>1 forme Perimetro 24 Zona 35",
                resumen);
        }
    }
}
