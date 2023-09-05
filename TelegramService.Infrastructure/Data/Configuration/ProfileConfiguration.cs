using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Configuration;

public class ProfileConfiguration : IEntityTypeConfiguration<Models.Profile>
{
    public void Configure(EntityTypeBuilder<Models.Profile> builder)
    {
        builder.ToTable("Profiles");
    }
}