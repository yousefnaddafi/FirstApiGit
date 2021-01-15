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
        public AreaCustom GetArea(int size)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/list.php?a=list").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }


            HttpContent content = httpResponse.Content;
                string stringContent = content.ReadAsStringAsync().Result;

              var  result = JsonSerializer.Deserialize<areas>(stringContent);

             

                return new AreaCustom() { Result = result.meals.Take(size).ToList() };

        }
        public CategoryCustom GetCat(int size)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/list.php?c=list").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }


            HttpContent content = httpResponse.Content;
            string stringContent = content.ReadAsStringAsync().Result;

            var result = JsonSerializer.Deserialize<categories>(stringContent);



            return new CategoryCustom() { result = result.meals.Take(size).ToList() };

        }
        public IngCustom GetIng(int size)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/list.php?i=list").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }


            HttpContent content = httpResponse.Content;
            string stringContent = content.ReadAsStringAsync().Result;

            var result = JsonSerializer.Deserialize<ingredients>(stringContent);



            return new IngCustom() { result = result.meals.Select(x => new OurIng() {id = x.idIngredient , ingredient = x.strIngredient }).Take(size).ToList() };

        }
        
        public FoodsList GetBFilter(SelectByFilter SBF)
        {


            string cat = "";
            switch (SBF.Cat)
            {
                case "ing":
                     cat= "i";
                    break;
                case "cat":
                     cat="c";
                    break;
                case "area":
                     cat="a";
                    break;
                default:
                    cat = "i";
                    break;

            }
            
            
            var httpResponse = client.GetAsync($"api/json/v1/1/filter.php?{cat}={SBF.Selected}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }


            HttpContent content = httpResponse.Content;
            string stringContent = content.ReadAsStringAsync().Result;

            var result = JsonSerializer.Deserialize<Meals>(stringContent);



            return new FoodsList() { foods = result.meals.Select(z => new foods() { food = z.strMeal, foodThumb = z.strMealThumb, id = z.idMeal}).Take(2).ToList() };

        }

    }
}
