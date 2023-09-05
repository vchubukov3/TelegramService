using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TelegramService.Infrastructure.Data.Models;

[Table("Users")]
public class User : IdentityUser
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }

    public DateTimeOffset UpdatedOn { get; set; }
    
    public virtual ICollection<TelegramAccount> TelegramAccounts { get; set; }
    
    public virtual ICollection<Proxy> Proxies { get; set; }
}