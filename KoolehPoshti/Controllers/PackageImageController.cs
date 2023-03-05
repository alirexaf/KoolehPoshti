using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoolehPoshti.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PackageImageController : ControllerBase
    {
        private readonly IPackageImageRepository _packageImageRepository;
        public PackageImageController(IPackageImageRepository packageImageRepository)
        {
            _packageImageRepository = packageImageRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PackageImage>>> GetAll()
        {
            var packageImages = await _packageImageRepository.GetAllAsync();
            return Ok(packageImages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PackageImage>> GetById(Guid id)
        {
            var packageImage = await _packageImageRepository.GetByIdAsync(id);

            if (packageImage == null)
            {
                return NotFound();
            }

            return Ok(packageImage);
        }

        [HttpPost]
        public async Task<ActionResult<PackageImage>> Add(PackageImage packageImage)
        {
            await _packageImageRepository.AddAsync(packageImage);
            return CreatedAtAction(nameof(GetById), new { id = packageImage.Id }, packageImage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, PackageImage packageImage)
        {
            if (id != packageImage.Id)
            {
                return BadRequest();
            }

            _packageImageRepository.Update(packageImage);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var packageImage = await _packageImageRepository.GetByIdAsync(id);

            if (packageImage == null)
            {
                return NotFound();
            }

            _packageImageRepository.Delete(packageImage);
            return NoContent();
        }
    }
}
