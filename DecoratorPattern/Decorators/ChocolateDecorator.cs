using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Decorators
{
    public class ChocolateDecorator : BaseDecorator
    {
        private string chocolateDescription = "adding Indian chocolates";
            private double chocolateCost = 15;
        public ChocolateDecorator(IBeverage beverage) : base(beverage) { }

        public override string getBeverageDescription()
        {
            return chocolateDescription + " " + base.getBeverageDescription();
        }

        public override double getBeverageCost()
        {
            return chocolateCost + base.getBeverageCost();
        }
    }
}
