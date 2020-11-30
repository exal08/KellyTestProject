using Microsoft.EntityFrameworkCore;
using KellyTestProject.Model;

namespace KellyTestProject.DBContext
{
    public class MsSqlContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public MsSqlContext(DbContextOptions<MsSqlContext> options) : base(options) { }
    }
}
