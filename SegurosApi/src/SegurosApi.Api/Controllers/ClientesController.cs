using Microsoft.AspNetCore.Mvc;
using SegurosApi.Domain.Interfaces;

namespace SegurosApi.Api.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClientesController : ControllerBase
{
    private readonly IClienteRepository _repository;

    public ClientesController(
        IClienteRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var clientes =
            await _repository.GetAll();

        return Ok(clientes);
    }
}