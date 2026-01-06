using DecoratorPattern.Abstractions;
using DecoratorPattern.ConcreteClasses;
using DecoratorPattern.Decorators;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleCoffeeDecoratorPattern : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SimpleCoffeeDecoratorPattern> _logger;

        public SimpleCoffeeDecoratorPattern(ILogger<SimpleCoffeeDecoratorPattern> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Demo")]
        public IEnumerable<WeatherForecast> Get()
        {
            
            IBeverage _strongCoffee = new SimpleCoffee("Strong coffee extra hot");
            _strongCoffee = new MilkDecorator(_strongCoffee);
            _strongCoffee = new CreamDecorator(_strongCoffee);
            _strongCoffee = new ChocolateDecorator(_strongCoffee);

            Console.WriteLine($"{_strongCoffee.getBeverageDescription()} : ${_strongCoffee.getBeverageCost()}");

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
