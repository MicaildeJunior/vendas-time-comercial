namespace VendasTimeComercial.Domain.Entities;

public class Venda
{
    public Guid Id { get; set; }
    public string Vendedor { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime DataVenda { get; set; } = DateTime.UtcNow;
}
