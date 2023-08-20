using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramService.Infrastructure.Data.Models;

[Table("Users")]
public class User
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(320)]
    public string Email { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string PasswordHash { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Salt { get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }

    public DateTimeOffset? UpdatedOn { get; set; }
    
    public virtual ICollection<TelegramAccount> TelegramAccounts { get; set; }
    
    public virtual ICollection<Proxy> Proxies { get; set; }
}