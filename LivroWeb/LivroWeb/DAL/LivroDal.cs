using LivroWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivroWeb.DAL
{
    public class LivroDal : IDisposable
    {
        private LivroContext contexto;

        public LivroDal(LivroContext context)
        {
            this.contexto = context;
        }
        public void Adiciona(Livro livro)
        {
            contexto.TB_LIVRO.Add(livro);
            contexto.SaveChanges();
        }
        public IList<Livro> Lista()
        {
            return contexto.TB_LIVRO.ToList();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}