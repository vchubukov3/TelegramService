using TelegramService.Shared.Enums;

namespace TelegramService.Shared.DTO;

public class ProxyDto
{
    public Guid Id { get; set; }

    public string UserId { get; set; }
    
    public string Address { get; set; }
    
    public int Port { get; set; }
    
    public ProxyType ProxyType { get; set; }
    
    public ProxyStatus ProxyStatus { get; set; }
    
    public bool IsActivate { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
}