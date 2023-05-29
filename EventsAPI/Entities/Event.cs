namespace EventsAPI.Entities
{
    public class Event
    {
        public Event()
        {
            isDeleted = false;

        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Speaker> Speakers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isDeleted { get; set; }

        public void Update(Event evento)
        {
            this.Title = evento.Title;
            this.Description = evento.Description;
            this.StartDate = evento.StartDate;
            this.EndDate = evento.EndDate;

        }

        public void Delete()
        {
            this.isDeleted = true;
        }

    }
}
