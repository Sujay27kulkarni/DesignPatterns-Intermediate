using CommandPattern.Commands.Absrtractions;
using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
    public class SubtractCommand : ICustomCommand
    {
        private readonly int _numberToSubtract;
        private readonly MathOperations _mathOps;

        public SubtractCommand(MathOperations ops, int amount)
        {
            _mathOps = ops;
            _numberToSubtract = amount; 

        }
        public void execute()
        {
            _mathOps.Substract(_numberToSubtract);
        }

        public void unExecute()
        {
           _mathOps.Add(_numberToSubtract);
        }
    }
}
