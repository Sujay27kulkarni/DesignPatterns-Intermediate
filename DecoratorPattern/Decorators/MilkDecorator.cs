using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Decorators
{
    public class MilkDecorator : BaseDecorator
    {
        private double extraMilkCost = 10;
        private string milkDescription = "adding skimmed milk.";
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override double getBeverageCost()
        {
            return extraMilkCost + base.getBeverageCost();
        }

        public override string getBeverageDescription()
        {
            return milkDescription + " " + base.getBeverageDescription();
        }
    }
}
