
using MeditationTrackerApp.Models;
using System.Data.Entity;


namespace MeditationTrackerApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Meditation> Meditations { get; set; }
    }
}