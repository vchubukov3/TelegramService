using TelegramService.Shared.Enums;

namespace TelegramService.Domain.Entities;

public class ProfileDto
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    
    public ProfileType ProfileType { get; set; }
    
    public ProfileStatus ProfileStatus { get; set; }
    
    public MessageType MessageType { get; set; }
    
    public string Content { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public DateTimeOffset CompletedOn { get; set; }
}