using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SegurosApi.Application.Interfaces;

namespace SegurosApi.Api.Controllers;

[ApiController]
[Authorize()]
[Route("api/apolices")]

    public class ApoliceController(IApoliceService apoliceService) : ControllerBase
    {
        private readonly IApoliceService _apoliceService = apoliceService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var apolices =
                await _apoliceService.GetAllAsync();

            return Ok(apolices);
        }
    }
