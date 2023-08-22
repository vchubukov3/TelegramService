using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Models;

[Table("TelegramAccounts")]
public class TelegramAccount
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [ForeignKey("User")]
    public User UserId { get; set; }
    
    public virtual User User { get; set; }
    
    [Required]
    public string AccountData { get; set; }
    
    [Required]
    public Proxy ProxyId { get; set; }
    
    public virtual Proxy Proxy { get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    [Required]
    [DefaultValue(AccountStatus.NotChecked)]
    public AccountStatus Status { get; set; }
}