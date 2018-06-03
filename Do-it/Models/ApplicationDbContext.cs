using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Do_it.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Color> Colors { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}