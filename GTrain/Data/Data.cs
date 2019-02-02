using GTrain.Models;
using Microsoft.EntityFrameworkCore;

namespace GTrain.Data
{
    public class TrainingDbContext : DbContext
    {
        public DbSet<Topic> Topics { get; set; }
        //public DbSet<CheeseCategory> Categories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TopicCategory> TopicCategories { get; set; }

        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options)
        {
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TopicCategory>()
                .HasKey(c => new { c.TopicID, c.CategoryID });
        }

    }
}