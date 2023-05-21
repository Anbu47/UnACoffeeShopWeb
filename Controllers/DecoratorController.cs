using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using UnACoffeeShop.Models.ShopItemModel;
using UnACoffeeShop.HelperScript;
using static UnACoffeeShop.Dataset.Routes;

namespace UnACoffeeShop.Controllers
{
    namespace UnACoffeeShop.Controllers
    {
        [ApiController]
        [Route("api/data")]
        public class DecoratorController : ControllerBase
        {
            //Respond Decorator.json data
            [HttpGet("getDecoratorData")]
            public DecoratorModel[]? GetAllData()
            {
                string jsonString = System.IO.File.ReadAllText(@$"{Decorator}");
                DecoratorModel[]? data = JsonSerializer.Deserialize<DecoratorModel[]>(jsonString);
                Console.WriteLine(data[1].Name);
                return data;
            }
            //Receive ID Decorator to respond data 
            [HttpGet("getDecoratorData{id:int}")]
            public DecoratorModel GetDecoratorData(int id)
            {
                string jsonString = System.IO.File.ReadAllText(@$"{Decorator}");
                DecoratorModel[]? data = JsonSerializer.Deserialize<DecoratorModel[]>(jsonString);
                return data[id];
            }
            //Receive new ID Decorator Data 
            [HttpPost("addDecoratorData{id}/{type}/{name}/{description}/{basePrice}/{imageURL}")]
            public void AddDecoratorData(int id, string name, float price, int groupID)
            {
                ModifyDecoratorData.AddDecoratorData(id, name, price, groupID);
            }
        }
    }
}
