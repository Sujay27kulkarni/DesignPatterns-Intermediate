using CommandPattern.Commands;
using CommandPattern.Receiver;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathOperationsSample : ControllerBase
    {
        private readonly ILogger<MathOperationsSample> _logger;
        public MathOperationsSample(ILogger<MathOperationsSample> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "MathOperationsSample")]
        public IActionResult Get()
        {
            MathOperations mathOps = new MathOperations();
            var opsInvoker = new Invoker.MathManger();

            var addCommand = new AddCommand(mathOps, 5);
            opsInvoker.Execute(addCommand);
            var add10Command = new AddCommand(mathOps, 15);
            opsInvoker.Execute(add10Command);
            opsInvoker.Undo();

            return Ok(new { result = mathOps.Value });
        }

    }
}
