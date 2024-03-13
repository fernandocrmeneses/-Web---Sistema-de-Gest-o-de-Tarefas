using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWeb.GestaoTarefa.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Data.Mappings
{
    internal class GestorMapping : IEntityTypeConfiguration<GestorEntidade>
    {
        public void Configure(EntityTypeBuilder<GestorEntidade> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.ToTable("GESTORES");
        }
    }
}
