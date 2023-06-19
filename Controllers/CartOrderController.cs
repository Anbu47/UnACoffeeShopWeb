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
    public class CartOrderController : ControllerBase
    {
        // Respond CartOrderModel.json data
        [HttpGet("getCartOrderData")]
        public CartOrderModel[] GetAllData()
        {
            string jsonString = System.IO.File.ReadAllText(@$"{CartOrder}");
            CartOrderModel[] data = JsonSerializer.Deserialize<CartOrderModel[]>(jsonString);
            return data;
        }

        // Receive ID CartOrder to respond data 
        [HttpGet("getCartOrderData{orderId:int}")]
        public CartOrderModel GetCartOrderData(int orderId)
        {
            string jsonString = System.IO.File.ReadAllText(@$"{CartOrder}");
            var data = JsonSerializer.Deserialize<CartOrderModel[]>(jsonString).ToList();
            return data.First(order => order.OrderID == orderId);
        }

        // Receive new CartOrder data
        [HttpPost("addCartOrderData")]
        public void AddCartOrderData([FromBody] CartOrderModel cartOrderModel)
        {
            ModifyCartOrderData.AddCartOrderData(cartOrderModel);
        }

        // Remove CartOrder data by ID
        [HttpDelete("removeCartOrderData{id}")]
        public void RemoveCartOrderData(int id)
        {
            ModifyCartOrderData.RemoveCartOrderData(id);
        }

        [HttpPatch("updateCartOrderData")]
        public void UpdateCartOrderData([FromBody] CartOrderModel data)
        {
            ModifyCartOrderData.UpdateCartOrderData(data);
        }
    }
}