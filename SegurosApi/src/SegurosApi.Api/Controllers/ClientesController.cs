using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SegurosApi.Application;


namespace SegurosApi.Api.Controllers;

[ApiController]
[Authorize()]
[Route("api/clientes")]
public class ClientesController(IClienteService clienteService) : ControllerBase
{
    private readonly IClienteService _clienteService = clienteService;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var clientes =
            await _clienteService.GetAllClientesAsync();

        return Ok(clientes);
    }
}