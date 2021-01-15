using FoodReciepe.HttpServices;
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
    public class categoriesController : ControllerBase
    {
       
            private readonly FoodReport foodReport;

            public categoriesController(FoodReport foodReport)
            {
                this.foodReport = foodReport;
            }
            [HttpGet]
            public CategoryCustom GetByArea([FromQuery] int size)
            {
                return foodReport.GetCat(size);
            }

        }

    }

