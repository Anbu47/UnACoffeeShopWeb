using Newtonsoft.Json;
using System.ComponentModel;
using UnACoffeeShop.DesignPatterns.CondimentDecorator;
using UnACoffeeShop.Models.ShopItemModel;
using UnACoffeeShop.ShopItemClass;
using static UnACoffeeShop.Dataset.Routes;
namespace UnACoffeeShop.DesignPatterns
{
    public class DecoratorFactory
    {
        private List<DecoratorModel> _decoratorData;

        public DecoratorFactory()
        {
            _decoratorData = JsonConvert.DeserializeObject<DecoratorModel[]>(File.ReadAllText($@"{Decorator}")).ToList();
        }

        public IShopItem CreateDecorator(IShopItem shopItem, int decoratorId)
        {
            var decoratorData = _decoratorData.First(data => data.ID == decoratorId);
            return new ShopItemDecorator(shopItem, decoratorData.Name, decoratorData.Price);
        }
    }
}
