using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Versus.Models.Data
{
    public class Db : IdentityDbContext<ApplicationUser>
    {

        public Db() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<ScoresDTO> Scores { get; set; }
    }
}