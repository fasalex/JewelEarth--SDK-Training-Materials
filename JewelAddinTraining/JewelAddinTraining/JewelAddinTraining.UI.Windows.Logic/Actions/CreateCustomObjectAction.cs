using Joa.JewelEarth.UI.Forms.Actions;
using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Properties;

namespace JewelAddinTraining.UI.Windows.Logic.Actions
{
    internal class CreateCustomObjectAction : RoutingAction<CreateCustomObjectViewModel>
    {
        public CreateCustomObjectAction()
        {
            Text = Resources.CreateCustomObject;
        }
    }
}
