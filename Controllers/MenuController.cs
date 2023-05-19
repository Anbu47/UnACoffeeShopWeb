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

namespace UnACoffeeShop.Controllers;

[ApiController]
[Route("api/data")]
public class MenuController : ControllerBase
{
    //Receive API call
    [HttpGet("getMenuData")]
    public ShopItemModel[]? GetAllData()
    {
        string jsonString = System.IO.File.ReadAllText(@$"{Menu}");
        ShopItemModel[]? data = JsonSerializer.Deserialize<ShopItemModel[]>(jsonString);
        return data;
    }
    //Receive ID Item to respond data 
    [HttpGet("getMenuData{id:int}")]
    public ShopItemModel GetItemData(int id)
    {
        string jsonString = System.IO.File.ReadAllText(@$"{Menu}");
        ShopItemModel[]? data = JsonSerializer.Deserialize<ShopItemModel[]>(jsonString);
        return data[id];
    }
    //[HttpPost("addItemData{id:int}/{type:string}/{name:string}/{description:string}/{basePrice:float}/{imageURL:string}")]
    [HttpPost("addItemData{id}/{type}/{name}/{description}/{basePrice}/{imageURL}")]
    public void AddItemData(int id, string type, string name, string description, float basePrice, string imageURL)
    {
        ModifyItemData.AddItemData(id, type, name, description, basePrice, imageURL);
    }
}
