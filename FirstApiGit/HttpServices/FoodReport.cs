using FoodReciepe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FoodReciepe.HttpServices
{
    public class FoodReport
    {
        private readonly HttpClient client;
        private const string BaseAdress = "https://www.themealdb.com";
        
        public FoodReport(HttpClient client)
        {
            this.client = client;
            this.client.BaseAddress = new Uri(BaseAdress);
            this.client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public Foods GetArea(string search)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/filter.php?a={}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            Foods result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                result = JsonSerializer.Deserialize<Foods>(stringContent);
            }
            return result;
        }

    }
}
