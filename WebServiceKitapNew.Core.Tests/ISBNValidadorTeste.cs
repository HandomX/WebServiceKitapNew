using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceKitapNew.Core.Objetos;

namespace WebServiceKitap.Core.Tests
{
    /*
        - Testar Se Ao Adicionar um isbn qualquer ele consta na lista
        - Testar Se 1 ISBN adicionado tem so digitos
        - Testar Se 1 ISBN adicionado e igual a 10 digitos
        - Testar Se 1 ISBN adicionado e igual a 13 digitos
        - Testar Se 1 ISBN de 10 digitos adicionado e valido
        - Testar Se 1 ISBN de 13 digitos adicionado e valido
        - Testar se 1 ISBN de 10 e 1 ISBN de 13 digitos adicionados sao validos
        - Testar se 1 ISBN de 10 valido e 1 ISBN 13 invalido adicionados sao invalidos
        */
    [TestClass]
    public class ISBNValidadorTeste
    {
        
        
        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_Qualquer_Ele_Deve_Constar_Na_Lista_Do_Validador()
        {
            string isbn = "232546465546";

            ISBNs isbns = new ISBNs();
            
            isbns.AddISBN(isbn);

            Assert.IsTrue(isbns.GetListaISBN().Contains(isbn));
        }

        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_Verificar_Se_Ele_Contem_So_Numeros()
        {
            string isbn = "853630561a";

            ISBNs isbns = new ISBNs();

            isbns.AddISBN(isbn);

            Assert.IsFalse(isbns.isValido());
        }

        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_Menor_Que_10_Digitos_Eh_Invalido()
        {
            string isbn = "32563667";

            ISBNs isbns = new ISBNs();

            isbns.AddISBN(isbn);

            Assert.IsFalse(isbns.isValido());
        }

        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_Maior_Que_13_Digitos_Eh_Invalido()
        {
            string isbn = "86765678904325";

            ISBNs isbns = new ISBNs();

            isbns.AddISBN(isbn);

            Assert.IsFalse(isbns.isValido());
        }

        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_De_10_Digito_Calcular_Digito_Verificador()
        {
            string isbn = "1234443267";

            ISBNs isbns = new ISBNs();

            isbns.AddISBN(isbn);

            Assert.IsFalse(isbns.isValido());
        }

        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_De_13_Digito_Calcular_Digito_Verificador()
        {
            string isbn = "9788577803064";

            ISBNs isbns = new ISBNs();

            isbns.AddISBN(isbn);

            Assert.IsTrue(isbns.isValido());
        }

        [TestMethod]
        public void Ao_Adicionar_Um_Isbn_De_10_Valido_Eh_Um_Isbn_De_13_Invalido()
        {
            ISBNs isbns = new ISBNs();
            isbns.AddISBN("8577803066");
            isbns.AddISBN("9788577803066");

            Assert.IsFalse(isbns.isValido());
        }

        [TestMethod]
        public void Ao_Adicionar_Dois_Isbn_Vazio_Eh_Invalido()
        {
            ISBNs isbns = new ISBNs();
            isbns.AddISBN("");
            isbns.AddISBN("");

            Assert.IsFalse(isbns.isValido());
        }

    }
}
