using NetcoreSwaggerObjectInheritance.Constants;

namespace NetcoreSwaggerObjectInheritance.Models
{
    public class Cat : Pet
    {
        public Cat()
        {
            Type = PetType.Cat;
        }

        public CatType CatType { get; set; }= CatType.Unknown;
    }
}