using System.Security.AccessControl;
using UnACoffeeShop.ShopItemClass;
namespace UnACoffeeShop.DesignPatterns.CondimentDecorator
{
    public abstract class DrinkDecorator : DrinkItem 
    {
        protected DrinkItem _drinkItem;

        public DrinkDecorator(DrinkItem drinkItem, string name, float basePrice) : base(name, basePrice)
        {
            _drinkItem = drinkItem;
            _basePrice = basePrice;
            _description = name;
        }

        public override string GetDescription()
        {
            return _drinkItem.GetDescription() + $", {_description}";
        }

        public override double Cost()
        {
            return _drinkItem.Cost() + _basePrice;
        }
    }
}
