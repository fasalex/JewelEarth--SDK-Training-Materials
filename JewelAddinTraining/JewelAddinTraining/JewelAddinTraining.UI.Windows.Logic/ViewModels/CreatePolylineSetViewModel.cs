using JewelAddinTraining.Application.Api.Commands;
using Joa.JewelEarth.UI.Forms.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Properties;

namespace JewelAddinTraining.UI.Windows.Logic.ViewModels
{
    public class CreatePolylineSetViewModel : OperationViewModel
    {
        public CreatePolylineSetViewModel()
        {
            Title = Resources.CreatePolylineSet;

            ExecuteAsync = async bus =>
                           {
                               var command = new CreatePolylineSetCommand(@"Test PolylineSet");
                               await bus.SendAsync(command);
                           };
        }
    }
}