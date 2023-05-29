using EventsAPI.Entities;

namespace EventsAPI.Context
{
    public class EventDbContext
    {
        public List<Event> ListEvents { get; set; }

        public EventDbContext()
        {
            ListEvents = new List<Event>(); 
        }
    }
}
