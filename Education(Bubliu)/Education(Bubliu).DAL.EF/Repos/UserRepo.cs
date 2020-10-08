using Education_Bubliu_.Core.Entities;
using System.Data.Entity;

namespace Education_Bubliu_.DAL.EF.Repos
{
    public class UserContext : DbContext
    {
        public UserContext(): base("DbConnection")
        { }

        public DbSet<Users> Users { get; set; }
    }
}
