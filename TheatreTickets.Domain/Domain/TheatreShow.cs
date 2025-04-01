namespace TheatreTickets.Domain.Domain
{
    public class TheatreShow
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Place { get; set; }
        public DateTime ShowDate { get; set; }
        public string? ShowImageUrl { get; set; }
    }
}
