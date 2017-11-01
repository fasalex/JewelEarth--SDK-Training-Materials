using Joa.JewelEarth.Basics;

namespace JewelAddinTraining.Domain.Api.Items
{
    public interface ICustomDomainObjectContainer : IItemCollection, IDomainItemContainer<ICustomDomainObject>
    {
    }
}