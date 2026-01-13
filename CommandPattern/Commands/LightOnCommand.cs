using CommandPattern.Receiver;


using ICommand = CommandPattern.Commands.Absrtractions.ICommand;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICommand
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
