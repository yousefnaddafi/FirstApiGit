﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodReciepe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class areasController : ControllerBase
    {
        public areasController()
        {

        }
        [HttpGet]
        public List<string> GetList([])

    }
}