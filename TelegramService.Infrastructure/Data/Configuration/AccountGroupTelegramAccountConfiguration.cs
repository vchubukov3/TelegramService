using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;

namespace TelegramService.Infrastructure.Data.Configuration;

public class AccountGroupTelegramAccountConfiguration : IEntityTypeConfiguration<AccountGroupTelegramAccount>
{
    public void Configure(EntityTypeBuilder<AccountGroupTelegramAccount> builder)
    {
        builder.ToTable("AccountGroupTelegramAccounts");
        builder.HasOne(a => a.AccountGroup)
            .WithMany()
            .HasForeignKey(a => a.AccountGroupId);
        
        builder.HasOne(a => a.TelegramAccountId)
            .WithMany()
            .HasForeignKey(a => a.TelegramAccountId);
    }
}