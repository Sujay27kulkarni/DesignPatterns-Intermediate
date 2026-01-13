using CommandPattern.Commands.Absrtractions;
using CommandPattern.Receiver;
using static System.Net.Mime.MediaTypeNames;

namespace CommandPattern.Commands
{
    public class AppendTextCommand : ICustomCommand
    {
        private readonly TextDocument _document;
        private readonly string _textToAppend;

        public AppendTextCommand(TextDocument document, string textToAppend)
        {
            _document = document;
            _textToAppend = textToAppend;
        }
        public void execute()
        {
           _document.AppendText(_textToAppend);
        }

        public void unExecute()
        {
            throw new NotImplementedException();
        }
    }
}
