using System;
using System.Net.Security;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop.Factory
{
    public class UnADrinkFactory
    {
        public enum DrinkType
        {
            HOT_COFFEE,
            COLD_COFFEE,
            BLENDED_COFFEE,
            MILKTEA,
        }
    }
}