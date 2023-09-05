using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TelegramService.Shared.Enums;

namespace TelegramService.Infrastructure.Data.Models;

[Table("Profiles")]
public class Profile
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string UserId { get; set; }
    
    public virtual User User { get; set; }
    
    [Required]
    public ProfileType ProfileType { get; set; }
    
    [DefaultValue(ProfileStatus.NotStarted)]
    public ProfileStatus ProfileStatus { get; set; }
    
    public MessageType MessageType {get; set;}
    
    [MaxLength(4096)]
    public string Content { get; set; }
    
    [Required]
    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset UpdatedOn { get; set; }
    
    public DateTimeOffset StartedOn { get; set; }
    
    public DateTimeOffset CompletedOn { get; set; }
}