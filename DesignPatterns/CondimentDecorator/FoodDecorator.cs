
using UnACoffeeShop.ShopItemClass;
namespace UnACoffeeShop.DesignPatterns.CondimentDecorator
{
    public abstract class FoodDecorator : FoodItem
    {
        protected FoodItem _foodItem;
        protected float _basePrice;

        public FoodDecorator(FoodItem foodItem, string name, float basePrice) : base(name, basePrice)
        {
            _foodItem = foodItem;
            _basePrice = basePrice;
            _description = name;
        }

        public override string GetDescription()
        {
            return _foodItem.GetDescription() + $", {_description}";
        }

        public override double Cost()
        {
            return _foodItem.Cost() + _basePrice;
        }
    }
}
