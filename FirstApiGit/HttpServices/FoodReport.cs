using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodReciepe.HttpServices
{
    public class FoodReport
    {
        private readonly HttpClient Client;
        private const string BaseAdress = "https://www.themealdb.com";
        
        public FoodReport(HttpClient client)
        {
            this.Client = client;
            this.Client.BaseAddress = new Uri(BaseAdress);
            this.Client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        
    }
}
