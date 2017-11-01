using JewelAddinTraining.Application.Api.Commands;
using JewelAddinTraining.Domain.Api.Items;
using JewelAddinTraining.Domain.Core.Items;
using Joa.JewelEarth.Infrastructure.CommandProcessing;

namespace InfrastructureDemo.Application.Logic.Handlers
{
    public class CreateCustomDomainObjectCommandHandler : ICommandHandler<CreateCustomDomainObjectCommand>
    {
        private readonly ICustomDomainObjectContainer m_customDomainObjectContainer;

        public CreateCustomDomainObjectCommandHandler(ICustomDomainObjectContainer customDomainObjectContainer)
        {
            m_customDomainObjectContainer = customDomainObjectContainer;
        }
        public void Process(CreateCustomDomainObjectCommand command)
        {
            var customDomainObject = new CustomDomainObject {Name = command.Name};
            m_customDomainObjectContainer.Add(customDomainObject);

        }
    }
}
