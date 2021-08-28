using Microsoft.AspNetCore.Mvc;
using NetcoreSwaggerObjectInheritance.Models;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        private readonly IDogRepository _dogRepository;

        public DogController(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        [HttpGet]
        public ObjectList<Dog> GetAll()
        {
            var items = _dogRepository.GetAll();
            return new ObjectList<Dog>
            {
                Total = items.Count,
                Items = items
            };
        }
    }
}