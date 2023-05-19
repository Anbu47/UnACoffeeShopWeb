using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using UnACoffeeShop.ShopItemClass.Drink;
using UnACoffeeShop.Models.ShopItemModel;
using System.Xml.Linq;
using static UnACoffeeShop.Dataset.Routes;

namespace UnACoffeeShop.HelperScript
{
    public class ModifyItemData
    {
        public static void AddItemData(int id, string type, string name, string description, float basePrice, string imageURL)
        {
            // Read the JSON file content
            string json = System.IO.File.ReadAllText(@$"{Menu}");

            // Deserialize JSON into an object
            ShopItemModel[] itemData = JsonConvert.DeserializeObject<ShopItemModel[]>(json);
            List<ShopItemModel> itemDataList = itemData.ToList();
            // Create a new coffee item
            ShopItemModel newItemData = new ShopItemModel
            {
                ID = id,
                Type = type,
                Name = name,
                Description = description,
                BasePrice = basePrice,
                ImageURL = imageURL,

            };

            // Add the new item to the menu //fix later
            itemDataList.Add(newItemData);

            // Serialize the updated menu back to JSON
            string updatedJson = JsonConvert.SerializeObject(itemDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Menu}", updatedJson);
        }
        public static void RemoveItemData(int id)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{Menu}");

            // Deserialize JSON into an object
            ShopItemModel[] itemData = JsonConvert.DeserializeObject<ShopItemModel[]>(json);
            List<ShopItemModel> itemDataList = itemData.ToList();

            ShopItemModel item = itemDataList.First(i => i.ID == id);

            // Add the new item to the menu //fix later
            itemDataList.Remove(item);

            // Serialize the updated menu back to JSON
            string updatedJson = JsonConvert.SerializeObject(itemDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Menu}", updatedJson);
        }

    }
}
