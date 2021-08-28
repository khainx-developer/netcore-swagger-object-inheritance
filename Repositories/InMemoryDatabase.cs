using System.Collections.Generic;
using NetcoreSwaggerObjectInheritance.Constants;
using NetcoreSwaggerObjectInheritance.Models;

namespace NetcoreSwaggerObjectInheritance.Repositories
{
    public class InMemoryDatabase
    {
        public InMemoryDatabase()
        {
            Pets = new List<Pet>
            {
                new Dog {Id = 1, Name = "Dog 1", DogType = DogType.Bulldog},
                new Dog {Id = 2, Name = "Dog 2", DogType = DogType.Hound},
                new Dog {Id = 3, Name = "Dog 3", DogType = DogType.Hound},
                new Cat {Id = 4, Name = "Cat 1", CatType = CatType.Calico},
                new Cat {Id = 5, Name = "Cat 2", CatType = CatType.Snowshoe},
                new Cat {Id = 6, Name = "Cat 3", CatType = CatType.Calico},
            };
        }

        public List<Pet> Pets { get; }
    }
}