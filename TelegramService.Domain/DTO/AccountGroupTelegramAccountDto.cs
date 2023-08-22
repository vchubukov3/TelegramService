namespace TelegramService.Domain.Entities;

public class AccountGroupTelegramAccountDto
{
    public Guid AccountGroupId { get; set; }
    
    public Guid TelegramAccountId { get; set; }
}