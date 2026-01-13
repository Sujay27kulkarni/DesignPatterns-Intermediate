namespace CommandPattern.Commands.Absrtractions
{
    public interface ICustomCommand
    {
        public void execute();
        public void unExecute();

    }
}
