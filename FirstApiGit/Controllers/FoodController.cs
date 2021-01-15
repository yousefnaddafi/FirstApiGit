using FoodReciepe.HttpServices;
using FoodReciepe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodReciepe.Controllers 
{

    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly FoodReport foodReport;
        public FoodController(FoodReport foodReport)
        {
            this.foodReport = foodReport;
        }
        [HttpPost ]
        public string Post([FromQuery] string Email ,List<string> Favarite)
        {
            return Email;
        }

        [HttpGet]
        public AreaCustom GetArea([FromQuery] int size)
        {
            return foodReport.GetArea(size);
        }
       


    }
    }

