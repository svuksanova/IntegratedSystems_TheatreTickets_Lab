using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheatreTickets.Domain.Identity;

namespace TheatreTickets.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Domain.Domain.TheatreShow> TheatreShow { get; set; }
    public DbSet<Domain.Domain.Ticket> Ticket { get; set; }


}
