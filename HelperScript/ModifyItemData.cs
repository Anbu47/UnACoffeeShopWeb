using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.Models.ShopItemModel;
using System.Xml.Linq;
using static UnACoffeeShop.Dataset.Routes;

namespace UnACoffeeShop.HelperScript
{
    public class ModifyItemData
    {
        public static void AddItemData(string type, string name, string description, float basePrice, string imageURL, DecoratorModel[] decorators)
        {
            // Read the JSON file content
            string json = System.IO.File.ReadAllText(@$"{Item}");

            // Deserialize JSON into an object
            ShopItemModel[] itemData = JsonConvert.DeserializeObject<ShopItemModel[]>(json);
            List<ShopItemModel> itemDataList = itemData.ToList();
            // Create a new item
            ShopItemModel newItemData = new ShopItemModel
            {
                Type = type,
                Name = name,
                Description = description,
                BasePrice = basePrice,
                ImageURL = imageURL,
                Decorators = decorators,

            };

            // Add the new item to the menu 
            itemDataList.Add(newItemData);

            // Serialize the updated menu back to JSON
            string updatedJson = JsonConvert.SerializeObject(itemDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Item}", updatedJson);
        }
        //public static void RemoveItemData(int id)
        //{
        //    // Read the JSON file content
        //    string json = File.ReadAllText(@$"{Item}");

        //    // Deserialize JSON into an object
        //    ShopItemModel[] itemData = JsonConvert.DeserializeObject<ShopItemModel[]>(json);
        //    List<ShopItemModel> itemDataList = itemData.ToList();

        //    ShopItemModel item = itemDataList.First(i => i.ID == id);

        //    // Remove item to the menu 
        //    itemDataList.Remove(item);

        //    // Serialize the updated item back to JSON
        //    string updatedJson = JsonConvert.SerializeObject(itemDataList, Formatting.Indented);

        //    // Write the updated JSON back to the file
        //    File.WriteAllText(@$"{Item}", updatedJson);
        //}

    }
}
