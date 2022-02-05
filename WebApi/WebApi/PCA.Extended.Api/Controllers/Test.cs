﻿using Microsoft.AspNetCore.Mvc;

namespace PCA.Extended.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Test : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return new JsonResult("OK");
    }
}