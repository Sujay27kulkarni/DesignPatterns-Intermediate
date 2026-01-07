using FactoryMethodPattern.ConcreteClasses;
using SimpleFactoryPattern.Abstractions;
using SimpleFactoryPattern.Store;

namespace FactoryMethodPattern.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                return new ChicagoStyleCheesePizza();
            }
            return null!;
        }
    }
}
