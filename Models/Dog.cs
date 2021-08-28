using NetcoreSwaggerObjectInheritance.Constants;

namespace NetcoreSwaggerObjectInheritance.Models
{
    public class Dog : Pet
    {
        public Dog()
        {
            Type = PetType.Dog;
        }

        public DogType DogType { get; set; } = DogType.Unknown;
    }
}