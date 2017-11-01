using JewelAddinTraining.Domain.Api.Items;
using Joa.JewelEarth.Basics;

namespace JewelAddinTraining.Domain.Core.Items
{
    public class CustomDomainObject : ItemBase, ICustomDomainObject
    {
        public bool ReadLock()
        {
            return true;
        }

        public void ReadUnlock()
        {
        }

        public bool WriteLock()
        {
            return true;

        }

        public void WriteUnlock()
        {
        }

        public bool IsReadLocked()
        {
            return true;
        }

        public bool IsWriteLocked()
        {
            return true;
        }
    }
}