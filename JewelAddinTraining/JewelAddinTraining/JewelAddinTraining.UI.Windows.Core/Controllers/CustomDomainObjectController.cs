using JewelAddinTraining.Domain.Api.Items;
using Joa.JewelEarth.UI.JewelExplorer.Controllers;

namespace JewelAddinTraining.UI.Windows.Core.Controllers
{
    public class CustomDomainObjectController : ViewModelController
    {
        public CustomDomainObjectController() : base(1)
        {

        }
        public CustomDomainObjectController(int version)
            : base(version)
        {
            AddTypeToHandle<ICustomDomainObjectContainer>();
            AddTypeToHandle<ICustomDomainObject>();
        }
    }
}