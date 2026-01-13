using CommandPattern.Receiver;


using ICustomCommand = CommandPattern.Commands.Absrtractions.ICustomCommand;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICustomCommand
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
