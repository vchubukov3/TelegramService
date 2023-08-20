namespace TelegramService.Domain.Entities;

public class AccountGroup
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
}