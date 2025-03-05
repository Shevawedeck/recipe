﻿using RecipeSystem;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpGet]
        public List<bizDashboard> Get()
        {
            return new bizDashboard().GetList();
        }
    }
}
