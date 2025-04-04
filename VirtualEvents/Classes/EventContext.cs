using Microsoft.EntityFrameworkCore;

namespace VirtualEvents
{
    class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; } = null!;
        public EventContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Events;Username=postgres;Password=KekaNestea");
        }
    }
}