using TelegramService.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TelegramService.Domain.Interfaces.Repositories;

public interface IAccountGroupTelegramAccount
{
    Task<IEnumerable<AccountGroupTelegramAccountDto>> GetAllAsync();

    Task<AccountGroupTelegramAccountDto> GetByGuidAsync();

    Task AddAsync();

    Task UpdateAsync();

    Task DeleteAsync();
}