using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WebServiceKitapNew.Dominio.Objetos.Auxiliares
{
    public class ISBNS
    {

        private List<string> _ArrayDeISBN;

        public ISBNS()
        {
            this._ArrayDeISBN = new List<string>();
        }

        public void AddISBN(string isbn)
        {
            if (!VerificarSeJaExite(isbn) && LimiteDeDois() && ValorVazio(isbn))
                this._ArrayDeISBN.Add(isbn);
        }

        public void AddISBN(List<string> listaDeIsbn)
        {
            this._ArrayDeISBN.AddRange(listaDeIsbn);
        }

        public List<String> GetListaISBN()
        {
            return this._ArrayDeISBN;
        }

        public bool isValido()
        {
            bool valido = true;

            if (_ArrayDeISBN.Count == 0)
                return false;

            foreach (var isbn in _ArrayDeISBN)
            {
                valido = (valido & VerificarContemSomenteNumero(isbn) & VerificarTipoEhCalculaDigitoVerificadorDoISBN(isbn));
            }
            return valido;
        }

        private bool VerificarContemSomenteNumero(string isbn)
        {
            string regex = @"^\d{10}$|^\d{13}$";

            return Regex.IsMatch(isbn, regex);
        }

        private bool VerificarTipoEhCalculaDigitoVerificadorDoISBN(string isbn)
        {
            if (isbn.Count() == 10)
                return this.CalcularDigitoVerificadorISBN10(isbn);

            else if (isbn.Count() == 13)
                return this.CalcularDigitoVerificadorISBN13(isbn);

            return false;

        }

        private bool CalcularDigitoVerificadorISBN10(string isbn)
        {

            int[] isbnNumerico = ConverteIsbnDeStringParaArrayDeInteiros(isbn);
            int totalDaSoma = 0, digitoVerificador;

            for (int peso = 1; peso <= 9; peso++)
            {
                totalDaSoma += (isbnNumerico[peso - 1] * peso);
            }

            digitoVerificador = totalDaSoma % 11;

            if (digitoVerificador == isbnNumerico[9])
                return true;

            return false;
        }

        private bool CalcularDigitoVerificadorISBN13(string isbn)
        {
            int[] isbnNumerico = ConverteIsbnDeStringParaArrayDeInteiros(isbn);
            int totalDaSoma = 0, digitoVerificador;

            for (int posicao = 1; posicao <= 12; posicao++)
            {
                totalDaSoma += (posicao % 2 == 0) ? isbnNumerico[posicao - 1] * 3 : isbnNumerico[posicao - 1];
            }

            digitoVerificador = 10 - (totalDaSoma % 10);

            if (digitoVerificador == isbnNumerico[12])
                return true;

            return false;
        }

        private int[] ConverteIsbnDeStringParaArrayDeInteiros(string isbn)
        {
            List<int> isbnNumerico = new List<int>();

            foreach (var valor in isbn)
            {
                int numero = Convert.ToInt32(Char.GetNumericValue(valor));
                isbnNumerico.Add(numero);
            }
            return isbnNumerico.ToArray();
        }

        private bool VerificarSeJaExite(string isbn)
        {
            return _ArrayDeISBN.Contains(isbn);
        }

        private bool LimiteDeDois()
        {
            return _ArrayDeISBN.Count <= 2;
        }

        private bool ValorVazio(string isbn)
        {
            return !isbn.Equals("") && !isbn.Equals(null)
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int cont = 1;
            foreach (var isbn in _ArrayDeISBN)
            {
                if (cont != _ArrayDeISBN.Count)
                    sb.Append(isbn + ", ");
                else
                    sb.Append(isbn);
            }


            return sb.ToString();
        }
    }
}