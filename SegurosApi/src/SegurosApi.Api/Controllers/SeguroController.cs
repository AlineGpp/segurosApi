using Microsoft.AspNetCore.Mvc;
using SegurosApi.Application.Interfaces;

namespace SegurosApi.Api.Controllers
{
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
}