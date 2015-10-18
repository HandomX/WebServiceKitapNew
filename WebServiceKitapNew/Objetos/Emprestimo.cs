using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceKitapNew.Core.Objetos.Auxiliares;

namespace WebServiceKitapNew.Core.Objetos
{
    public class Emprestimo
    {
        public IntervaloData Periodo { get; private set; }
        public string Status { get; private set; }
        private bool Comfimado;

        public Emprestimo(IntervaloData periodo)
        {
            this.Periodo = periodo;
            this.Status = EStatus.Andamento;
            this.Comfimado = false;
        }
    }
}
