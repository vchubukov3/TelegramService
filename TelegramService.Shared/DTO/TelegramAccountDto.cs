using TelegramService.Shared.Enums;

namespace TelegramService.Shared.DTO;

public class TelegramAccountDto
{
    public Guid Id { get; set; }
    
    public string UserId { get; set; }
    
    public string AccountData { get; set; }
    
    public Guid ProxyId { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public AccountStatus Status { get; set; }
}