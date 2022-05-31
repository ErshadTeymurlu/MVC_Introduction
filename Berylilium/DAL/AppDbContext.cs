using Berylilium.Models;
using Microsoft.EntityFrameworkCore;

namespace Berylilium.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {}
        public DbSet<Banner> banners { get; set; }
        public DbSet<HeadingText> HeadingTexts { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
    }
}
