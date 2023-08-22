using TelegramService.Shared.Enums;

namespace TelegramService.Domain.Entities;

public class Proxy
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    
    public string Address { get; set; }
    
    public int Port { get; set; }
    
    public ProxyType ProxyType { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public ProxyStatus ProxyStatus { get; set; }
}