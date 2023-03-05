using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoolehPoshti.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageRepository _packageRepository;
        public PackageController(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Package>>> GetAll()
        {
            var packages = await _packageRepository.GetAllAsync();
            return Ok(packages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Package>> GetById(Guid id)
        {
            var package = await _packageRepository.GetByIdAsync(id);

            if (package == null)
            {
                return NotFound();
            }

            return Ok(package);
        }

        [HttpPost]
        public async Task<ActionResult<Package>> Add(Package package)
        {
            await _packageRepository.AddAsync(package);
            return CreatedAtAction(nameof(GetById), new { id = package.Id }, package);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Package package)
        {
            if (id != package.Id)
            {
                return BadRequest();
            }

            _packageRepository.Update(package);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var package = await _packageRepository.GetByIdAsync(id);

            if (package == null)
            {
                return NotFound();
            }

            _packageRepository.Delete(package);
            return NoContent();
        }
    }
}
