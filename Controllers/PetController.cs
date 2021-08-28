using Microsoft.AspNetCore.Mvc;
using NetcoreSwaggerObjectInheritance.Models;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpGet]
        public ObjectList<Pet> GetAll()
        {
            var items = _petRepository.GetAll();
            return new ObjectList<Pet>
            {
                Total = items.Count,
                Items = items
            };
        }
    }
}