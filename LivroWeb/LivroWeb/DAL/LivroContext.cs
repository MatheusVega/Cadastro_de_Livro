using LivroWeb.Mapping;
using LivroWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LivroWeb.DAL
{
    public class LivroContext : DbContext
    {
        public LivroContext() : base("Data Source=.;Initial Catalog=DBLivro;Integrated Security=True")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LivroMAP());

        }


        public DbSet<Livro> TB_LIVRO { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}