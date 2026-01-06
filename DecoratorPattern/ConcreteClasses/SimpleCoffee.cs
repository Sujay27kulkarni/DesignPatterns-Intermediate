using DecoratorPattern.Abstractions;

namespace DecoratorPattern.ConcreteClasses
{
    public class SimpleCoffee : IBeverage
    {
        private string _coffeeDescription = string.Empty;
        public SimpleCoffee(string coffeeDescription = "This is a simple coffee")
        {
            _coffeeDescription = coffeeDescription;
        }
        public double getBeverageCost() => 20;
        public string getBeverageDescription() => _coffeeDescription;
        
    }
}
