using VendasTimeComercial.Domain.Entities;

namespace VendasTimeComercial.Domain.Repositories;

public interface IVendaRepository
{
    Task<List<Venda>> ObterTodasAsync(CancellationToken cancellationToken = default);
}
