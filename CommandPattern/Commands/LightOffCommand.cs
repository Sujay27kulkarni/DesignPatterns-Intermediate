using CommandPattern.Receiver;


using ICommand = CommandPattern.Commands.Absrtractions.ICommand;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly LightsOperation switchOnLights;
        public LightOffCommand(LightsOperation switchOnLights)
        {
            this.switchOnLights = switchOnLights;
        }
        public void execute()
        {
            switchOnLights.Off();
        }

        public void unExecute()
        {
            throw new NotImplementedException();
        }
    }
}
