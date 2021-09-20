using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Data.Mappings
{
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(m => m.Crm)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(m => m.UfCrm)
                   .IsRequired()
                   .HasColumnType("varchar(2)");

            builder.Property(m => m.Especialidade)
                   .IsRequired()
                   .HasColumnType("int32");

            builder.HasMany(p => p.Pacientes)
                   .WithOne(m => m.Medico)
                   .HasForeignKey(m => m.MedicoId);

            builder.ToTable("medicos");
        }
    }
}
