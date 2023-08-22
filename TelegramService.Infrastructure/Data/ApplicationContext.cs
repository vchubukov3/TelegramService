using Microsoft.EntityFrameworkCore;
using TelegramService.Infrastructure.Data.Configuration;
using TelegramService.Shared.Enums;
using TelegramService.Infrastructure.Data.Models;

namespace TelegramService.Infrastructure.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
        optionsBuilder.UseSqlServer("your_connection_string_here");
        var context = new ApplicationContext(optionsBuilder.Options);
    }

    
    public DbSet<AccountGroup> AccountGroups { get; set; } = null!;
    public DbSet<AccountGroupTelegramAccount> AccountGroupTelegramAccounts { get; set; } = null!;
    public DbSet<Proxy> Proxies { get; set; } = null!;
    public DbSet<Models.Profile> Profiles { get; set; } = null!;
    public DbSet<TelegramAccount> TelegramAccounts { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountGroupConfiguration());
        modelBuilder.ApplyConfiguration(new AccountGroupTelegramAccountConfiguration());
        modelBuilder.ApplyConfiguration(new ProxyConfiguration());
        modelBuilder.ApplyConfiguration(new ProfileConfiguration());
        modelBuilder.ApplyConfiguration(new TelegramAccountConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }


}