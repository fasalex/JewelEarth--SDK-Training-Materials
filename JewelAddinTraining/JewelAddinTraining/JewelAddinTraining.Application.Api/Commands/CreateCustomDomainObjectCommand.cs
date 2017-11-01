using Joa.JewelEarth.Infrastructure.CommandProcessing;

namespace JewelAddinTraining.Application.Api.Commands
{
    public class CreateCustomDomainObjectCommand : ICommandMessage
    {
        public CreateCustomDomainObjectCommand(string name)
        {
            Name = name; 
        }
        public string Name { get; set; }
    }
}
