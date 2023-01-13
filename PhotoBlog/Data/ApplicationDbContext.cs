using Microsoft.EntityFrameworkCore;

namespace PhotoBlog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts => Set<Post>();

        public DbSet<Tag> Tags => Set<Tag>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id=1,
                    Title = "Mountains & Sea",
                    Description = "Such AmAzInG,Much wOw, super ultimate picture of somewhere on 'Damnation' that we call Earth",
                    Photo = "sample.jpg"
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag() { Id = 1, Name = "Nature" },
                new Tag() { Id = 2, Name = "Sea" },
                new Tag() { Id = 3, Name = "Hiking" },
                new Tag() { Id = 4, Name = "Sunset" },
                new Tag() { Id = 5, Name = "Walk" },
                new Tag() { Id = 6, Name = "Rain" }
                );
        }
    }
}
