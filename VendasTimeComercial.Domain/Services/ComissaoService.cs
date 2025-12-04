namespace VendasTimeComercial.Domain.Services;

public static class ComissaoService
{
    public static decimal CalcularComissaoDaVenda(decimal valor)
    {
        if (valor < 100m) 
            return 0m;

        if (valor < 500m) 
            return valor * 0.01m;

        return valor * 0.05m;
    }
}
