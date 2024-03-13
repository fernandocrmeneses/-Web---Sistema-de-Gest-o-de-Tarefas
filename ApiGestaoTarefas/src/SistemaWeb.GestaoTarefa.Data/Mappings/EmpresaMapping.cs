using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWeb.GestaoTarefa.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Data.Mappings
{
    internal class EmpresaMapping : IEntityTypeConfiguration<EmpresaEntidade>
    {
        public void Configure(EntityTypeBuilder<EmpresaEntidade> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.Property(c => c.Nome)
                .HasColumnName("EMPR_NOME")
                .HasColumnType("VARCHAR(50)");

            builder.Property(c => c.CNPJ)
                .HasColumnName("EMPR_CNPJ")
                .HasColumnType("NUMBER");

            builder.HasMany(x => x.Departamentos)
                .WithOne(emp => emp.Empresa)
                .HasForeignKey(fk => fk.IdEmpresa);

            builder.ToTable("EMPRESAS");
        }
    }
}
