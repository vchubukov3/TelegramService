using TelegramService.Shared.DTO;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IProxyRepository
{
    Task<IEnumerable<ProxyDto>> GetAllAsync();

    Task<ProxyDto> GetByUserIdAsync();

    Task AddAsync(ProxyDto proxyDto);
    
    Task UpdateAsync(ProxyDto proxyDto);

    Task DeleteAsync(ProxyDto proxyDto);

    Task SaveChangesAsync();

    Task CheckStatus(ProxyDto proxyDto);
}