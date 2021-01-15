using FoodReciepe.HttpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodReciepe.Controllers {

    [Route("api")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly FoodReport foodReport;
        public FoodController(FoodReport foodReport)
        {
            this.foodReport = foodReport;
        }

        [HttpGet]
        public Foods GetArea([FromQuery] string size)
        {
            return FoodReport.GetArea(size);
        }

    }
    }
}
