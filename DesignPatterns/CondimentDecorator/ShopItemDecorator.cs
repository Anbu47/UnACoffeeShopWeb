using UnACoffeeShop.ShopItemClass;

namespace UnACoffeeShop.DesignPatterns.CondimentDecorator
{
    public class ShopItemDecorator : ItemDecoratorBase
    {
        protected IShopItem _shopItem;

        public ShopItemDecorator(IShopItem shopItem, string name, float basePrice)
        {
            _shopItem = shopItem;
            _basePrice = basePrice;
            _description = name;
        }

        public override string GetDescription()
        {
            return _shopItem.GetDescription() + $", {_description}";
        }

        public override double Cost()
        {
            return _shopItem.Cost() + _basePrice;
        }
    }
}
