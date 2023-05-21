namespace UnACoffeeShop.ShopItemClass
{
    public class FoodItem : ShopItem
    {
        public FoodItem(string name, float basePrice)
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
