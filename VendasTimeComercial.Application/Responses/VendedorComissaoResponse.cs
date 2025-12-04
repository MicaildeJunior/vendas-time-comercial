namespace VendasTimeComercial.Application.Responses;

public sealed record VendedorComissaoResponse(
    string Vendedor,
    decimal TotalVendido,
    decimal ComissaoTotal
);