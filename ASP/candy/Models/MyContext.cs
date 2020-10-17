using Microsoft.EntityFrameworkCore;
namespace candy.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Candy> Candies { get; set; }
    }
}