using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Models;

[Table("Proxies")]
public class Proxy
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    [ForeignKey("User")]
    public User UserId { get; set; }
    
    public virtual User User { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Address { get; set; }
    
    [Required]
    public int Port { get; set; }
    
    [Required]
    public ProxyType ProxyType {get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    [Required]
    [DefaultValue(ProxyStatus.NotChecked)]
    public ProxyStatus ProxyStatus { get; set; }
    
    public virtual ICollection<TelegramAccount> TelegramAccounts { get; set; }
    
    
}