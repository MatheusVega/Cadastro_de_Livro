using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivroWeb.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string Tipo { get; set; }
        public string Nota { get; set; }
    }
}