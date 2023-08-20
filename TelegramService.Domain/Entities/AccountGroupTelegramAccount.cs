namespace TelegramService.Domain.Entities;

public class AccountGroupTelegramAccount
{
    public Guid AccountGroupId { get; set; }
    
    public Guid TelegramAccountId { get; set; }
}