using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;

namespace TelegramService.Infrastructure.Data.Configuration;

public class AccountGroupTelegramAccountConfiguration : IEntityTypeConfiguration<AccountGroupTelegramAccount>
{
    public void Configure(EntityTypeBuilder<AccountGroupTelegramAccount> builder)
    {
        builder.ToTable("AccountGroupTelegramAccounts");
        builder.HasKey(agta => new { agta.AccountGroupId, agta.TelegramAccountId });
    }
}