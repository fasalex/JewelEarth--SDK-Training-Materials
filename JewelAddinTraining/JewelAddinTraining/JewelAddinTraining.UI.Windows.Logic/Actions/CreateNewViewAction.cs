using Joa.JewelEarth.UI.Forms.Actions;
using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Properties;

namespace JewelAddinTraining.UI.Windows.Logic.Actions
{
    internal class CreateNewViewAction : RoutingAction<CreateNewViewViewModel>
    {
        public CreateNewViewAction()
        {
            Text = Resources.NewView;
        }
    }
}
