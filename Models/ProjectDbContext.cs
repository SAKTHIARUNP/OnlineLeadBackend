using Microsoft.EntityFrameworkCore;

namespace OnlineLeadMgmt.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext() { }
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<Login>Logins { get; set; }
        public DbSet<Lead> Leads { get; set; }
        

    }
}
