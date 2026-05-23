using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SegurosApi.Application.Interfaces;
using SegurosApi.Domain.Interfaces;

namespace SegurosApi.Api.Controllers
{
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
}