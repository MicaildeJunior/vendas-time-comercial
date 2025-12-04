using VendasTimeComercial.Application.Responses;
using VendasTimeComercial.Domain.Repositories;
using VendasTimeComercial.Domain.Services;

namespace VendasTimeComercial.Application.Services;

public class VendaService(IVendaRepository repository)
{
    private readonly IVendaRepository _repository = repository;

    public async Task<List<VendedorComissaoResponse>> ObterComissoesAsync()
    {
        var vendas = await _repository.ObterTodasAsync();

        var resultado = vendas
           .GroupBy(v => v.Vendedor)
           .Select(g => new VendedorComissaoResponse(
               g.Key,
               Math.Round(g.Sum(v => v.Valor), 2),
               Math.Round(g.Sum(v => ComissaoService.CalcularComissaoDaVenda(v.Valor)), 2)
           ))
           .ToList();

        return resultado;
    }

}
