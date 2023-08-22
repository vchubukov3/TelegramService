using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Configuration;

public class ProfileConfiguration : IEntityTypeConfiguration<Models.Profile>
{
    public void Configure(EntityTypeBuilder<Models.Profile> builder)
    {
        builder.ToTable("Tasks");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.ProfileType).IsRequired();
        builder.Property(t => t.ProfileStatus).HasDefaultValue(ProfileStatus.NotStarted);
        builder.Property(t => t.Content).HasMaxLength(4096);
        builder.Property(t => t.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}