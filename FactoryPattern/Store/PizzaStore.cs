using SimpleFactoryPattern.Abstractions;
using SimpleFactoryPattern.PizzaFactory;

namespace SimpleFactoryPattern.Store
{
    public class PizzaStore
    {
        public readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
