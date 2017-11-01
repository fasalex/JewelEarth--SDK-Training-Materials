using Joa.JewelEarth.UI.Forms.Actions;
using JewelAddinTraining.UI.Windows.Logic.ViewModels;
using JewelAddinTraining.UI.Windows.Logic.Properties;

namespace JewelAddinTraining.UI.Windows.Logic.Actions
{
    public class CreatePolylineSetAction : RoutingAction<CreatePolylineSetViewModel>
    {
        public CreatePolylineSetAction()
        {
            Text = Resources.CreatePolylineSet;
        }
    }
}
