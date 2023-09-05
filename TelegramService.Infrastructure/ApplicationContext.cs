using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TelegramService.Infrastructure.Data.Configuration;
using TelegramService.Shared.Enums;
using TelegramService.Infrastructure.Data.Models;

namespace TelegramService.Infrastructure.Data;

public class ApplicationContext : IdentityDbContext<User>//DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<AccountGroup> AccountGroups { get; set; } = null!;
    public DbSet<AccountGroupTelegramAccount> AccountGroupTelegramAccounts { get; set; } = null!;
    public DbSet<Proxy> Proxies { get; set; } = null!;
    public DbSet<Profile> Profiles { get; set; } = null!;
    public DbSet<TelegramAccount> TelegramAccounts { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
            
        modelBuilder.Entity<TelegramAccount>()
            .HasOne(t => t.User)
            .WithMany(u => u.TelegramAccounts)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Proxy>()
            .HasOne(p => p.User)
            .WithMany(u => u.Proxies)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.ApplyConfiguration(new AccountGroupConfiguration());
        modelBuilder.ApplyConfiguration(new AccountGroupTelegramAccountConfiguration());
        modelBuilder.ApplyConfiguration(new ProxyConfiguration());
        modelBuilder.ApplyConfiguration(new ProfileConfiguration());
        modelBuilder.ApplyConfiguration(new TelegramAccountConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        

    }


}