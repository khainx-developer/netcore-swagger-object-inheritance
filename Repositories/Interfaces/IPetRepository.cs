using System.Collections.Generic;
using NetcoreSwaggerObjectInheritance.Models;

namespace NetcoreSwaggerObjectInheritance.Repositories.Interfaces
{
    public interface IPetRepository
    {
        List<Pet> GetAll();
    }
}