using FoodReciepe.HttpServices;
using FoodReciepe.Models;
using FoodReciepe.Properties;
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
    public class UsersController : ControllerBase
    {
        public class TaskController : ControllerBase
        {
            readonly UsersRepository repository;
            public TaskController()
            {
                repository = new UsersRepository();
            }
            [HttpPost ]
        public users Register([FromBody] users Users )
        {
                repository.Insert(Users);
                return Users;
                
        }
           
            }




        }
    }

