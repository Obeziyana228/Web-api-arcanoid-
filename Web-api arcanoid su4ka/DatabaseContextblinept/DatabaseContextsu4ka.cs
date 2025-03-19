using Microsoft.EntityFrameworkCore;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.DatabaseContextblinept
{
    public class DatabaseContextsu4ka : DbContext
    {
        public DatabaseContextsu4ka(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usermodel> Usermodels { get; set; }
        public DbSet<Skinmodel> Skinmodels { get; set; }
        public DbSet<UserSkinSvaz> Userskinmodel { get; set; }
    }
}
