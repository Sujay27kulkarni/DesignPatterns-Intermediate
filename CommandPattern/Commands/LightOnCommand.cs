using CommandPattern.Receiver;


using ICustomCommand = CommandPattern.Commands.Absrtractions.ICustomCommand;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICustomCommand
    {
        private readonly LightsOperation switchOnLights;
        public LightOnCommand(LightsOperation switchOnLights)
        {
            this.switchOnLights = switchOnLights;
        }
        public void execute()
        {
            switchOnLights.On();
        }

        public void unExecute()
        {
            throw new NotImplementedException();
        }
    }
}
