using System.ComponentModel;
using System.Drawing;
using UnACoffeeShop.Models.ShopItemModel;

namespace UnACoffeeShop.ShopItemClass
{
     //ShopItemBase  
    public class ShopItem : IShopItem
    {
        protected string _description = "Shop Item";
        protected float _basePrice;

        public ShopItem(string name, float price)
        {
            _description = name;
            _basePrice = price;
        }

        public string GetDescription()
        {
            return _description;
        }

        public double Cost()
        {
            return _basePrice;
        }
    }
}