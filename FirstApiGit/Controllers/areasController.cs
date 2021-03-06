﻿using FoodReciepe.HttpServices;
using FoodReciepe.Models;
using Microsoft.AspNetCore.Http;
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
        private readonly FoodReport foodReport;

        public areasController(FoodReport foodReport)
        {
            this.foodReport = foodReport;
        }
        [HttpGet]
        public AreaCustom GetByArea([FromQuery] int size)
        {
            return foodReport.GetArea(size);
        }

    }
}
