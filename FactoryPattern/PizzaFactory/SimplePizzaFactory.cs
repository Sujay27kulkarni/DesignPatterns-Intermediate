using SimpleFactoryPattern.Abstractions;
using SimpleFactoryPattern.ConcreteClasses;

namespace SimpleFactoryPattern.PizzaFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type) {

            Pizza? pizza = null;

            switch (type.ToLower())
            {
                case "margarita":
                    pizza = new Margarita();
                    break;
                case "veggiesuprime":
                    pizza = new VeggieSuprimePizza();
                    break;
                default:
                    throw new ArgumentException("Invalid pizza type");
            }
            return pizza;
        }
    }
}
