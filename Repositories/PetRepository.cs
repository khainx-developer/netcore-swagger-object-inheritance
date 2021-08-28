using System.Collections.Generic;
using System.Linq;
using NetcoreSwaggerObjectInheritance.Models;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly InMemoryDatabase _database;

        public PetRepository(InMemoryDatabase database)
        {
            _database = database;
        }

        public List<Pet> GetAll()
        {
            return _database.Pets.ToList();
        }
    }
}