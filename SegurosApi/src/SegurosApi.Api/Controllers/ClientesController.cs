using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SegurosApi.Application;
using SegurosApi.Domain.Entidades;

namespace SegurosApi.Api.Controllers;

[ApiController]
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var cliente =
            await _clienteService.GetClienteByIdAsync(id);

        return Ok(cliente);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Cliente cliente)
    {
        var createdCliente =
            await _clienteService.CreateClienteAsync(cliente);

        return CreatedAtAction(nameof(GetById), new { id = createdCliente.Id }, createdCliente);
    }
    
}