using NetcoreSwaggerObjectInheritance.Constants;

namespace NetcoreSwaggerObjectInheritance.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; } = PetType.Unknown;
    }
}