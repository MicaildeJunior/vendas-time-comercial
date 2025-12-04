using Microsoft.EntityFrameworkCore;
using VendasTimeComercial.Domain.Entities;

namespace VendasTimeComercial.Infrastructure.Data;

public class VendasTimeComercialContext(DbContextOptions<VendasTimeComercialContext> options) : DbContext(options)
{
    public DbSet<Venda> Vendas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Venda>(builder =>
        {
            builder.ToTable("Vendas");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Vendedor)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(v => v.Valor)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(v => v.DataVenda)
                .HasColumnType("datetime2")
                .IsRequired(false);
        });
    }
}
