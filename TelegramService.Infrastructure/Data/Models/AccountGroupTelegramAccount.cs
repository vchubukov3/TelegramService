using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramService.Infrastructure.Data.Models;

[Table("AccountGroupTelegramAccounts")]
public class AccountGroupTelegramAccount
{
    [Required]
    public Guid AccountGroupId { get; set; }
    
    //public virtual AccountGroup AccountGroup { get; set; }
    
    [Required]
    public Guid TelegramAccountId { get; set; }
    
    //public virtual TelegramAccount TelegramAccount { get; set; }
}