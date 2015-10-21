using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceKitapNew.Dominio.DominioModel.Auxiliares;

namespace WebServiceKitapNew.Dominio.Tests
{
    [TestClass]
    public class AutoresTest
    {
        /*
         * Testes Sobre Autores
         * 1 - Testar Se Posso Adicionar O Mesmo Autor Duas Vezes;
         * 2 - Testar Se Autor Adicionado Consta na Lista;
         * 3 - Testar Se Posso Adicionar nome de Autor Vazio;
         * 4 - Testar Se Posso Adicionar nome de Autor Nulo;
         */
        [TestMethod]
        public void TestePassaCasoAutorAdicionadoConsteNaListaDeAutores()
        {
            string newAutor = "Michel Marques";
            Autores autores = new Autores();
            autores.AdicionarAutor(newAutor);
            Assert.IsTrue(autores.GetListaDeAutores().Contains(newAutor));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoAdicioneMesmoAutorNovamenteNaListaDeAutores()
        {
            string newAutor = "Michel Marques";
            Autores autores = new Autores();
            autores.AdicionarAutor(newAutor);
            autores.AdicionarAutor(newAutor);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoAdicioneNomeVazioNaListaDeAutores()
        {
            string newAutor = "";
            Autores autores = new Autores();
            autores.AdicionarAutor(newAutor);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TesteFalhaCasoAdicioneNomeNuloNaListaDeAutores()
        {
            string newAutor = null;
            Autores autores = new Autores();
            autores.AdicionarAutor(newAutor);
        }
    }
}
