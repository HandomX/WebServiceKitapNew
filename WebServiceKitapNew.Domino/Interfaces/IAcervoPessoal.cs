using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceKitapNew.Dominio.Objetos;

namespace WebServiceKitapNew.Dominio.Interfaces
{
    public interface IAcervoPessoal : ITodosExemplares
    {
        Task<bool> Adicionar(Exemplar exemplar);
        Task<Exemplar> Remover(Guid codigoExemplar);
    }
}
