using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceKitapNew.Core.Objetos.Auxiliares;

namespace WebServiceKitapNew.Core.Objetos
{
    public class Pedido
    {
        public string NomeDoDono { get; private set; }
        public string NomeDoPedinti { get; private set; }
        public string TituloDoLivro { get; private set; }
        public Tempo Tempo { get; private set; }
        public string Status { get; private set; }

        public Pedido(string nomeDoDono, string nomeDoPedinti, string tituloDoLivro, Tempo tempo)
        {
            this.NomeDoDono = nomeDoDono;
            this.NomeDoPedinti = nomeDoPedinti;
            this.TituloDoLivro = tituloDoLivro;
            this.Tempo = tempo;
            this.Status = EStatus.Andamento;
        }

        public void Confirma()
        {

        }

        public void Negar()
        {

        }

        public void Cancelar()
        {

        }
    }
}
