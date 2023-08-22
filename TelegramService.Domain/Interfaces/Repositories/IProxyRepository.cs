using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IProxyRepository
{
    Task<IEnumerable<Proxy>> GetAllAsync();

    Task<Proxy> GetByGuidAsync();

    Task AddAsync();
    
    Task UpdateAsync();

    Task DeleteAsync();
}