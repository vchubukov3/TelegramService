using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Enums;
using TelegramService.Infrastructure.Data.Models;

namespace TelegramService.Infrastructure.Data.Configuration;

public class TelegramAccountConfiguration : IEntityTypeConfiguration<TelegramAccount>
{
    public void Configure(EntityTypeBuilder<TelegramAccount> builder)
    {
        builder.ToTable("TelegraamAccounts");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.AccountData).IsRequired();
        builder.Property(t => t.CreatedOn).IsRequired();
        builder.Property(t => t.Status).IsRequired().HasDefaultValue(AccountStatus.NotChecked);
        
        builder.HasOne(t => t.User)
            .WithMany()
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.Proxy)
            .WithMany()
            .HasForeignKey(t => t.ProxyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}