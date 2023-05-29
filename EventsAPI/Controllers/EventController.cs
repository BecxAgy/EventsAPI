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
        public IActionResult Index()
        {
            return View();
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

        }

        [HttpPost]
        public IActionResult Post(Event evento)
        {

        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Event evento)
        {

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) { }
    }
}
