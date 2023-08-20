using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramService.Infrastructure.Data.Models;

[Table("AccountGroups")]
public class AccountGroup
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(70)]
    public string Name { get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public virtual ICollection<AccountGroupTelegramAccount> AccountGroupTelegramAccounts { get; set; }
}