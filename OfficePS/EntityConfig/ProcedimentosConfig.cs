using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OfficePS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.EntityConfig
{
    public class ProcedimentosConfig : IEntityTypeConfiguration<Procedimentos>
    {
        void IEntityTypeConfiguration<Procedimentos>.Configure(EntityTypeBuilder<Procedimentos> builder)
        {
            builder.HasKey(p => p.ProcedimentosId);

            builder.Property(p => p.Nome).IsRequired();

            builder.Property(p => p.Ativo).IsRequired();

            builder.Property(p => p.Descricao).HasMaxLength(300);
        }
    }
}
