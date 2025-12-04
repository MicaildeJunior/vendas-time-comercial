using Microsoft.EntityFrameworkCore;
using VendasTimeComercial.Domain.Entities;
using VendasTimeComercial.Domain.Repositories;
using VendasTimeComercial.Infrastructure.Data;

namespace VendasTimeComercial.Infrastructure.Repositories;

public class VendaRepository(VendasTimeComercialContext context) : IVendaRepository
{
    private readonly VendasTimeComercialContext _context = context;

    public async Task<List<Venda>> ObterTodasAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Vendas.AsNoTracking().ToListAsync(cancellationToken);
    }
}
