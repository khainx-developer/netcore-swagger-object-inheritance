using Microsoft.AspNetCore.Mvc;
using NetcoreSwaggerObjectInheritance.Models;
using NetcoreSwaggerObjectInheritance.Repositories.Interfaces;

namespace NetcoreSwaggerObjectInheritance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        private readonly ICatRepository _catRepository;

        public CatController(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        [HttpGet]
        public ObjectList<Cat> GetAll()
        {
            var items = _catRepository.GetAll();
            return new ObjectList<Cat>
            {
                Total = items.Count,
                Items = items
            };
        }
    }
}