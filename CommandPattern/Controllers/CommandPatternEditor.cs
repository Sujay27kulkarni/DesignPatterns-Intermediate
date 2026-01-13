using CommandPattern.Commands;
using CommandPattern.Receiver;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandPatternEditor : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CommandPatternEditor> _logger;

        public CommandPatternEditor(ILogger<CommandPatternEditor> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "CommandPatternEditor")]
        public IActionResult Get()
        {
            var doc = new Receiver.TextDocument();
            var invoker = new Invoker.EditorInvoker();
            var command = new AppendTextCommand(doc, "Sujay, ");

            invoker.Execute(command);
            invoker.Execute(new AppendTextCommand(doc, "hahhahahahah!"));

            var lightsReciever = new LightsOperation();
            var lightsOnInvoker = new Invoker.LightsOperationInvoker();

            var lightsOnCommand = new LightOnCommand(lightsReciever);
            lightsOnInvoker.Execute(lightsOnCommand);

            var lightsOffCommand = new LightOffCommand(lightsReciever);
            lightsOnInvoker.Execute(lightsOffCommand);


            Console.WriteLine(doc.Content);


            return Ok(Summaries);
        }
    }
}
