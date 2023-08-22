using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IAccountGroupRepository
{
    Task<IEnumerable<AccountGroupDto>> GetAllAsync();
    
    Task<AccountGroupDto> GetByGuidAsync();
    
    Task AddAsync();
    
    Task UpdateAsync();
    
    Task DeleteAsync();
}