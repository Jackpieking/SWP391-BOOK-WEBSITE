using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class UserIdentityContext : IdentityDbContext<IdentityUser>
{
    /// <summary>
    /// Representation of each table in the User Identity database
    /// </summary>
    #region DbSet

    public DbSet<IdentityUserRole<string>> IdentityUserRoles { get; set; }

    public DbSet<IdentityRole> IdentityRoles { get; set; }

    public DbSet<IdentityRoleClaim<string>> IdentityRoleClaims { get; set; }

    public DbSet<IdentityUser> IdentityUsers { get; set; }

    public DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; set; }

    public DbSet<IdentityUserLogin<string>> IdentityUserLogins { get; set; }

    public DbSet<IdentityUserToken<string>> IdentityUserTokens { get; set; }

    #endregion

    public UserIdentityContext(DbContextOptions<UserIdentityContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();
            if (tableName.StartsWith("AspNet"))
            {
                entityType.SetTableName(tableName[6..]);
            }
        }
    }
}
