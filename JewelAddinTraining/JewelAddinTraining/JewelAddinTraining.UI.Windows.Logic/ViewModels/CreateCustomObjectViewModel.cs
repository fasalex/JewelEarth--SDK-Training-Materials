using JewelAddinTraining.Application.Api.Commands;
using Joa.JewelEarth.UI.Forms.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Properties;

namespace JewelAddinTraining.UI.Windows.Logic.ViewModels
{
    public class CreateCustomObjectViewModel : OperationViewModel
    {
        public CreateCustomObjectViewModel()
        {
            Title = Resources.CreateCustomObject;

            ExecuteAsync = async bus =>
                           {
                               var command = new CreateCustomDomainObjectCommand(Name);
                               await bus.SendAsync(command);
                           };

        }

        public string Name { get; set; }
    }
}