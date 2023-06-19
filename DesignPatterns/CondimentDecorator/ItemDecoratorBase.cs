using UnACoffeeShop.ShopItemClass;

namespace UnACoffeeShop.DesignPatterns.CondimentDecorator
{
    public abstract class ItemDecoratorBase :IShopItem
    {
        protected ShopItem _shopItem;
        protected string _description = "Decorator Item";
        protected float _basePrice;
        public abstract string GetDescription();
        public abstract double Cost();
    }
}
