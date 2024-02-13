using Categories;
using MangaBooks;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class MangaAppContext : DbContext
    {
        public MangaAppContext(DbContextOptions<MangaAppContext> options) : base(options)
        {

        }

        public DbSet<MangaBook> MangaBooks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
