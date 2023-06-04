using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnACoffeeShop.Models.CartOrderModel;
using static UnACoffeeShop.Dataset.Routes;
namespace UnACoffeeShop.HelperScript
{
    public class ModifyCartOrderData
    {
        public static void AddCartOrderData(int orderId, int profileId, string description, float cost, int status)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{CartOrder}");

            // Deserialize JSON into an object
            CartOrderModel[] orderData = JsonConvert.DeserializeObject<CartOrderModel[]>(json);
            List<CartOrderModel> orderDataList = orderData != null ? new List<CartOrderModel>(orderData) : new List<CartOrderModel>();

            // Create a new cart order
            CartOrderModel newOrderData = new CartOrderModel
            {
                OrderID = orderId,
                ProfileID = profileId,
                Description = description,
                Cost = cost,
                Status = status
            };

            // Add the new cart order to the list
            orderDataList.Add(newOrderData);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(orderDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{CartOrder}", updatedJson);
        }

        public static void RemoveCartOrderData(int orderId)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{CartOrder}");

            // Deserialize JSON into an object
            CartOrderModel[] orderData = JsonConvert.DeserializeObject<CartOrderModel[]>(json);
            List<CartOrderModel> orderDataList = orderData != null ? new List<CartOrderModel>(orderData) : new List<CartOrderModel>();

            CartOrderModel order = orderDataList.Find(o => o.OrderID == orderId);

            // Remove the order from the list
            orderDataList.Remove(order);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(orderDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{CartOrder}", updatedJson);
        }
    }
}
