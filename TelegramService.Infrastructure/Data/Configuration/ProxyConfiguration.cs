using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Enums;
using TelegramService.Infrastructure.Data.Models;

namespace TelegramService.Infrastructure.Data.Configuration;

public class ProxyConfiguration : IEntityTypeConfiguration<Proxy>
{
    public void Configure(EntityTypeBuilder<Proxy> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Address).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Port).IsRequired();
        builder.Property(p => p.ProxyType).IsRequired();
        builder.Property(p => p.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);
        builder.Property(p => p.ProxyStatus).IsRequired().HasDefaultValue(ProxyStatus.NotChecked);

        builder.HasOne<User>()
            .WithMany()
            .IsRequired()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        
    }
}