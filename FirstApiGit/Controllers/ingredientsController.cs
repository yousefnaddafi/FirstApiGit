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
    public class ingredientsController : ControllerBase
    {
        private readonly FoodReport foodReport;

        public ingredientsController(FoodReport foodReport)
        {
            this.foodReport = foodReport;
        }
        [HttpGet]
        public IngCustom GetByIng([FromQuery] int size)
        {
            return foodReport.GetIng(size);
        }
    }
}
