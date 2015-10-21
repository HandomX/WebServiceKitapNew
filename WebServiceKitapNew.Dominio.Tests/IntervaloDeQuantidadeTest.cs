using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceKitapNew.Dominio.DominioModel.Auxiliares;

namespace WebServiceKitapNew.Dominio.Tests
{
    /*
         * 1 - Testar Se Posso Instanciar Um IntervaloDeQuantidade Com inicio Menor ou Igual a zero; 
         * 2 - Testar Se Posso Instanciar Um IntervaloDeQuantidade Com total Menor ou Igual a zero;
         * 3 - Testar Se Posso Resetar Valor Inicial Caso Seja Menor ou Igual a zero;
         * 4 - Testar Se Posso Resetar Valor total caso Seja Menor ou Igual a zero;
         */

    [TestClass]
    public class IntervaloDeQuantidadeTest
    {
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoValorInicialPassadoNoContrutorSejaNegativo()
        {
            int valorDeInicio = -12;
            IntervaloDeQuantidade intevalo = new IntervaloDeQuantidade(valorDeInicio);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoValorTotalPassadoNoContrutorSejaNegativo()
        {
            int valorDeInicio = 1;
            int valorTotal = -4;
            IntervaloDeQuantidade intevalo = new IntervaloDeQuantidade(valorDeInicio, valorTotal);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoValorDeInicioPassoNoMetodoDeResetarInicioSejaNegativo()
        {
            int inicio = 1;
            int total = 4;
            IntervaloDeQuantidade intevalo = new IntervaloDeQuantidade(inicio, total);

            int novoInicio = -8;
            intevalo.ResetarInicio(novoInicio);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoValorDeInicioPassoNoMetodoDeResetarTotalSejaNegativo()
        {
            int inicio = 1;
            int total = 4;
            IntervaloDeQuantidade intevalo = new IntervaloDeQuantidade(inicio, total);

            int novoTotal = -8;
            intevalo.ResetarTotal(novoTotal);
        }


    }
}
