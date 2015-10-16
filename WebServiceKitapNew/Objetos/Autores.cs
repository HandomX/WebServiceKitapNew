using System.Collections.Generic;

namespace WebServiceKitapNew.Core.Objetos
{
    public class Autores
    {
        private List<string> _Autores;

        public Autores()
        {
            this._Autores = new List<string>();
        }

        public void AdicionarAutor(string nome)
        {
            _Autores.Add(nome);
        }

        public List<string> GetListaDeAutores()
        {
            return _Autores;
        }
    }
}