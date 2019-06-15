using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegfyHandsOn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Infra.Data.Mapping
{
    public class SeguroAutoMap : IEntityTypeConfiguration<SeguroAuto>
    {
        public void Configure(EntityTypeBuilder<SeguroAuto> builder)
        {
            builder.ToTable("SeguroAuto");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NumeroApolice)
                .IsRequired()
                .HasColumnName("NumeroApolice");

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnName("Cpf");

            builder.Property(c => c.PlacaVeiculo)
                .IsRequired()
                .HasColumnName("PlacaVeiculo");

            builder.Property(c => c.ValorPremio)
                .IsRequired()
                .HasColumnName("ValorPremio");

        }
    }
}
