using EventsAPI.Context;
using EventsAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EventsAPI.Controllers
{
    [Route("/api/event")]
    public class EventController : Controller
    {

        private readonly EventDbContext _context;

        public EventController(EventDbContext context)
        {
            this._context = context;
        }
       

        [HttpGet]
        public IActionResult GetAll()
        {
            var listaAll = _context.ListEvents.Where(e => !e.isDeleted).ToList();

            if (listaAll == null) return NotFound();

            return Ok(listaAll);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var dEvent = _context.ListEvents.SingleOrDefault(e => e.Id == id);

            if(dEvent == null) return NotFound();   

            return Ok(dEvent);  
        }

        [HttpPost]
        public IActionResult Post(Event evento)
        {
            _context.ListEvents.Add(evento);

            //that is body response
            return CreatedAtAction(nameof(GetById), new { id = evento.Id },evento);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Event input)
        {
            var dEvent = _context.ListEvents.SingleOrDefault(e => e.Id == id);

            if (dEvent == null) return NotFound();

            dEvent.Update(input);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) {
            var dEvent = _context.ListEvents.SingleOrDefault(e => e.Id == id);

            if (dEvent == null) return NotFound();

            dEvent.Delete();

            return NoContent();
        }
    }
}
