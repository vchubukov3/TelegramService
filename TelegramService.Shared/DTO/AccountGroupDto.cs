namespace TelegramService.Shared.DTO;

public class AccountGroupDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
}