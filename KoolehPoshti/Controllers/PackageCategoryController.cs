using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoolehPoshti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageCategoryController : ControllerBase
    {
        private readonly IPackageCategoryRepository _packageCategoryRepository;
        public PackageCategoryController(IPackageCategoryRepository packageCategoryRepository)
        {
            _packageCategoryRepository = packageCategoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PackageCategory>>> GetAll()
        {
            var packageCategories = await _packageCategoryRepository.GetAllAsync();
            return Ok(packageCategories);
        }
    }
}
