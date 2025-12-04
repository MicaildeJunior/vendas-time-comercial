using Microsoft.AspNetCore.Mvc;
using VendasTimeComercial.Application.Services;

namespace VendasTimeComercial.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VendasController : ControllerBase
{
    private readonly VendaService _service;

    public VendasController(VendaService service)
    {
        _service = service;
    }

    [HttpGet("comissoes")]
    public async Task<IActionResult> GetComissoes()
    {
        var result = await _service.ObterComissoesAsync();
        return Ok(result);
    }
}
