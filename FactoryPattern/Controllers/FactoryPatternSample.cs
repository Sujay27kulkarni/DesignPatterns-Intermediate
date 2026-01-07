using Microsoft.AspNetCore.Mvc;
using SimpleFactoryPattern.Abstractions;
using SimpleFactoryPattern.PizzaFactory;
using SimpleFactoryPattern.Store;

namespace FactoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactoryPatternSample : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FactoryPatternSample> _logger;

        public FactoryPatternSample(ILogger<FactoryPatternSample> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Demo")]
        public IEnumerable<WeatherForecast> Get()
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.orderPizza("margarita");
            Console.WriteLine($"Ordered a {pizza.Name}");

            pizza = store.orderPizza("veggiesuprime");
            Console.WriteLine($"Ordered a {pizza.Name}");



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
