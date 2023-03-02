using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KoolehPoshti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestRepository _requestRepository;

        public RequestController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetAll()
        {
            var requests = await _requestRepository.GetAllAsync();
            return Ok(requests);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetById(int id)
        {
            var request = await _requestRepository.GetByIdAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpPost]
        public async Task<ActionResult<Request>> Add(Request request)
        {
            await _requestRepository.AddAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = request.Id }, request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            _requestRepository.Update(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = await _requestRepository.GetByIdAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            _requestRepository.Delete(request);
            return NoContent();
        }
    }
}
