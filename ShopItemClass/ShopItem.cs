namespace UnACoffeeShop.ShopItemClass
{
    public abstract class ShopItem
    {
        protected string _description = "Shop Item";
        protected float _basePrice;
        public abstract string GetDescription();
        public abstract double Cost();
    }
}