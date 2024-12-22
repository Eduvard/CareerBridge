using Microsoft.EntityFrameworkCore;

namespace CareerBridge.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserSign> Usersigns { get; set; }
        public DbSet<SuccessStories> SuccessStorie { get; set; }
        public DbSet<CareerArticle> CareerArticles { get; set; }
    }
}
