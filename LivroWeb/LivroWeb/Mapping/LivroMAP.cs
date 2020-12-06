using LivroWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LivroWeb.Mapping
{
    public class LivroMAP : EntityTypeConfiguration<Livro>
    {
        public LivroMAP()
        {
            ToTable("TB_LIVRO");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("LVR_ID");
            Property(x => x.Nome).HasColumnName("LVR_NOME");
            Property(x => x.Autor).HasColumnName("LVR_AUTOR");
            Property(x => x.Descricao).HasColumnName("LVR_DESCRICAO");
            Property(x => x.DataInicio).HasColumnName("LVR_DATA_INICIO");
            Property(x => x.DataFim).HasColumnName("LVR_DATA_FIM");
            Property(x => x.Tipo).HasColumnName("LVR_TIPO");
            Property(x => x.Nota).HasColumnName("LVR_NOTA");

        }
    }
}