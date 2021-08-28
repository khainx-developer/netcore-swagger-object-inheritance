using System.Collections.Generic;
using System.Linq;
using NetcoreSwaggerObjectInheritance.Constants;
using NetcoreSwaggerObjectInheritance.Models;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance.Repositories
{
    public class CatRepository : ICatRepository
    {
        private readonly InMemoryDatabase _database;

        public CatRepository(InMemoryDatabase database)
        {
            _database = database;
        }

        public List<Cat> GetAll()
        {
            return _database.Pets.Where(i => i.Type == PetType.Cat)
                .Select(i => (Cat) i)
                .ToList();
        }
    }
}