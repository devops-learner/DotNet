using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Models;

namespace Shop.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public ApplicationDbContext(string connectionString) : base(connectionString)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}