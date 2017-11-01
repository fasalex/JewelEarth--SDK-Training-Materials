using JewelAddinTraining.Domain.Core.Items;
using Joa.JewelEarth.Basics;
using Joa.JewelEarth.Basics.Images;

namespace JewelAddinTraining.UI.Windows.Core
{
    public class CustomObjectIcons : IImageProvider
    {
        public ImageInfo GetImageInfo(IItem item)
        {
            if (item is CustomDomainObjectContainer)
            {
                return new ImageInfo(@"CustomObjectContainer");
            }
            if (item is CustomDomainObject)
            {
                return new ImageInfo(@"CustomObject");
            }
            return null; 
        }
    }
}