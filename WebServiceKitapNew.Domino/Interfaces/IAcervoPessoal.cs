using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceKitapNew.Dominio.DominioModel;

namespace WebServiceKitapNew.Dominio.Interfaces
{
    public interface IAcervoPessoal : IPesquisarExemplares
    {
        Task<bool> Adicionar(Exemplar exemplar);
        Task<bool> Remover(Exemplar exemplar);
    }
}
