﻿using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand command)
        {
            return Created("", await Mediator.Send(command));
        }
    }
}