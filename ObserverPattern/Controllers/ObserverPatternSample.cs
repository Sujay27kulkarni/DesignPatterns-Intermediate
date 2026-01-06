using Microsoft.AspNetCore.Mvc;
using ObserverPattern.Observers.Implementations;
using ObserverPattern.Subject.Implementations;

namespace ObserverPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObserverPatternSample : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ObserverPatternSample> _logger;

        public ObserverPatternSample(ILogger<ObserverPatternSample> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Demo")]
        public IEnumerable<WeatherForecast> Get()
        {
            NewsAgencySubject newsAgency = new NewsAgencySubject();

            newsAgency.RegisterObserver(new NewsPaperSubscriber());
            newsAgency.RegisterObserver(new EmailSubscriber());
            newsAgency.RegisterObserver(new NotificationSubscriber());

            newsAgency.ReleaseNews("Breaking News: Sujay successfully implement very basic version of the observer pattern!");

            newsAgency.DeRegisterObserver(new EmailSubscriber());
            newsAgency.ReleaseNews("Breaking News: Sujay successfully implement very basic version of the observer pattern and removed email subscriber!");

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
