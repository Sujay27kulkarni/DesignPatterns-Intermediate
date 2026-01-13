namespace CommandPattern.Receiver
{
    public class TextDocument
    {
        public string Content { get; private set; } = "";

        public void AppendText(string text) => Content += text;

    }
}
