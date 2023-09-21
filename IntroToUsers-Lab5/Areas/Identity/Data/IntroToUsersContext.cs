using IntroToUsers_Lab5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IntroToUsers_Lab5.Models;
using System.Reflection.Metadata;
using System.Reflection.Emit;

namespace IntroToUsers_Lab5.Areas.Identity.Data;

public class IntroToUsersContext : IdentityDbContext<DemoUser>
{
    public IntroToUsersContext(DbContextOptions<IntroToUsersContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<Account>()
           .Property(b => b.Balance).HasColumnType("money");
    }

    public DbSet<Account>? Accounts { get; set; } = null!;

}
