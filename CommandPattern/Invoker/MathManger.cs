using CommandPattern.Commands.Absrtractions;
using CommandPattern.Invoker.Absrtractions;
using System.Windows.Input;

namespace CommandPattern.Invoker
{
    public class MathManger : IInvoker
    {

        private readonly Stack<ICustomCommand> _undoStack = new();
        private readonly Stack<ICustomCommand> _redoStack = new();

        public void Execute(ICustomCommand command)
        {
            command.execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }


        public void Undo()
        {
            if (_undoStack.Count == 0) return;
            var command = _undoStack.Pop();
            command.unExecute();
            _redoStack.Push(command);
        }

        public void Redo()
        {
            if (_redoStack.Count == 0) return;
            var command = _redoStack.Pop();
            command.execute();
            _undoStack.Push(command);
        }

    }
}
