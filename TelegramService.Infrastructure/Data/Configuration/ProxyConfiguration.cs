using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Configuration;

public class ProxyConfiguration : IEntityTypeConfiguration<Proxy>
{
    public void Configure(EntityTypeBuilder<Proxy> builder)
    {
        builder.ToTable("Proxies");
    }
}