using System.Globalization;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using UnACoffeeShop.DesignPatterns;
using UnACoffeeShop.DesignPatterns.CondimentDecorator;
using UnACoffeeShop.Models.ShopItemModel;
using UnACoffeeShop.ShopItemClass;
using static UnACoffeeShop.Dataset.Routes;

namespace UnACoffeeShop.HelperScript
{
    public class ModifyCartOrderData
    {
        private static readonly MenuItemFactory MenuItemFactory = new(); // technically can call this item factory
        private static readonly DecoratorFactory _decoratorFactory = new(); // decorator factory

        public static void AddCartOrderData(CartOrderModel newOrder)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{CartOrder}");

            // Deserialize JSON into an object
            CartOrderModel[] orderData = JsonConvert.DeserializeObject<CartOrderModel[]>(json);
            List<CartOrderModel> orderDataList =
                orderData != null ? new List<CartOrderModel>(orderData) : new List<CartOrderModel>();
            var shopItemData = JsonConvert.DeserializeObject<ShopItemModel[]>(File.ReadAllText($@"{Item}")).ToList();
            // Update Cart Order Description and Cost

            var orderedItemData = shopItemData.First(item => item.ID == newOrder.ItemID);
            var orderedItemStyle = QueryItemStyle(orderedItemData.Style); // Note: this need to be discuss again
            var orderedItemSize = QueryItemSize(newOrder.ItemSizeID);
            // var newItemType = GetShopItemType(orderedItemData.Type); // category of item
            var newItem = MenuItemFactory.Order(
                orderedItemData.Name,
                orderedItemData.BasePrice,
                orderedItemSize,
                orderedItemStyle
            );
            foreach (var decoratorId in newOrder.DecoratorIDs)
            {
                newItem = _decoratorFactory.CreateDecorator(newItem, decoratorId);
            }

            // Update CartOrder DateTime
            newOrder.Description = newItem.GetDescription();
            newOrder.Cost = newItem.Cost();
            newOrder.Datetime = DateTime.Now.ToString(CultureInfo.InvariantCulture);

            // Add the new cart order to the list
            orderDataList.Add(newOrder);

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
            List<CartOrderModel> orderDataList =
                orderData != null ? new List<CartOrderModel>(orderData) : new List<CartOrderModel>();

            CartOrderModel order = orderDataList.Find(o => o.OrderID == orderId);

            // Remove the order from the list
            orderDataList.Remove(order);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(orderDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{CartOrder}", updatedJson);
        }

        public static void UpdateCartOrderData(CartOrderModel cartOrderModel)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{CartOrder}");

            // Deserialize JSON into an object
            CartOrderModel[] orderData = JsonConvert.DeserializeObject<CartOrderModel[]>(json);
            List<CartOrderModel> orderDataList =
                orderData != null ? new List<CartOrderModel>(orderData) : new List<CartOrderModel>();

            var order = orderData.First(item => item.OrderID == cartOrderModel.OrderID);

            // lazy approach for now 
            order.Status = cartOrderModel.Status;
            order.Rating = cartOrderModel.Rating;

            // Serialize the updated menu back to JSON
            string updatedJson = JsonConvert.SerializeObject(orderData, Formatting.Indented);
            // Write the updated JSON back to the file
            File.WriteAllText(@$"{CartOrder}", updatedJson);
        }

        public static ItemStyleModel QueryItemStyle(int id)
        {
            var json = File.ReadAllText(@$"{Style}");
            return JsonConvert.DeserializeObject<ItemStyleModel[]>(json).FirstOrDefault(style => style.ID == id);
        }

        public static ItemSizeModel QueryItemSize(int id)
        {
            var json = File.ReadAllText($@"{Size}");
            return JsonConvert.DeserializeObject<ItemSizeModel[]>(json).FirstOrDefault(size => size.ID == id);
        }
    }
}