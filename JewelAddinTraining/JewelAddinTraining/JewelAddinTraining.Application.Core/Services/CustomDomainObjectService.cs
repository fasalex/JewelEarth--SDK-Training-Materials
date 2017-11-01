using System.Collections.Generic;
using System.Linq;
using JewelAddinTraining.Application.Api.Models;
using JewelAddinTraining.Application.Api.Services;
using JewelAddinTraining.Domain.Api.Items;
using Joa.JewelEarth.Basics.Models;
using Joa.JewelEarth.Infrastructure.Application;

namespace JewelAddinTraining.Application.Core.Services
{
    public class CustomDomainObjectService : ModelQueryAdmin<CustomDomainObjectModel, ICustomDomainObject, ICustomDomainObjectContainer>, ICustomDomainObjectService
    {
        public IEnumerable<CustomDomainObjectModel> GetAllModels()
        {
            return Admin.Select(x => x.ToModel<CustomDomainObjectModel>());
        }
    }
}
