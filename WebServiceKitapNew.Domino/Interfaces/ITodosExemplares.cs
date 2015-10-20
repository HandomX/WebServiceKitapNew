using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceKitapNew.Dominio.Objetos;
using WebServiceKitapNew.Dominio.Objetos.Auxiliares;

namespace WebServiceKitapNew.Dominio.Interfaces
{
    public interface ITodosExemplares
    {
        Task<Exemplar> PorISBN(string isbn);
        Task<List<Exemplar>> PorUsuario();
        Task<List<Exemplar>> PorTitulo(string titulo, IntervaloDeQuantidade intevaloDeQuantidade);
        Task<List<Exemplar>> PorEditora(string editora, IntervaloDeQuantidade intevaloDeQuantidade);
        Task<List<Exemplar>> PorCategoria(string categoria, IntervaloDeQuantidade intevaloDeQuantidade);
        Task<List<Exemplar>> PorAutor(string autor, IntervaloDeQuantidade intevaloDeQuantidade);
        Task<List<Exemplar>> Todos(IntervaloDeQuantidade intevaloDeQuantidade);
    }
}
