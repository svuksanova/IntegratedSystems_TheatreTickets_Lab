using TheatreTickets.Domain.Identity;

namespace TheatreTickets.Domain.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? OwnerId { get; set; }
        public TheatreShow? Show { get; set; }
        public Guid ShowId { get; set; }
        public double price { get; set; }

    }
}
