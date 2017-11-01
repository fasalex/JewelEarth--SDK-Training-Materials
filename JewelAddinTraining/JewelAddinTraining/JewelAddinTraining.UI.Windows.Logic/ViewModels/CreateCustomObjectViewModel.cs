using JewelAddinTraining.Application.Api.Commands;
using JewelAddinTraining.Application.Api.Models;
using JewelAddinTraining.Application.Api.Services;
using Joa.JewelEarth.UI.Forms.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Properties;
using Joa.JewelEarth.UI.Forms.Collections;

namespace JewelAddinTraining.UI.Windows.Logic.ViewModels
{
    public class CreateCustomObjectViewModel : OperationViewModel
    {
        public CreateCustomObjectViewModel(ILiveCollectionFactory liveCollectionFactory,
                                           ICustomDomainObjectService customDomainObjectQueryService)
        {
            Title = Resources.CreateCustomObject;

            CustomDomainObjects = liveCollectionFactory.FromModel(customDomainObjectQueryService.GetAllModels);
            ExecuteAsync = async bus =>
                           {
                               var command = new CreateCustomDomainObjectCommand(Name);
                               await bus.SendAsync(command);
                           };

        }

        public string Name { get; set; }


        public ILiveModelCollection<CustomDomainObjectModel> CustomDomainObjects { get; set; }
    }
}