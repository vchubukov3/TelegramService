using TelegramService.Domain.Enums;
using TaskStatus = TelegramService.Domain.Enums.TaskStatus;

namespace TelegramService.Domain.Entities;

public class Task
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    
    public TaskType TaskType { get; set; }
    
    public TaskStatus TaskStatus { get; set; }
    
    public MessageType MessageType { get; set; }
    
    public string Content { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public DateTimeOffset CompletedOn { get; set; }
}