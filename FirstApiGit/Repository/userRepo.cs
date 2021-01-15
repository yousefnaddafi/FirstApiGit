using FoodReciepe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodReciepe.Repository
{
    public class userRepo: users
    {
        static List<users> Users = new List<users>();


        public void Insert(users user)
        {
            var usera = new users();
            user.email = usera.email;
            user.favarites = usera.favarites;

            Users.Add(user);
        }
    }
}
