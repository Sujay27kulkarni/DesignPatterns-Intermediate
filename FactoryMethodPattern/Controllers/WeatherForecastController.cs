
using FactoryMethodPattern.Store;
using Microsoft.AspNetCore.Mvc;
using SimpleFactoryPattern.Abstractions;
using SimpleFactoryPattern.Store;

namespace FactoryMethodPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            PizzaStore nyStore = new NYPizzaStore(); 
            PizzaStore chicagoStore = new ChicagoPizzaStore(); 
            Pizza pizza1 = nyStore.OrderPizza("cheese"); 
            
            Console.WriteLine($"Ordered a {pizza1.Name}\n"); 
            
            Pizza pizza2 = chicagoStore.OrderPizza("cheese"); 
            Console.WriteLine($"Ordered a {pizza2.Name}\n");

            return Ok("Pizzas ordered successfully.");
        }
    }
}
