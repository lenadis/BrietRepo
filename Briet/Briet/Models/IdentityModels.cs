using Microsoft.AspNet.Identity.EntityFramework;

namespace Briet.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Briet.Controllers.Subtitle> Subtitles { get; set; }

        public System.Data.Entity.DbSet<Briet.Controllers.Titles> Titles { get; set; }

        public System.Data.Entity.DbSet<Briet.Controllers.SubPartText> SubPartTexts { get; set; }
    }
}