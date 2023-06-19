﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnACoffeeShop.Models.ShopItemModel;
using UnACoffeeShop.ShopItemClass;

namespace UnACoffeeShop.DesignPatterns
{
    public class MenuItemFactory
    {
        public IShopItem Order(string name, float basePrice, ItemSizeModel? size = null, ItemStyleModel? style = null)
        {
            var itemName = style == null ? name : $"{style.Name} {name}";
            itemName += size == null ? itemName : $", {size.Name}";

            var itemPrice = basePrice;
            itemPrice += size == null ? 0 : size.Price;
            itemPrice += style == null ? 0 : style.Price;

            return new ShopItem(itemName, itemPrice);
        }
    }

}
