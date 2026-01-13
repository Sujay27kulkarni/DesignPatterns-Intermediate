using CommandPattern.Commands.Absrtractions;
using CommandPattern.Receiver;
using System.Windows.Input;

namespace CommandPattern.Commands
{
    public class AddCommand : ICustomCommand
    {
        private readonly MathOperations _mathOperations;
        private readonly int _amount;

        public AddCommand(MathOperations ops, int numberToAdd)
        {
            _mathOperations = ops;
            _amount = numberToAdd;
        }
        public void execute()
        {
            _mathOperations.Add(_amount);
        }

        public void unExecute()
        {
           _mathOperations.Substract(_amount);
        }
    }
}
