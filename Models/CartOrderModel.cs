﻿using System.Text.Json.Serialization;

namespace UnACoffeeShop.Models.ShopItemModel
{
    public class CartOrderModel
    {
        [JsonPropertyName("OrderID")] public int OrderID { get; set; }

        [JsonPropertyName("ProfileID")] public int ProfileID { get; set; }

        [JsonPropertyName("ItemID")] public int ItemID { get; set; }

        [JsonPropertyName("Decorators")] public int[] DecoratorIDs { get; set; }

        [JsonPropertyName("Size")] public int ItemSizeID { get; set; }

        [JsonPropertyName("Style")] public int ItemStyleID { get; set; }

        [JsonPropertyName("Description")] public string Description { get; set; }

        [JsonPropertyName("Cost")] public double Cost { get; set; }

        [JsonPropertyName("Status")] public int Status { get; set; }

        [JsonPropertyName("Rating")] public int Rating { get; set; }

        [JsonPropertyName("Datetime")] public string Datetime { get; set; }
    }
}