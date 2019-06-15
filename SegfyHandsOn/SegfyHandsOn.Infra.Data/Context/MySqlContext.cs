using Microsoft.EntityFrameworkCore;
using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<SeguroAuto> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeguroAuto>(new SeguroAutoMap().Configure);
        }
    }
}
