using Microsoft.AspNetCore.Mvc;
using SegurosApi.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace SegurosApi.Api.Controllers;
[ApiController]
[Authorize()]
[Route("api/seguros")]
    public class SeguroController(ISeguroService seguroService) : ControllerBase
    {
        private readonly ISeguroService _seguroService = seguroService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var seguros =
                await _seguroService.GetAllAsync();

            return Ok(seguros);
        }
    }
