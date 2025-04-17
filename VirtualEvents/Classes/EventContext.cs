using Microsoft.EntityFrameworkCore;

namespace VirtualEvents
{
    /// <summary>
    /// Контекст базы данных 
    /// </summary>
    public class EventContext : DbContext
    {
        /// <summary>
        /// Таблица в базе данных
        /// </summary>
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