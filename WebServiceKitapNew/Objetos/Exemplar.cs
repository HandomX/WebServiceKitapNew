using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceKitapNew.Core.Objetos
{
    public class Exemplar
    {
        public Guid Codigo { get; private set; }
        public string Titulo { get; private set; }
        public Autores Autores { get; private set; }
        public ISBNs ISBNs { get; private set; }
        public string Editora { get; private set; }
        public string Sinopse { get; private set; }
        public string Categoria { get; private set; }
        public int Paginas { get; private set; }
        public Status Status { get; private set; }
        public string NomeDoDono { get; private set; }

        public Exemplar(string Titulo, Autores Autores, ISBNs Isbns, string Editora, string Categoria, int Paginas, string NomeDoDono)
        {
            this.Codigo = Guid.NewGuid();
            this.Titulo = Titulo;
            this.Autores = Autores;
            this.ISBNs = Isbns;
            this.Editora = Editora;
            this.Categoria = Categoria;
            this.Paginas = Paginas;
            this.Status = Status.Disponivel;
            this.NomeDoDono = NomeDoDono;
        }

        public Exemplar(string Titulo, Autores Autores, ISBNs Isbns, string Editora, string Sinopse, string Categoria, int Paginas, string NomeDoDono)
        {
            this.Codigo = Guid.NewGuid();
            this.Titulo = Titulo;
            this.Autores = Autores;
            this.ISBNs = Isbns;
            this.Editora = Editora;
            this.Sinopse = Sinopse;
            this.Categoria = Categoria;
            this.Paginas = Paginas;
            this.Status = Status.Disponivel;
            this.NomeDoDono = NomeDoDono;
        }

        public bool isValido()
        {
            return ISBNs.isValido();
        }

    }
}
