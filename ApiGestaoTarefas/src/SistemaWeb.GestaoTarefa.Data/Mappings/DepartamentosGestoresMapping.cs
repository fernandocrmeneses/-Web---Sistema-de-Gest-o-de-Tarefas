using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWeb.GestaoTarefa.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Data.Mappings
{
    public class DepartamentosGestoresMapping : IEntityTypeConfiguration<DepartamentosGestoresEntidade>
    {
        public void Configure(EntityTypeBuilder<DepartamentosGestoresEntidade> builder)
        {
            builder.HasKey(x => new { x.IdGestor, x.IdDepartamento });
            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.HasOne<DepartamentoEntidade>()
                .WithMany(x => x.DepartamentoGestores)
                .HasForeignKey(fk => fk.IdDepartamento);

            builder.HasOne<GestorEntidade>()
                .WithMany(x => x.DepartamentoGestores)
                .HasForeignKey(fk => fk.IdGestor);

            builder.ToTable("DEPARTAMENTOS_GESTORES");
        }
    }
}
