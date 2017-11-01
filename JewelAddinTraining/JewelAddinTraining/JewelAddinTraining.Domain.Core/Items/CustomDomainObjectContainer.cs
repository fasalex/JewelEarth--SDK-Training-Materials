using System;
using System.Collections.Generic;
using System.Linq;
using JewelAddinTraining.Domain.Api.Items;
using Joa.JewelEarth.Basics;

namespace JewelAddinTraining.Domain.Core.Items
{ 
    public class CustomDomainObjectContainer : ItemCollectionBase, IAdminCollection, ICustomDomainObjectContainer, ICustomDomainObjectQueryService
    {
        public CustomDomainObjectContainer() : base(@"Custom Domain Objects")
        {
            
        }
        public bool AddUnique(ICustomDomainObject item)
        {
            return AddUnique((IItem)item);
        }

        public new IEnumerator<ICustomDomainObject> GetEnumerator()
        {
            return this.OfType<ICustomDomainObject>().GetEnumerator();
        }

        public ICustomDomainObject FindById(Guid id)
        {
            return AllDomainItems.FirstOrDefault(x => x.ObjectId == id);
        }

        public ICustomDomainObject FindByName(string name)
        {
            return AllDomainItems.FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<ICustomDomainObject> AllDomainItems { get; }
    }
}