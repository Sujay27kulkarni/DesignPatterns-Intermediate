using CommandPattern.Commands.Absrtractions;

namespace CommandPattern.Invoker.Absrtractions
{
    public interface IInvoker
    {
        void Execute(ICommand command); 
    }
}
