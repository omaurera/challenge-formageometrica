using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Helpers;
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
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, Enums.Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas!</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Enums.Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report!</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report!</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52,03 | Perimeter 36,13 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 Shapes Perimeter 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Cuadrado (2),
                new Circulo (3),
                new Circulo (2.75m),
                new TrianguloEquilatero (4),
                new TrianguloEquilatero (9),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas!</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 52,03 | Perímetro 36,13 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 Formas Perímetro 115,73 Área 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConRectanguloEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(10, 15)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli!</h1>1 Rettangolo | Zona 150 | Perimetro 50 <br/>TOTALE:<br/>1 Forme Perimetro 50 Zona 150",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapecioEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(12, 7, 8, 5, 4)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Enums.Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report!</h1>1 Trapeze | Area 76 | Perimeter 28 <br/>TOTAL:<br/>1 Shapes Perimeter 28 Area 76",
                resumen);
        }
    }
}
