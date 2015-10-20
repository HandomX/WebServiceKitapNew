using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceKitapNew.Dominio.Objetos.Auxiliares;

namespace WebServiceKitapNew.Dominio.Objetos
{
    public class Exemplar
    {
        public Guid Codigo { get; private set; }
        public string Titulo { get; private set; }
        public Autores Autores { get; private set; }
        public ISBNS ISBNs { get; private set; }
        public string Editora { get; private set; }
        public string Sinopse { get; private set; }
        public string Categoria { get; private set; }
        public int Paginas { get; private set; }
        public string Status { get; private set; }
        public string NomeDoDono { get; private set; }

        public Exemplar(string titulo, Autores autores, ISBNS isbns, string editora, string categoria, int paginas, string nomeDoDono, string status)
        {
            this.Codigo = Guid.NewGuid();
            this.Titulo = titulo;
            this.Autores = autores;
            this.ISBNs = isbns;
            this.Editora = editora;
            this.Categoria = categoria;
            this.Paginas = paginas;
            this.Status = status;
            this.NomeDoDono = nomeDoDono;
        }

        public Exemplar(string titulo, Autores autores, ISBNS isbns, string editora, string sinopse, string categoria, int paginas, string nomeDoDono, string status)
        {
            this.Codigo = Guid.NewGuid();
            this.Titulo = titulo;
            this.Autores = autores;
            this.ISBNs = isbns;
            this.Editora = editora;
            this.Sinopse = sinopse;
            this.Categoria = categoria;
            this.Paginas = paginas;
            this.Status = status;
            this.NomeDoDono = NomeDoDono;
        }

        public Exemplar(Guid id, string titulo, Autores autores, ISBNS isbns, string editora, string sinopse, string categoria, int paginas, string nomeDoDono, string status)
        {
            this.Codigo = id;
            this.Titulo = titulo;
            this.Autores = autores;
            this.ISBNs = isbns;
            this.Editora = editora;
            this.Sinopse = sinopse;
            this.Categoria = categoria;
            this.Paginas = paginas;
            this.Status = status;
            this.NomeDoDono = NomeDoDono;
        }       

    }
}
