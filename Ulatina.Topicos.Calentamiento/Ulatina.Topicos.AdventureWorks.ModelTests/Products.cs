using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ulatina.Topicos.AdventureWorks.ModelTests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void ConvertirVeinticincoCentimetrosEnPulgadas()
        {
            //preparacion del escenario
            var elProducto = new Model.Product();
            elProducto.SizeUnitMeasureCode = "CM";
            elProducto.Size = "25";
            var elResultadoEsperado = "9.84 in";

            //ejecuto el méetodo correspondiente
            var elResultadoActual = elProducto.SizeInInches;

            // Verifico el estado del resultado

            Assert.AreEqual(elResultadoEsperado, elResultadoActual);

        }
    }
}
