using Joa.JewelEarth.Infrastructure.CommandProcessing;

namespace JewelAddinTraining.Application.Api.Commands
{
    public class CreatePolylineSetCommand : ICommandMessage
    {
        public CreatePolylineSetCommand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
