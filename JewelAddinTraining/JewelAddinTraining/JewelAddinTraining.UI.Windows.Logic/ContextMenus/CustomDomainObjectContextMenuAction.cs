using JewelAddinTraining.Domain.Api.Items;
using Joa.JewelEarth.UI.Framework.ContextMenu;

namespace JewelAddinTraining.UI.Windows.Logic.ContextMenus
{
    public class CustomDomainObjectContextMenuAction : ContextMenuActionBase<ICustomDomainObject>
    {
        public CustomDomainObjectContextMenuAction()
        {
            Text = @"Test Custom Context Menu";
        }
        protected override void OnExecute()
        {
            throw new System.NotImplementedException();
        }
    }
}