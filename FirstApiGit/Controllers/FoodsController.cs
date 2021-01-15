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
    public class FoodsController : ControllerBase
    {
        private readonly FoodReport foodReport;
        public FoodsController(FoodReport foodReport)
        {
            this.foodReport = foodReport;
        }
        [HttpGet]
        public FoodsList GetByFilter([FromQuery] SelectByFilter FinalDetail)
        {
            return foodReport.GetBFilter(FinalDetail);
        }
        [HttpGet("{id}")]
        public FoodList GetById(int id)
        {
            return foodReport.GetByID(id);
        }
    }
}
