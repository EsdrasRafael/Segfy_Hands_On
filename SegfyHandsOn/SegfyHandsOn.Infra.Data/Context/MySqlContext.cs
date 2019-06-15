using Microsoft.EntityFrameworkCore;
using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Infra.Data.Mapping;

namespace SegfyHandsOn.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<SeguroAuto> SeguroAuto { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeguroAuto>(new SeguroAutoMap().Configure);
        }
    }
}
