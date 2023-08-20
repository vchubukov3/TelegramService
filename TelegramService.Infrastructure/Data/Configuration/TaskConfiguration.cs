using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramService.Infrastructure.Data.Models;
using TaskStatus = TelegramService.Infrastructure.Data.Enums.TaskStatus;

namespace TelegramService.Infrastructure.Data.Configuration;

public class TaskConfiguration : IEntityTypeConfiguration<Models.Task>
{
    public void Configure(EntityTypeBuilder<Models.Task> builder)
    {
        builder.ToTable("Tasks");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.TaskType).IsRequired();
        builder.Property(t => t.TaskStatus).HasDefaultValue(TaskStatus.NotStarted);
        builder.Property(t => t.Content).HasMaxLength(4096);
        builder.Property(t => t.CreatedOn).IsRequired().HasDefaultValue(DateTime.Now);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}