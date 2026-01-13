using CommandPattern.Commands.Absrtractions;
using CommandPattern.Invoker.Absrtractions;

namespace CommandPattern.Invoker
{
    public class EditorInvoker : IInvoker
    {
        public void Execute(ICommand command)
        {
            command.execute();
        }
    }
}
