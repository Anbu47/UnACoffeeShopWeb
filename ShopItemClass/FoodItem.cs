namespace UnACoffeeShop.ShopItemClass
{
    public class DrinkItem : ShopItem
    {
        public DrinkItem(string name, float basePrice)
        {
            _description = name;
            _basePrice = basePrice;
        }
        public override string GetDescription()
        {
            return _description;
        }

        public override double Cost()
        {
            return _basePrice;
        }
    }
}
