using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWeb.GestaoTarefa.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Data.Mappings
{
    public class DepartamentoMapping : IEntityTypeConfiguration<DepartamentoEntidade>
    {
        public void Configure(EntityTypeBuilder<DepartamentoEntidade> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.Property(c => c.Codigo)
                .HasColumnName("DEPTO_CODIGO")
                .HasColumnType("NUMERIC");

            builder.Property(c => c.Nome)
                .HasColumnName("DEPTO_NOME")
                .HasColumnType("VARCHAR(50)");

            builder.HasMany(c => c.Setor)
                .WithOne(dtp => dtp.Departamento)
                .HasForeignKey(fk => fk.IdDepartamento);

        }
    }
}
