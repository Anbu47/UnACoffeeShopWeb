using System;
using UnACoffeeShop.CondimentDecorator.BagelDecorator;
using UnACoffeeShop.CondimentDecorator.SandwichDecorator;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.Factory
{
    public class UnAFoodFactory
    {
        public enum FoodType
        {
            SANDWICH,
            BAGEL,
        }

        public enum SandwichType
        {
            SANDWICH = 0,
            SANDWICH_EGG,
            SANDWICH_TURKEY,
        }

        public enum BagelType
        {
            BAGEL = 0,
            BAGEL_BUTTER,
            BAGEL_CREAMCHEESE,
        }

        public ShopItem Order(FoodType foodType, int subFoodType)
        {
            switch (foodType)
            {
                case FoodType.SANDWICH:
                    var sandWich = new Sandwich();
                    switch (subFoodType)
                    {
                        case 1:
                            return new Egg(sandWich);
                        case 2:
                            return new Turkey(sandWich);
                        case 0:
                        default:
                            return sandWich;
                    }
                case FoodType.BAGEL:
                    var bagel = new Bagel();
                    switch (subFoodType)
                    {
                        case 1:
                            return new Butter(bagel);
                        case 2:
                            return new CreamCheese(bagel);
                        case 0:
                        default:
                            return bagel;
                    }
            }
            return null; // error
        }
    }
}