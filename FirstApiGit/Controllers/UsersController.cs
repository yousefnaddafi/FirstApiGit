using FoodReciepe.HttpServices;
using FoodReciepe.Models;
using FoodReciepe.Repository;
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
        
        //need some changes
        public class TaskController : ControllerBase
        {
            readonly userRepo repository;
            public TaskController()
            {
                repository = new userRepo();
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

