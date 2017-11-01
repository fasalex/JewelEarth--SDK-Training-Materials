using System.Collections.Generic;
using JewelAddinTraining.Application.Api.Models;

namespace JewelAddinTraining.Application.Api.Services
{
    public interface ICustomDomainObjectService
    {
        IEnumerable<CustomDomainObjectModel> GetAllModels();
    }
}