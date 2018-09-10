using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblos.Models
{
    public class Livro
    {
        public Guid Codigo { get; set; }

        public string Nome { get; set; }

        public string Autor { get; set; }

        public int Ano { get; set; }

        public string Editora { get; set; }

        public string Assunto { get; set; }

        public string Isbn { get; set; }

        public bool Disponivel { get; set; }

        public Livro() { }

        public Livro(Guid codigo, string nome, string autor, int ano, string editora, string assunto, string isbn, bool disponivel)
        {
            Codigo = codigo;
            Nome = nome;
            Autor = autor;
            Ano = ano;
            Editora = editora;
            Assunto = assunto;
            Isbn = isbn;
            Disponivel = disponivel;
        }
    }
}
