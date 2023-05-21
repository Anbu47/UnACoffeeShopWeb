using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnACoffeeShop.ShopItemClass.ShopItemCreator
{
    public class ShopItemCreator
    {
        public enum ShopItemType
        {
            DrinkItem,
            FoodItem,
        }
        public ShopItem Order(ShopItemType shopItemType, string name, float basePrice)
        {
            switch (shopItemType)
            {
                case ShopItemType.DrinkItem:
                    return new DrinkItem(name, basePrice);
                case ShopItemType.FoodItem:
                    return new FoodItem(name, basePrice);
            }

            return null;
        }
    }
}
