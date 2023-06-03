using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.Models.ShopItemModelFirebase;
using System.Xml.Linq;
using static UnACoffeeShop.Dataset.Routes;
using System.Text.RegularExpressions;

namespace UnACoffeeShop.HelperScript
{
    public class ModifyDecoratorData
    {
        public static void AddDecoratorData(int id, string type, string name, float price, int groupID)
        {
            // Read the JSON file content
            string json = System.IO.File.ReadAllText(@$"{Decorator}");

            // Deserialize JSON into an object
            DecoratorModel[] decoratorData = JsonConvert.DeserializeObject<DecoratorModel[]>(json);
            List<DecoratorModel> decoratorDataList = decoratorData.ToList();
            // Create a new item
            DecoratorModel newDecoratorData = new DecoratorModel
            {
                ID = id,
                Type = type,
                Name = name,
                Price = price,
                GroupID = groupID,

            };

            // Add the new item to the menu 
            decoratorDataList.Add(newDecoratorData);

            // Serialize the updated menu back to JSON
            string updatedJson = JsonConvert.SerializeObject(decoratorDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Decorator}", updatedJson);
        }
        public static void RemoveDecoratorData(int id)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{Decorator}");

            // Deserialize JSON into an object
            DecoratorModel[] decoratorData = JsonConvert.DeserializeObject<DecoratorModel[]>(json);
            List<DecoratorModel> decoratorDataList = decoratorData.ToList();

            DecoratorModel decorator = decoratorDataList.First(i => i.ID == id);

            // Remove item to the menu 
            decoratorDataList.Remove(decorator);

            // Serialize the updated item back to JSON
            string updatedJson = JsonConvert.SerializeObject(decoratorDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Decorator}", updatedJson);
        }

    }
}

