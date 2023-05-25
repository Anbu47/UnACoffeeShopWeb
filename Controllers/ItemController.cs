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
    [ApiController]
    [Route("api/data")]
    public class ItemController : ControllerBase
    {
        //Respond Decorator.json data
        [HttpGet("getItemData")]
        public ShopItemModel[]? GetAllData()
        {
            string jsonString = System.IO.File.ReadAllText(@$"{Item}");
            ShopItemModel[]? data = JsonSerializer.Deserialize<ShopItemModel[]>(jsonString);
            return data;
        }
        //Receive ID Item to respond data 
        [HttpGet("getItemData{id:int}")]
        public ShopItemModel GetItemData(int id)
        {
            string jsonString = System.IO.File.ReadAllText(@$"{Item}");
            var data = JsonSerializer.Deserialize<ShopItemModel[]>(jsonString).ToList();
            return data.First(item => item.ID == id);
        }

        //Receive new ID Item Data
        [HttpPost("addItemData{id}/{type}/{name}/{description}/{basePrice}/{imageURL}/{decorators}")]
        public void AddItemData(int id, string type, string name, string description, float basePrice, string imageURL, DecoratorModel[] decorators)
        {
            ModifyItemData.AddItemData(id, type, name, description, basePrice, imageURL, decorators);
        }
    }
}
