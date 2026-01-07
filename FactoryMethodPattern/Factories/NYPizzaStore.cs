using FactoryMethodPattern.ConcreteClasses;
using SimpleFactoryPattern.Abstractions;
using SimpleFactoryPattern.Store;

namespace FactoryMethodPattern.Store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                return new NYStyleCheesePizza();
            }

            return null!;
        }
    }
}
