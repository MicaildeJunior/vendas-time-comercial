using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using VendasTimeComercial.Infrastructure.Data;

namespace VendasTimeComercial.Infrastructure.Persistence;

public class VendasTimeComercialContextFactory
    : IDesignTimeDbContextFactory<VendasTimeComercialContext>
{
    public VendasTimeComercialContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<VendasTimeComercialContext>();

        // MESMA connection string que está no appsettings
        optionsBuilder.UseSqlServer(
            "Data Source=LAPTOP-563RGJKO\\SQLEXPRESS;Initial Catalog=VendasTimeComercialDb;Integrated Security=True;TrustServerCertificate=True;");

        return new VendasTimeComercialContext(optionsBuilder.Options);
    }
}