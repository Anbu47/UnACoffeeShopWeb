using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using UnACoffeeShop.HelperScript;
using static UnACoffeeShop.Dataset.Routes;
using Google.Cloud.Firestore;
using UnACoffeeShop.Models.ShopItemModelFirebase;

namespace UnACoffeeShop.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class ItemControllerFirebase : ControllerBase
    {
        //Respond Decorator.json data
        [HttpGet("getItemDataFirebase")]
        public async Task<ActionResult<IEnumerable<ShopItemModelFirebase>>> GetAllData()
        {
            // Create a Firestore client
            FirestoreDb db = FirestoreDb.Create("unacoffeeshop");

            // Reference the "Item" collection
            CollectionReference itemsRef = db.Collection("Items");

            // Query all documents in the "Item" collection
            QuerySnapshot snapshot = await itemsRef.GetSnapshotAsync();

            // Deserialize the documents to ShopItemModel objects
            var dataList = new List<ShopItemModelFirebase>();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                ShopItemModelFirebase item = document.ConvertTo<ShopItemModelFirebase>();
                dataList.Add(item);
            }

            return Ok(dataList);
        }

        ////Receive ID Item to respond data 
        //[HttpGet("getItemData{id:int}")]
        //public ShopItemModel GetItemData(int id)
        //{
        //    string jsonString = System.IO.File.ReadAllText(@$"{Item}");
        //    var data = JsonSerializer.Deserialize<ShopItemModel[]>(jsonString).ToList();
        //    return data.First(item => item.ID == id);
        //}

        ////Receive new ID Item Data
        //[HttpPost("addItemData{id}/{type}/{name}/{description}/{basePrice}/{imageURL}/{decorators}")]
        //public void AddItemData(int id, string type, string name, string description, float basePrice, string imageURL, DecoratorModel[] decorators)
        //{
        //    ModifyItemData.AddItemData( type, name, description, basePrice, imageURL, decorators);
        //}
    }
}
