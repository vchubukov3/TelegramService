using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TelegramService.Infrastructure.Data.Enums;
using TaskStatus = TelegramService.Infrastructure.Data.Enums.TaskStatus;

namespace TelegramService.Infrastructure.Data.Models;

[Table("Tasks")]
public class Task
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public User UserId { get; set; }
    
    public virtual User User { get; set; }
    
    [Required]
    public TaskType TaskType { get; set; }
    
    [DefaultValue(TaskStatus.NotStarted)]
    public TaskStatus TaskStatus { get; set; }
    
    public MessageType MessageType {get; set;}
    
    [MaxLength(4096)]
    public string Content { get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public DateTimeOffset StartedOn { get; set; }
    
    public DateTimeOffset CompletedOn { get; set; }
}