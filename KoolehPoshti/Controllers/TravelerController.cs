using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoolehPoshti.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TravelerController : ControllerBase
    {
        private readonly ITravelerRepository _travelerRepository;
        public TravelerController(ITravelerRepository travelerRepository)
        {
            _travelerRepository = travelerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Traveler>>> GetAll()
        {
            var travelers = await _travelerRepository.GetAllAsync();
            return Ok(travelers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Traveler>> GetById(Guid id)
        {
            var traveler = await _travelerRepository.GetByIdAsync(id);

            if (traveler == null)
            {
                return NotFound();
            }

            return Ok(traveler);
        }

        [HttpPost]
        public async Task<ActionResult<Traveler>> Add(Traveler traveler)
        {
            await _travelerRepository.AddAsync(traveler);
            return CreatedAtAction(nameof(GetById), new { id = traveler.Id }, traveler);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Traveler traveler)
        {
            if (id != traveler.Id)
            {
                return BadRequest();
            }

            _travelerRepository.Update(traveler);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var traveler = await _travelerRepository.GetByIdAsync(id);

            if (traveler == null)
            {
                return NotFound();
            }

            _travelerRepository.Delete(traveler);
            return NoContent();
        }
    }
}
