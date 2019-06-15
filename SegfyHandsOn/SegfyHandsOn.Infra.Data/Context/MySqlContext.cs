using Microsoft.EntityFrameworkCore;
using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Infra.Data.Mapping;

namespace SegfyHandsOn.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        public DbSet<SeguroAuto> SegurosAutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeguroAuto>(new SeguroAutoMap().Configure);
        }
    }
}
