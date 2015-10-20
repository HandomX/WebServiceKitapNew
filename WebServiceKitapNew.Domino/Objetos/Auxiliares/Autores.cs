using System.Collections.Generic;
using System.Text;

namespace WebServiceKitapNew.Dominio.Objetos.Auxiliares
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
            if(!VerificarSeExite(nome) && LimiteDeDois() )
                _Autores.Add(nome);
        }

        private bool VerificarSeExite(string nome)
        {
            return _Autores.Contains(nome);
        }
        
        private bool LimiteDeDois()
        {
            return _Autores.Count <= 2;
        }

        public List<string> GetListaDeAutores()
        {
            return _Autores;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int cont = 1;
            foreach(var nome in _Autores)
            {
                if (cont != _Autores.Count)
                    sb.Append(nome + ", ");
                else
                    sb.Append(nome);
            }

            
            return sb.ToString();
        }
    }
}