using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Decorators
{
    public class CreamDecorator : BaseDecorator
    {
        private const string creamDescription = "adding Extra cream";
        private const double creamCost = 15;
        public CreamDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string getBeverageDescription() => creamDescription + " " + base.getBeverageDescription();
        public override double getBeverageCost() => creamCost + base.getBeverageCost();
    }
}
