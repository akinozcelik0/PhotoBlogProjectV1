using Microsoft.EntityFrameworkCore;

namespace PhotoBlog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts => Set<Post>();

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
        }
    }
}
