using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Configuration;

public class TelegramAccountConfiguration : IEntityTypeConfiguration<TelegramAccount>
{
    public void Configure(EntityTypeBuilder<TelegramAccount> builder)
    {
        builder.ToTable("TelegramAccounts");
    }
}