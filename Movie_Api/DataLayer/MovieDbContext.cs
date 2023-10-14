using Microsoft.EntityFrameworkCore;
using Movie_Api.Model;

namespace Movie_Api.DataLayer
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options) {}
        public DbSet<Moveis> Moveiss { get; set; }
        public DbSet<Author> Authors { get; set; }



    }
}
