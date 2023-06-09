using Microsoft.AspNetCore.Mvc;
using Humanos.Models;
using System.Collections.Generic;

namespace Humanos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanosController : ControllerBase
    {
        private static List<HumanoModel> _humanos = new List<HumanoModel>();

        // GET: api/Humanos
        [HttpGet]
        public IActionResult GetHumanos()
        {
            return Ok(_humanos);
        }

        // GET: api/Humanos/5
        [HttpGet("{id}")]
        public IActionResult GetHumano(int id)
        {
            var humano = _humanos.Find(h => h.Id == id);
            if (humano == null)
            {
                return NotFound();
            }
            return Ok(humano);
        }

        // POST: api/Humanos
        [HttpPost]
        public IActionResult CreateHumano(HumanoModel humano)
        {
            humano.Id = _humanos.Count + 1;
            _humanos.Add(humano);
            return CreatedAtAction(nameof(GetHumano), new { id = humano.Id }, humano);
        }

        // PUT: api/Humanos/5
        [HttpPut("{id}")]
        public IActionResult UpdateHumano(int id, HumanoModel humano)
        {
            var index = _humanos.FindIndex(h => h.Id == id);
            if (index == -1)
            {
                return NotFound();
            }

            humano.Id = id;
            _humanos[index] = humano;
            return NoContent();
        }

        // DELETE: api/Humanos/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHumano(int id)
        {
            var humano = _humanos.Find(h => h.Id == id);
            if (humano == null)
            {
                return NotFound();
            }

            _humanos.Remove(humano);
            return NoContent();
        }
    }
}
