using System.Collections.Generic;
using System.Linq;
using NetcoreSwaggerObjectInheritance.Constants;
using NetcoreSwaggerObjectInheritance.Models;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly InMemoryDatabase _database;

        public DogRepository(InMemoryDatabase database)
        {
            _database = database;
        }

        public List<Dog> GetAll()
        {
            return _database.Pets.Where(i => i.Type == PetType.Dog)
                .Select(i => (Dog) i)
                .ToList();
        }
    }
}