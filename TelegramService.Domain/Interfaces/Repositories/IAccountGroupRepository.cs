using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IAccountGroupRepository
{
    Task<IEnumerable<AccountGroup>> GetAllAsync();
    
    Task<AccountGroup> GetByIdAsync();
    
    Task AddAsync();
    
    Task UpdateAsync();
    
    Task DeleteAsync();
}