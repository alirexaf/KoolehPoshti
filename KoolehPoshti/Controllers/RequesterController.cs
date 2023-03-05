using KoolehPoshti.Interfaces;
using Microsoft.AspNetCore.Mvc;
using KoolehPoshti.Models;
using KoolehPoshti.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KoolehPoshti.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RequesterController : ControllerBase
    {
        private readonly IRequesterRepository _requesterRepository;
        public RequesterController(IRequesterRepository requesterRepository)
        {
            _requesterRepository = requesterRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Requester>>> GetAll()
        {
            var requesters = await _requesterRepository.GetAllAsync();
            return Ok(requesters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Requester>> GetById(Guid id)
        {
            var requester = await _requesterRepository.GetByIdAsync(id);

            if (requester == null)
            {
                return NotFound();
            }

            return Ok(requester);
        }

        [HttpPost]
        public async Task<ActionResult<Requester>> Add(Requester requester)
        {
            await _requesterRepository.AddAsync(requester);
            return CreatedAtAction(nameof(GetById), new { id = requester.Id }, requester);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Requester requester)
        {
            if (id != requester.Id)
            {
                return BadRequest();
            }

            _requesterRepository.Update(requester);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var requester = await _requesterRepository.GetByIdAsync(id);

            if (requester == null)
            {
                return NotFound();
            }

            _requesterRepository.Delete(requester);
            return NoContent();
        }
    }
}
